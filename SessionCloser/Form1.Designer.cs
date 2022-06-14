namespace SessionCloser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolProdD7 = new System.Windows.Forms.ToolStripButton();
            this.toolProdPL7 = new System.Windows.Forms.ToolStripButton();
            this.toolProdSK7 = new System.Windows.Forms.ToolStripButton();
            this.toolProdCN7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolProdBA7 = new System.Windows.Forms.ToolStripButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.GridUsers = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATimeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.toolProdMX7 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.LbLastRun = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BtnStartStop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TbUserPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TbUser = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.GridSessions = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastCallEt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolProdMX7)).BeginInit();
            this.toolProdMX7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolProdD7,
            this.toolProdPL7,
            this.toolProdSK7,
            this.toolProdCN7,
            this.toolStripButton1,
            this.toolProdBA7});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1583, 25);
            this.toolStrip.TabIndex = 1;
            // 
            // toolProdD7
            // 
            this.toolProdD7.Checked = true;
            this.toolProdD7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolProdD7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolProdD7.Image = ((System.Drawing.Image)(resources.GetObject("toolProdD7.Image")));
            this.toolProdD7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProdD7.Name = "toolProdD7";
            this.toolProdD7.Size = new System.Drawing.Size(56, 22);
            this.toolProdD7.Text = "PRODD7";
            this.toolProdD7.Click += new System.EventHandler(this.toolProdD7_Click);
            // 
            // toolProdPL7
            // 
            this.toolProdPL7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolProdPL7.Image = ((System.Drawing.Image)(resources.GetObject("toolProdPL7.Image")));
            this.toolProdPL7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProdPL7.Name = "toolProdPL7";
            this.toolProdPL7.Size = new System.Drawing.Size(61, 22);
            this.toolProdPL7.Text = "PRODPL7";
            this.toolProdPL7.Click += new System.EventHandler(this.toolProdPL7_Click);
            // 
            // toolProdSK7
            // 
            this.toolProdSK7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolProdSK7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProdSK7.Name = "toolProdSK7";
            this.toolProdSK7.Size = new System.Drawing.Size(61, 22);
            this.toolProdSK7.Text = "PRODSK7";
            this.toolProdSK7.Click += new System.EventHandler(this.toolProdSK7_Click);
            // 
            // toolProdCN7
            // 
            this.toolProdCN7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolProdCN7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProdCN7.Name = "toolProdCN7";
            this.toolProdCN7.Size = new System.Drawing.Size(65, 22);
            this.toolProdCN7.Text = "PRODCN7";
            this.toolProdCN7.Click += new System.EventHandler(this.toolProdCN7_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripButton1.Text = "PRODMX7";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolProdBA7
            // 
            this.toolProdBA7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolProdBA7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProdBA7.Name = "toolProdBA7";
            this.toolProdBA7.Size = new System.Drawing.Size(63, 22);
            this.toolProdBA7.Text = "PRODBA7";
            this.toolProdBA7.Click += new System.EventHandler(this.toolProdBA7_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonSplitContainer1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 25);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1583, 840);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonLabel4);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.GridUsers);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.kryptonHeader1);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.toolProdMX7);
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonLabel5);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.kryptonHeader2);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.GridSessions);
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1583, 840);
            this.kryptonSplitContainer1.SplitterDistance = 418;
            this.kryptonSplitContainer1.TabIndex = 0;
            // 
            // GridUsers
            // 
            this.GridUsers.AllowUserToAddRows = false;
            this.GridUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ATimeout,
            this.Flag});
            this.GridUsers.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.GridUsers.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.GridUsers.HideOuterBorders = true;
            this.GridUsers.Location = new System.Drawing.Point(0, 94);
            this.GridUsers.MultiSelect = false;
            this.GridUsers.Name = "GridUsers";
            this.GridUsers.RowHeadersVisible = false;
            this.GridUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUsers.Size = new System.Drawing.Size(1583, 321);
            this.GridUsers.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.GridUsers.StateCommon.DataCell.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.GridUsers.TabIndex = 3;
            this.GridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsers_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Users";
            this.dataGridViewTextBoxColumn1.HeaderText = "Users";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 527;
            // 
            // ATimeout
            // 
            this.ATimeout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ATimeout.DataPropertyName = "ATimeout";
            this.ATimeout.HeaderText = "Timeout";
            this.ATimeout.MinimumWidth = 100;
            this.ATimeout.Name = "ATimeout";
            this.ATimeout.ReadOnly = true;
            this.ATimeout.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Flag
            // 
            this.Flag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Flag.DataPropertyName = "Flag";
            this.Flag.HeaderText = "Flag";
            this.Flag.MinimumWidth = 100;
            this.Flag.Name = "Flag";
            this.Flag.ReadOnly = true;
            this.Flag.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 46);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(1583, 28);
            this.kryptonHeader1.TabIndex = 0;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "";
            this.kryptonHeader1.Values.Image = null;
            this.kryptonHeader1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonHeader1_Paint);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.ExtraText = "Edit";
            this.buttonSpecAny1.Image = global::SessionCloser.Properties.Resources.gtk_add;
            this.buttonSpecAny1.UniqueName = "335125660575404817B0E3034FB58F86";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // toolProdMX7
            // 
            this.toolProdMX7.Controls.Add(this.btnRefresh);
            this.toolProdMX7.Controls.Add(this.LbLastRun);
            this.toolProdMX7.Controls.Add(this.BtnStartStop);
            this.toolProdMX7.Controls.Add(this.kryptonLabel3);
            this.toolProdMX7.Controls.Add(this.TbUserPassword);
            this.toolProdMX7.Controls.Add(this.kryptonLabel2);
            this.toolProdMX7.Controls.Add(this.TbUser);
            this.toolProdMX7.Controls.Add(this.kryptonPanel2);
            this.toolProdMX7.Controls.Add(this.kryptonLabel1);
            this.toolProdMX7.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolProdMX7.Location = new System.Drawing.Point(0, 0);
            this.toolProdMX7.Name = "toolProdMX7";
            this.toolProdMX7.Size = new System.Drawing.Size(1583, 46);
            this.toolProdMX7.TabIndex = 0;
            this.toolProdMX7.Paint += new System.Windows.Forms.PaintEventHandler(this.toolProdMX7_Paint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(570, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 25);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Values.Text = "Refresh all lists";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // LbLastRun
            // 
            this.LbLastRun.Location = new System.Drawing.Point(139, 23);
            this.LbLastRun.Name = "LbLastRun";
            this.LbLastRun.Size = new System.Drawing.Size(15, 20);
            this.LbLastRun.TabIndex = 7;
            this.LbLastRun.Values.Text = "-";
            // 
            // BtnStartStop
            // 
            this.BtnStartStop.Location = new System.Drawing.Point(474, 3);
            this.BtnStartStop.Name = "BtnStartStop";
            this.BtnStartStop.Size = new System.Drawing.Size(90, 25);
            this.BtnStartStop.TabIndex = 6;
            this.BtnStartStop.Values.Text = "Start for all";
            this.BtnStartStop.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(16, 23);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(132, 20);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "Last automatic run on:";
            // 
            // TbUserPassword
            // 
            this.TbUserPassword.Location = new System.Drawing.Point(331, 3);
            this.TbUserPassword.Name = "TbUserPassword";
            this.TbUserPassword.PasswordChar = '*';
            this.TbUserPassword.Size = new System.Drawing.Size(119, 20);
            this.TbUserPassword.TabIndex = 4;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(269, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "password:";
            // 
            // TbUser
            // 
            this.TbUser.Location = new System.Drawing.Point(144, 3);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(119, 20);
            this.TbUser.TabIndex = 2;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel2.Location = new System.Drawing.Point(3, 68);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1577, 371);
            this.kryptonPanel2.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(145, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "User used to kill process:";
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny2});
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(1583, 28);
            this.kryptonHeader2.TabIndex = 3;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "";
            this.kryptonHeader2.Values.Image = null;
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.ExtraText = "Close";
            this.buttonSpecAny2.Image = global::SessionCloser.Properties.Resources.remove;
            this.buttonSpecAny2.UniqueName = "335125660575404817B0E3034FB58F86";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // GridSessions
            // 
            this.GridSessions.AllowUserToAddRows = false;
            this.GridSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Osuser,
            this.Program,
            this.Machine,
            this.Status,
            this.LastCallEt,
            this.Process});
            this.GridSessions.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.GridSessions.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.GridSessions.HideOuterBorders = true;
            this.GridSessions.Location = new System.Drawing.Point(3, 48);
            this.GridSessions.MultiSelect = false;
            this.GridSessions.Name = "GridSessions";
            this.GridSessions.RowHeadersVisible = false;
            this.GridSessions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSessions.Size = new System.Drawing.Size(1580, 366);
            this.GridSessions.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient;
            this.GridSessions.StateCommon.DataCell.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.GridSessions.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 100;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Osuser
            // 
            this.Osuser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Osuser.DataPropertyName = "Osuser";
            this.Osuser.HeaderText = "Osuser";
            this.Osuser.MinimumWidth = 100;
            this.Osuser.Name = "Osuser";
            this.Osuser.ReadOnly = true;
            this.Osuser.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Program
            // 
            this.Program.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Program.DataPropertyName = "Program";
            this.Program.HeaderText = "Program";
            this.Program.MinimumWidth = 100;
            this.Program.Name = "Program";
            this.Program.ReadOnly = true;
            this.Program.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Machine
            // 
            this.Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Machine.DataPropertyName = "Machine";
            this.Machine.HeaderText = "Machine";
            this.Machine.MinimumWidth = 100;
            this.Machine.Name = "Machine";
            this.Machine.ReadOnly = true;
            this.Machine.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 100;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LastCallEt
            // 
            this.LastCallEt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastCallEt.DataPropertyName = "LastCallEt";
            this.LastCallEt.HeaderText = "Last Infor Connection(min)";
            this.LastCallEt.MinimumWidth = 100;
            this.LastCallEt.Name = "LastCallEt";
            this.LastCallEt.ReadOnly = true;
            this.LastCallEt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Process
            // 
            this.Process.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Process.DataPropertyName = "Process";
            this.Process.HeaderText = "Process";
            this.Process.MinimumWidth = 100;
            this.Process.Name = "Process";
            this.Process.ReadOnly = true;
            this.Process.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(0, 74);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(86, 20);
            this.kryptonLabel4.TabIndex = 4;
            this.kryptonLabel4.Values.Text = "Configuration";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(3, 29);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(162, 20);
            this.kryptonLabel5.TabIndex = 5;
            this.kryptonLabel5.Values.Text = "Active users in the database";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 865);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.toolStrip);
            this.Name = "Form1";
            this.Text = "Session Closer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolProdMX7)).EndInit();
            this.toolProdMX7.ResumeLayout(false);
            this.toolProdMX7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolProdD7;
        private System.Windows.Forms.ToolStripButton toolProdPL7;
        private System.Windows.Forms.ToolStripButton toolProdSK7;
        private System.Windows.Forms.ToolStripButton toolProdBA7;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView GridSessions;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel toolProdMX7;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView GridUsers;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private System.Windows.Forms.ToolStripButton toolProdCN7;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TbUserPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TbUser;
        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnStartStop;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LbLastRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastCallEt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATimeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flag;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
    }
}

