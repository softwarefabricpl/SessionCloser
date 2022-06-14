using Oracle.DataAccess.Client;
using SessionCloser.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SessionCloser.Helpers
{
    public class CommonHelper
    {
        public static List<string> GetAdminUsers()
        {
            List<string> rl = new List<string>();

            string adminUsers = ConfigurationManager.AppSettings["AdminUsers"];
            if (!string.IsNullOrEmpty(adminUsers))
                rl = adminUsers.Split(';').ToList();

            return rl;
        }

        public static int GetDefaultTimeout()
        {
            return int.Parse(ConfigurationManager.AppSettings["DefaultTimeout"]);
        }

        public static int GetDefaultWorkerTimeout()
        {
            return int.Parse(ConfigurationManager.AppSettings["DefaultWorkerTimeout"]);
        }

        public static void ManualKill(string machine, string process, string user, string password)
        {
            string machineShort = string.Empty;
            if (machine.IndexOf("\\") != -1)
                machineShort = machine.Substring(machine.IndexOf("\\") + 1);
            else
                machineShort = machine;

            string batchFileContent = string.Format("TaskKill /F /S {0} /u {1} /p {2} /PID {3}", machineShort, user, password, process);
            string path = BatchHelper.WriteManualBatch(batchFileContent);
            BatchLogHelper.WriteLog("Creating local batch file:" + Environment.NewLine + batchFileContent);
            Thread.Sleep(300);
            Process p = new Process();

            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = path;
            p.Start();

            string output = p.StandardError.ReadToEnd();
            if (!string.IsNullOrEmpty(output))
                BatchLogHelper.WriteLog("Error: " + output);
            else
                LogHelper.WriteLog("Processes has been TaskKill", "Process[" + process + "] for machine '" + machine + "' has been closed!");

            Thread.Sleep(300);
            File.Delete(path);
        }

        public static bool Kill(string batchFileContent, MySortableBindingList<InforSessionModel> sessions)
        {
            bool success = false;
            string path = BatchHelper.WriteBatch(batchFileContent);
            string logContent = string.Empty;
            foreach (var item in sessions)
                logContent += "["+item.InforName+"] -> Process '" + item.Process + "' for machine '" + item.Machine + "' has been scheduled to close! User ['"+item.Osuser+"'] max timeout '"+item.UserTimeout+"', session open timeout '"+item.LastCallEt+"' " + Environment.NewLine;

            BatchLogHelper.WriteMultiLog("Creating local batch file with tasks to kill", logContent);
            Thread.Sleep(300);
            Process p = new Process();

            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = path;
            p.Start();
            string output = p.StandardError.ReadToEnd();
            output = output.Replace("The handle is invalid.", string.Empty);
            output = Regex.Replace(output, @"^\s+$[\r\n]*", @"\r\n", RegexOptions.Multiline);

            if (!string.IsNullOrEmpty(output))
                BatchLogHelper.WriteLog("Error: " + output);
            else
            {
                success = true;
     
            }
            

            Thread.Sleep(300);
            File.Delete(path);

            return success;
        }

        public static void ImportInforUsersFromFile(string connectionString , string fileName)
        {
            using (var oraConn = new OracleConnection(connectionString))
            {
                oraConn.Open();
                string line;
                StreamReader file = new StreamReader(Path.Combine(ConfigurationManager.AppSettings["ImportPath"], fileName));
                while ((line = file.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var tab = line.Split(';');
                        string user = tab[0];
                        int timeout = int.Parse(tab[2]);
                        #region Add to INFOR
                        var cmd = oraConn.CreateCommand();
                        cmd.CommandText = "insert into INFOR.uscloseranimals (users,atimeout,flag) values (:1,:2,:3) ";
                        cmd.Parameters.Add(new OracleParameter("1", user));
                        cmd.Parameters.Add(new OracleParameter("2", timeout));
                        cmd.Parameters.Add(new OracleParameter("3", "U"));
                        cmd.ExecuteNonQuery();
                        #endregion
                    }
                }

                file.Close();
            
            }

            //List<InforUserModel> rl = currentInforUsers;
            //var adminUsers = CommonHelper.GetAdminUsers();
            //foreach (var item in sessionUsers)
            //{
            //    if (!currentInforUsers.Any(x => x.Users.Trim() == item.UsernameShort.Trim()))
            //    {
            //        int timeout = CommonHelper.GetDefaultTimeout();
            //        if (adminUsers.Any(x => x.ToLower() == item.Osuser))
            //        {
            //            timeout = 999;//infinity
            //        }

            //        var newItem = new InforUserModel();
            //        newItem.Users = item.UsernameShort;
            //        newItem.ATimeout = timeout;
            //        newItem.Flag = "A";

            //        #region Add to INFOR
            //        var cmd = oraConn.CreateCommand();
            //        cmd.CommandText = "insert into INFOR.uscloseranimals (users,atimeout,flag) values (:1,:2,:3) ";
            //        cmd.Parameters.Add(new OracleParameter("1", item.UsernameShort.Trim()));
            //        cmd.Parameters.Add(new OracleParameter("2", timeout));
            //        cmd.Parameters.Add(new OracleParameter("3", "A"));
            //        cmd.ExecuteNonQuery();
            //        #endregion

            //        rl.Add(newItem);
            //    }
            //}
          //  return rl;
        }
    }
}

