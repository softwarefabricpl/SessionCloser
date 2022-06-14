using ComponentFactory.Krypton.Toolkit;
using Oracle.DataAccess.Client;
using SessionCloser.Helpers;
using SessionCloser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SessionCloser.Forms;

namespace SessionCloser
{
    public partial class Form1 : KryptonForm
    {
        private string inforConnectionString = null;
        public Form1()
        {
            InitializeComponent();
            //Helpers.CommonHelper.ImportInforUsersFromFile(ConfigurationManager.AppSettings["InforPRODD7"], "Animals_prodd7.txt");
            //Helpers.CommonHelper.ImportInforUsersFromFile(ConfigurationManager.AppSettings["InforPRODSK7"], "Animals_prodsk7.txt");
            //Helpers.CommonHelper.ImportInforUsersFromFile(ConfigurationManager.AppSettings["InforPRODMX7"], "Animals_prodmx7.txt");
            //Helpers.CommonHelper.ImportInforUsersFromFile(ConfigurationManager.AppSettings["InforPRODPL7"], "Animals_prodpl7.txt");
            // Helpers.CommonHelper.ImportInforUsersFromFile(ConfigurationManager.AppSettings["InforPRODBA7"], "Animals_prodba7.txt");
            GridSessions.AutoGenerateColumns = false;
            RefreshSessionGrid(ConfigurationManager.AppSettings["InforPRODD7"]);
         
            //InforSessionHelper.DeleteInforUser(ConfigurationManager.AppSettings["InforPRODD7"]);
            //InforSessionHelper.DeleteInforUser(ConfigurationManager.AppSettings["InforPRODSK7"]);
            //InforSessionHelper.DeleteInforUser(ConfigurationManager.AppSettings["InforPRODPL7"]);
            //InforSessionHelper.DeleteInforUser(ConfigurationManager.AppSettings["InforPRODCN7"]);
            //InforSessionHelper.DeleteInforUser(ConfigurationManager.AppSettings["InforPRODMX7"]);
        }

        private void toolProdSK7_Click(object sender, EventArgs e)
        {
            ClearHeaderCheckedStage();
            toolProdSK7.Checked = true;
            RefreshSessionGrid(ConfigurationManager.AppSettings["InforPRODSK7"]);
        }

        private void toolProdD7_Click(object sender, EventArgs e)
        {
            ClearHeaderCheckedStage();
            toolProdD7.Checked = true;
            RefreshSessionGrid(ConfigurationManager.AppSettings["InforPRODD7"]);
        }

        private void toolProdPL7_Click(object sender, EventArgs e)
        {
            ClearHeaderCheckedStage();
            toolProdPL7.Checked = true;
            RefreshSessionGrid(ConfigurationManager.AppSettings["InforPRODPL7"]);
        }

        private void toolProdCN7_Click(object sender, EventArgs e)
        {
            ClearHeaderCheckedStage();
            toolProdCN7.Checked = true;
            RefreshSessionGrid(ConfigurationManager.AppSettings["InforPRODCN7"]);
        }
        private void toolProdMXX7_Click(object sender, EventArgs e)
        {
            ClearHeaderCheckedStage();
            toolStripButton1.Checked = true;
            RefreshSessionGrid(ConfigurationManager.AppSettings["InforPRODMX7"]);
        }
        private void toolProdBA7_Click(object sender, EventArgs e)
        {
            ClearHeaderCheckedStage();
            toolProdBA7.Checked = true;
            RefreshSessionGrid(ConfigurationManager.AppSettings["InforPRODBA7"]);
        }

        private void ClearHeaderCheckedStage()
        {
            toolStripButton1.Checked = false;
            toolProdD7.Checked = false;
            toolProdPL7.Checked = false;
            toolProdSK7.Checked = false;
            toolProdCN7.Checked = false;
            toolProdBA7.Checked = false;
        }

        private void RefreshSessionGrid(string connectionString)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                inforConnectionString = connectionString;
                using (var oraConn = new OracleConnection(connectionString))
                {
                    oraConn.Open();

                    var rl = InforSessionHelper.GetOpenInforSessions(oraConn);
                    GridSessions.DataSource = null;
                    GridSessions.Rows.Clear();
                    GridSessions.DataSource = rl;
                    GridSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    GridSessions.AutoResizeColumns();

                    var rl2 = InforSessionHelper.GetInforUsers(oraConn);
                    var updatedR2 = InforSessionHelper.RefreshInforUsers(oraConn, rl2, rl);
                    GridUsers.DataSource = null;
                    GridUsers.Rows.Clear();
                
                    GridUsers.DataSource = updatedR2;
                    GridUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    GridUsers.AutoResizeColumns();
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                ErrorLogHelper.WriteLog(ex);
                MessageBox.Show("Exception has been throws:" + ex.Message);
            }

        }
      
        private void RefreshCurrentSessionGrid(OracleConnection oraConn)
        {
            var rl = InforSessionHelper.GetOpenInforSessions(oraConn);
            GridSessions.DataSource = null;
            GridSessions.Rows.Clear();
            GridSessions.DataSource = rl;
            GridSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridSessions.AutoResizeColumns();

            var rl2 = InforSessionHelper.GetInforUsers(oraConn);
            var updatedR2 = InforSessionHelper.RefreshInforUsers(oraConn, rl2, rl);
            GridUsers.DataSource = null;
            GridUsers.Rows.Clear();
            GridUsers.DataSource = updatedR2;
            GridUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridUsers.AutoResizeColumns();
        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            if (GridUsers.SelectedRows.Count > 0)
            {
                try
                {
                    FormEditInforUser form = new FormEditInforUser((string)GridUsers.SelectedRows[0].Cells[0].Value, (int)GridUsers.SelectedRows[0].Cells[1].Value);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;
                        using (var oraConn = new OracleConnection(inforConnectionString))
                        {
                            oraConn.Open();

                            InforSessionHelper.UpdateInforUserTimeout(oraConn, (string)GridUsers.SelectedRows[0].Cells[0].Value, form.CurrentUserTimeout);
                            var rl2 = InforSessionHelper.GetInforUsers(oraConn);
                            GridUsers.DataSource = null;
                            GridUsers.Rows.Clear();
                            GridUsers.DataSource = rl2;
                            GridUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            GridUsers.AutoResizeColumns();
                        }

                        Cursor = Cursors.Default;
                    }
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    ErrorLogHelper.WriteLog(ex);
                    MessageBox.Show("Exception has been throws:" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You have to select row!");
            }
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            if (GridSessions.SelectedRows.Count > 0 && !string.IsNullOrEmpty(TbUser.Text) && !string.IsNullOrEmpty(TbUserPassword.Text))
            {
                try
                {
                    FormCloseSession form = new FormCloseSession((string)GridSessions.SelectedRows[0].Cells[6].Value);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Cursor = Cursors.WaitCursor;
                        SessionCloser.Helpers.CommonHelper.ManualKill((string)GridSessions.SelectedRows[0].Cells[3].Value, (string)GridSessions.SelectedRows[0].Cells[6].Value, TbUser.Text, TbUserPassword.Text);
                        using (var oraConn = new OracleConnection(inforConnectionString))
                        {
                            oraConn.Open();
                            var rl = InforSessionHelper.GetOpenInforSessions(oraConn);
                            GridSessions.DataSource = null;
                            GridSessions.Rows.Clear();
                            GridSessions.DataSource = rl;
                            GridSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            GridSessions.AutoResizeColumns();
                        }

                        Cursor = Cursors.Default;
                    }
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    ErrorLogHelper.WriteLog(ex);
                    MessageBox.Show("Exception has been throws:" + ex.Message);
                }
            }
            else
            {
                if (GridSessions.SelectedRows.Count <= 0)
                    MessageBox.Show("You have to select row!");
                else
                    MessageBox.Show("User and password are reqired!");
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbUser.Text) && !string.IsNullOrEmpty(TbUserPassword.Text))
            {
                if (!timer1.Enabled)
                {
                    timer1.Interval = SessionCloser.Helpers.CommonHelper.GetDefaultWorkerTimeout() * 60000;
                    timer1.Enabled = true;
                    timer1.Start();
                    TbUser.Enabled = false;
                    TbUserPassword.Enabled = false;
                    BtnStartStop.Text = "Stop for all";
                    RunCheckProcess();
                }
                else
                {
                    timer1.Enabled = false;
                    timer1.Stop();
                    TbUser.Enabled = true;
                    TbUserPassword.Enabled = true;
                    BtnStartStop.Text = "Start for all";
                }
            }
            else
                MessageBox.Show("User and password are reqired!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RunCheckProcess();
        }

        private void RunCheckProcess()
        {
            try
            {
                btnRefresh.Enabled = false;
                   Cursor = Cursors.WaitCursor;
                string batchFileContent = string.Empty;
                MySortableBindingList<InforSessionModel> sessions = new MySortableBindingList<InforSessionModel>();
                InforSessionHelper.RunCheckProcess(ConfigurationManager.AppSettings["InforPRODD7"], ref batchFileContent, ref sessions, TbUser.Text, TbUserPassword.Text, "PRODD7");
                InforSessionHelper.RunCheckProcess(ConfigurationManager.AppSettings["InforPRODPL7"], ref batchFileContent, ref sessions, TbUser.Text, TbUserPassword.Text, "PRODPL7");
                InforSessionHelper.RunCheckProcess(ConfigurationManager.AppSettings["InforPRODSK7"], ref batchFileContent, ref sessions, TbUser.Text, TbUserPassword.Text, "PRODSK7");
                InforSessionHelper.RunCheckProcess(ConfigurationManager.AppSettings["InforPRODCN7"], ref batchFileContent, ref sessions, TbUser.Text, TbUserPassword.Text, "PRODCN7");
                InforSessionHelper.RunCheckProcess(ConfigurationManager.AppSettings["InforPRODMX7"], ref batchFileContent, ref sessions, TbUser.Text, TbUserPassword.Text, "PRODMX7");
                InforSessionHelper.RunCheckProcess(ConfigurationManager.AppSettings["InforPRODBA7"], ref batchFileContent, ref sessions, TbUser.Text, TbUserPassword.Text, "PRODBA7");
                bool success=true;
                if (!string.IsNullOrEmpty(batchFileContent))
                {
                    success = SessionCloser.Helpers.CommonHelper.Kill(batchFileContent, sessions);

                    using (var oraConn = new OracleConnection(inforConnectionString))
                    {
                        oraConn.Open();
                        RefreshCurrentSessionGrid(oraConn);
                    }
                }

                LbLastRun.Text = DateTime.Now.ToString() + (success == true ? " [SUCCSESS]" : " [FAILED]");
                Cursor = Cursors.Default;
                btnRefresh.Enabled = true;

            }
            catch (Exception ex)
            {
                ErrorLogHelper.WriteLog(ex);
                LbLastRun.Text = DateTime.Now.ToString() + " [FAILED]";
                Cursor = Cursors.Default;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ClearHeaderCheckedStage();
            toolStripButton1.Checked = true;
            RefreshSessionGrid(ConfigurationManager.AppSettings["InforPRODMX7"]);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                using (var oraConn = new OracleConnection(inforConnectionString))
                {
                    oraConn.Open();
                    RefreshCurrentSessionGrid(oraConn);
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                ErrorLogHelper.WriteLog(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void toolProdMX7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonHeader1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
