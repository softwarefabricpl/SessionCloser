using Oracle.DataAccess.Client;
using SessionCloser.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCloser.Helpers
{
    public class InforSessionHelper
    {
        public static MySortableBindingList<InforSessionModel>  GetOpenInforSessions(OracleConnection oraConn)
        {
            MySortableBindingList<InforSessionModel> rl = new MySortableBindingList<InforSessionModel>();

            var cmd = oraConn.CreateCommand();
            cmd.CommandText = "select username,osuser,program,machine,status,LAST_CALL_ET,process " +
                              "from v$session where UPPER(program)='INFORCOM.EXE' order by LAST_CALL_ET desc  ";

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string processFull = reader.GetValue(6) + "";
                    string process = string.Empty;
                    if (processFull.IndexOf(":") != -1)
                        process = processFull.Substring(0, processFull.IndexOf(":"));
                    else
                        process = processFull;

                    if (!rl.Any(x => x.Process == process))
                    {
                        var item = new InforSessionModel();
                        item.Username = reader.GetValue(0) + "";
                        item.Osuser = reader.GetValue(1) + "";
                        item.Program = reader.GetValue(2) + "";
                        item.Machine = reader.GetValue(3) + "";
                        if (item.Osuser.IndexOf("\\") != -1)
                            item.UsernameShort = item.Osuser.Substring(item.Osuser.IndexOf("\\") + 1);
                        else
                            item.UsernameShort = item.Osuser;

                        item.Status = reader.GetValue(4) + "";
                        item.LastCallEt = (int)Math.Floor(Math.Round((decimal)reader.GetInt32(5) / 60, 0));

                        item.Process = process;

                        rl.Add(item);
                    }
                }
            }

            return rl;
        }

        public static MySortableBindingList<InforUserModel> GetInforUsers(OracleConnection oraConn)
        {
            MySortableBindingList<InforUserModel> rl = new MySortableBindingList<InforUserModel>();

            var cmd = oraConn.CreateCommand();
            cmd.CommandText = "select users,atimeout,flag " +
                              "from INFOR.uscloseranimals";

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var item = new InforUserModel();
                    item.Users = (reader.GetValue(0) + "").Trim();
                    item.ATimeout = reader.GetInt32(1);
                    item.Flag = reader.GetValue(2) + "";
                    rl.Add(item);
                }
            }

            return rl;
        }

        public static void UpdateInforUserTimeout(OracleConnection oraConn, string machine, int timeout)
        {
            List<InforUserModel> rl = new List<InforUserModel>();

            var cmd = oraConn.CreateCommand();
            cmd.CommandText = "update INFOR.uscloseranimals set atimeout=" + timeout + " where users= '" + machine.Trim() + "'";
            cmd.ExecuteNonQuery();
        }
        public static void DeleteInforUser(string connectionString)
        {
            using (var oraConn = new OracleConnection(connectionString))
            {
                oraConn.Open();

                var cmd = oraConn.CreateCommand();
                cmd.CommandText = "delete INFOR.uscloseranimals ";
                cmd.ExecuteNonQuery();
            }
        }

        public static MySortableBindingList<InforUserModel> RefreshInforUsers(OracleConnection oraConn, MySortableBindingList<InforUserModel> currentInforUsers, MySortableBindingList<InforSessionModel> sessionUsers)
        {
            MySortableBindingList<InforUserModel> rl = currentInforUsers;
            var adminUsers = CommonHelper.GetAdminUsers();
            foreach (var item in sessionUsers)
            {
                if (!currentInforUsers.Any(x => x.Users.Trim().ToLower() == item.UsernameShort.Trim().ToLower()))
                {
                    int timeout = CommonHelper.GetDefaultTimeout();
                    if (adminUsers.Any(x => x.ToLower() == item.Osuser))
                    {
                        timeout = -1;//infinity
                    }

                    var newItem = new InforUserModel();
                    newItem.Users = item.UsernameShort;
                    newItem.ATimeout = timeout;
                    newItem.Flag = "A";

                    #region Add to INFOR
                    var cmd = oraConn.CreateCommand();
                    cmd.CommandText = "insert into INFOR.uscloseranimals (users,atimeout,flag) values (:1,:2,:3) ";
                    cmd.Parameters.Add(new OracleParameter("1", item.UsernameShort.Trim()));
                    cmd.Parameters.Add(new OracleParameter("2", timeout));
                    cmd.Parameters.Add(new OracleParameter("3", "A"));
                    cmd.ExecuteNonQuery();
                    #endregion

                    rl.Add(newItem);
                }
            }
            return rl;
        }

        public static void RunCheckProcess(string connectionString, ref string batchFileContent,ref MySortableBindingList<InforSessionModel> sessions, string user, string password,string inforName)
        {
            using (var oraConn = new OracleConnection(connectionString))
            {
                oraConn.Open();

                var openSessions = GetOpenInforSessions(oraConn);
                var inforUsers = GetInforUsers(oraConn);
                var updatedInforUsers = RefreshInforUsers(oraConn, inforUsers, openSessions);

                foreach (var item in openSessions)
                {
                    var inforUser = updatedInforUsers.FirstOrDefault(x => x.Users.Trim().ToLower() == item.UsernameShort.Trim().ToLower());
                    if (inforUser != null && inforUser.ATimeout != -1 && inforUser.ATimeout <= item.LastCallEt)
                    {
                        string machineShort = string.Empty;
                        if (item.Machine.IndexOf("\\") != -1)
                            machineShort = item.Machine.Substring(item.Machine.IndexOf("\\") + 1);
                        else
                            machineShort = item.Machine;

                        item.InforName = inforName;
                        item.UserTimeout = inforUser.ATimeout;
                        sessions.Add(item);

                        batchFileContent += string.Format("TaskKill /F /S {0} /u {1} /p {2} /PID {3}", machineShort, user, password, item.Process);
                        batchFileContent += Environment.NewLine;
                    }
                }
            }
        }
    }
}

