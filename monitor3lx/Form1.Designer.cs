namespace monitor3lx
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
            this.tbLog = new System.Windows.Forms.TextBox();
            this.bConn = new System.Windows.Forms.Button();
            this.dgvTP = new System.Windows.Forms.DataGridView();
            this.bUpdateTP = new System.Windows.Forms.Button();
            this.b_Apply = new System.Windows.Forms.Button();
            this.pan_top = new System.Windows.Forms.Panel();
            this.pan_Connect = new System.Windows.Forms.Panel();
            this.tb_kfp = new System.Windows.Forms.TextBox();
            this.l_kfp = new System.Windows.Forms.Label();
            this.b_down_inv = new System.Windows.Forms.Button();
            this.b_up_inv = new System.Windows.Forms.Button();
            this.b_down_ = new System.Windows.Forms.Button();
            this.b_Up_ = new System.Windows.Forms.Button();
            this.l_Kfs_with_TP = new System.Windows.Forms.Label();
            this.timer_BC = new System.Windows.Forms.Timer(this.components);
            this.timer_keepconn = new System.Windows.Forms.Timer(this.components);
            this.timer_exprobot = new System.Windows.Forms.Timer(this.components);
            this.t_Expiration = new System.Windows.Forms.TabPage();
            this.pan_ExpRed = new System.Windows.Forms.Panel();
            this.cb_AutoExp = new System.Windows.Forms.CheckBox();
            this.b_exp_itteration = new System.Windows.Forms.Button();
            this.dgv_Exp_Robotsett = new System.Windows.Forms.DataGridView();
            this.b_exp_state = new System.Windows.Forms.Button();
            this.t_BasisCount = new System.Windows.Forms.TabPage();
            this.b_loadParams = new System.Windows.Forms.Button();
            this.dgv_LParams = new System.Windows.Forms.DataGridView();
            this.dgv_BC_Params = new System.Windows.Forms.DataGridView();
            this.l_BC_Params = new System.Windows.Forms.Label();
            this.cb_BC_Autoreload = new System.Windows.Forms.CheckBox();
            this.tb_BC_Interval = new System.Windows.Forms.TextBox();
            this.b_BC_Set = new System.Windows.Forms.Button();
            this.b_BC_Load = new System.Windows.Forms.Button();
            this.dgv_BC_settings = new System.Windows.Forms.DataGridView();
            this.t_FinresHistory = new System.Windows.Forms.TabPage();
            this.dgv_AssetMove = new System.Windows.Forms.DataGridView();
            this.pan_AssetMoves = new System.Windows.Forms.Panel();
            this.cb_CommentsVar = new System.Windows.Forms.ComboBox();
            this.b_Add = new System.Windows.Forms.Button();
            this.dtp_MoveDate = new System.Windows.Forms.DateTimePicker();
            this.l_AssetMove = new System.Windows.Forms.Label();
            this.l_Date = new System.Windows.Forms.Label();
            this.l_Comment = new System.Windows.Forms.Label();
            this.l_Value = new System.Windows.Forms.Label();
            this.tb_Value = new System.Windows.Forms.TextBox();
            this.pan_FinresHist = new System.Windows.Forms.Panel();
            this.lFRH_TP = new System.Windows.Forms.Label();
            this.bFRH_Show = new System.Windows.Forms.Button();
            this.cbFRH_TP = new System.Windows.Forms.ComboBox();
            this.dgvFRH = new System.Windows.Forms.DataGridView();
            this.t_Finres = new System.Windows.Forms.TabPage();
            this.bFR_AddSave = new System.Windows.Forms.Button();
            this.lFR_AddFull = new System.Windows.Forms.Label();
            this.lFR_WithAdd = new System.Windows.Forms.Label();
            this.lFR_Addition = new System.Windows.Forms.Label();
            this.tbFR_Addition = new System.Windows.Forms.TextBox();
            this.lFR_Result = new System.Windows.Forms.Label();
            this.lFR_FullResult = new System.Windows.Forms.Label();
            this.dgvFR_Reval = new System.Windows.Forms.DataGridView();
            this.lFR_TP = new System.Windows.Forms.Label();
            this.cbFR_TP = new System.Windows.Forms.ComboBox();
            this.bFR_Count = new System.Windows.Forms.Button();
            this.lFR_Date = new System.Windows.Forms.Label();
            this.dtpFR_date = new System.Windows.Forms.DateTimePicker();
            this.t_CurrPos = new System.Windows.Forms.TabPage();
            this.l_OrdersDelays = new System.Windows.Forms.Label();
            this.dgvDelays = new System.Windows.Forms.DataGridView();
            this.b_FullBall = new System.Windows.Forms.Button();
            this.dgvFullBalance = new System.Windows.Forms.DataGridView();
            this.l_TP_Balance = new System.Windows.Forms.Label();
            this.dgvTPBalances = new System.Windows.Forms.DataGridView();
            this.b_CurrPos = new System.Windows.Forms.Button();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.t_TPStruct = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_tps_import = new System.Windows.Forms.Button();
            this.l_tps_upload = new System.Windows.Forms.Label();
            this.cb_tps_acc1 = new System.Windows.Forms.ComboBox();
            this.l_tps_acc1 = new System.Windows.Forms.Label();
            this.l_tps_tpid1 = new System.Windows.Forms.Label();
            this.l_tps_tmp2 = new System.Windows.Forms.Label();
            this.dgv_tps_hedgekf = new System.Windows.Forms.DataGridView();
            this.Column_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hedgekf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_tps_sec = new System.Windows.Forms.Panel();
            this.b_tps_delete = new System.Windows.Forms.Button();
            this.b_tps_addupdate = new System.Windows.Forms.Button();
            this.tb_tps_p2pkf = new System.Windows.Forms.TextBox();
            this.l_tps_p2pkf = new System.Windows.Forms.Label();
            this.tb_tps_pdkf = new System.Windows.Forms.TextBox();
            this.l_tps_pfkf = new System.Windows.Forms.Label();
            this.tb_tps_hedgekf = new System.Windows.Forms.TextBox();
            this.l_tps_hedgekf = new System.Windows.Forms.Label();
            this.cb_tps_acc = new System.Windows.Forms.ComboBox();
            this.l_tps_acc = new System.Windows.Forms.Label();
            this.cb_tps_pdfor = new System.Windows.Forms.ComboBox();
            this.l_tps_pdto = new System.Windows.Forms.Label();
            this.cb_tps_sectype = new System.Windows.Forms.ComboBox();
            this.l_tps_sectype = new System.Windows.Forms.Label();
            this.cb_tps_code = new System.Windows.Forms.ComboBox();
            this.l_tps_code = new System.Windows.Forms.Label();
            this.l_tps_tpid = new System.Windows.Forms.Label();
            this.l_tps_tmp1 = new System.Windows.Forms.Label();
            this.dgv_tps_tpsec = new System.Windows.Forms.DataGridView();
            this.p_tps_tp = new System.Windows.Forms.Panel();
            this.l_tps_addedit = new System.Windows.Forms.Label();
            this.cb_tps_struct = new System.Windows.Forms.CheckBox();
            this.cb_tps_params = new System.Windows.Forms.CheckBox();
            this.tb_tps_id = new System.Windows.Forms.TextBox();
            this.cb_tps_copyfrom = new System.Windows.Forms.ComboBox();
            this.l_tps_name = new System.Windows.Forms.Label();
            this.l_tps_copy = new System.Windows.Forms.Label();
            this.tb_tps_name = new System.Windows.Forms.TextBox();
            this.b_tps_savetp = new System.Windows.Forms.Button();
            this.cb_tps_active = new System.Windows.Forms.CheckBox();
            this.dgv_tps_list = new System.Windows.Forms.DataGridView();
            this.b_tps_restore = new System.Windows.Forms.Button();
            this.p_Commands = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.b_mess_start = new System.Windows.Forms.Button();
            this.b_mess_stop = new System.Windows.Forms.Button();
            this.b_mess_stophedge = new System.Windows.Forms.Button();
            this.b_mess_starthedge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).BeginInit();
            this.pan_top.SuspendLayout();
            this.pan_Connect.SuspendLayout();
            this.t_Expiration.SuspendLayout();
            this.pan_ExpRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exp_Robotsett)).BeginInit();
            this.t_BasisCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BC_Params)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BC_settings)).BeginInit();
            this.t_FinresHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssetMove)).BeginInit();
            this.pan_AssetMoves.SuspendLayout();
            this.pan_FinresHist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFRH)).BeginInit();
            this.t_Finres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFR_Reval)).BeginInit();
            this.t_CurrPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTPBalances)).BeginInit();
            this.tabControl_Main.SuspendLayout();
            this.t_TPStruct.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tps_hedgekf)).BeginInit();
            this.p_tps_sec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tps_tpsec)).BeginInit();
            this.p_tps_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tps_list)).BeginInit();
            this.p_Commands.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLog.Location = new System.Drawing.Point(0, 789);
            this.tbLog.Margin = new System.Windows.Forms.Padding(2);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(1534, 72);
            this.tbLog.TabIndex = 0;
            // 
            // bConn
            // 
            this.bConn.BackColor = System.Drawing.Color.White;
            this.bConn.Location = new System.Drawing.Point(3, 4);
            this.bConn.Margin = new System.Windows.Forms.Padding(2);
            this.bConn.Name = "bConn";
            this.bConn.Size = new System.Drawing.Size(112, 28);
            this.bConn.TabIndex = 1;
            this.bConn.Text = "Connect";
            this.bConn.UseVisualStyleBackColor = false;
            this.bConn.Click += new System.EventHandler(this.ConnClick);
            // 
            // dgvTP
            // 
            this.dgvTP.AllowDrop = true;
            this.dgvTP.AllowUserToAddRows = false;
            this.dgvTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTP.Location = new System.Drawing.Point(9, 42);
            this.dgvTP.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTP.Name = "dgvTP";
            this.dgvTP.RowHeadersWidth = 5;
            this.dgvTP.RowTemplate.Height = 24;
            this.dgvTP.Size = new System.Drawing.Size(1513, 176);
            this.dgvTP.TabIndex = 3;
            this.dgvTP.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditFinished);
            this.dgvTP.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EnterTpTable);
            this.dgvTP.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.WrongData);
            // 
            // bUpdateTP
            // 
            this.bUpdateTP.BackColor = System.Drawing.Color.White;
            this.bUpdateTP.Enabled = false;
            this.bUpdateTP.Location = new System.Drawing.Point(1410, 223);
            this.bUpdateTP.Margin = new System.Windows.Forms.Padding(2);
            this.bUpdateTP.Name = "bUpdateTP";
            this.bUpdateTP.Size = new System.Drawing.Size(112, 28);
            this.bUpdateTP.TabIndex = 4;
            this.bUpdateTP.Text = "update TP";
            this.bUpdateTP.UseVisualStyleBackColor = false;
            this.bUpdateTP.Click += new System.EventHandler(this.updateTPclick);
            // 
            // b_Apply
            // 
            this.b_Apply.BackColor = System.Drawing.Color.White;
            this.b_Apply.Enabled = false;
            this.b_Apply.Location = new System.Drawing.Point(9, 223);
            this.b_Apply.Margin = new System.Windows.Forms.Padding(2);
            this.b_Apply.Name = "b_Apply";
            this.b_Apply.Size = new System.Drawing.Size(112, 28);
            this.b_Apply.TabIndex = 5;
            this.b_Apply.Text = "Apply";
            this.b_Apply.UseVisualStyleBackColor = false;
            this.b_Apply.Click += new System.EventHandler(this.b_Apply_Click);
            // 
            // pan_top
            // 
            this.pan_top.BackColor = System.Drawing.Color.Silver;
            this.pan_top.Controls.Add(this.pan_Connect);
            this.pan_top.Controls.Add(this.b_down_inv);
            this.pan_top.Controls.Add(this.b_up_inv);
            this.pan_top.Controls.Add(this.b_down_);
            this.pan_top.Controls.Add(this.b_Up_);
            this.pan_top.Controls.Add(this.l_Kfs_with_TP);
            this.pan_top.Controls.Add(this.b_Apply);
            this.pan_top.Controls.Add(this.dgvTP);
            this.pan_top.Controls.Add(this.bUpdateTP);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Margin = new System.Windows.Forms.Padding(2);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(1534, 262);
            this.pan_top.TabIndex = 6;
            // 
            // pan_Connect
            // 
            this.pan_Connect.BackColor = System.Drawing.Color.Gray;
            this.pan_Connect.Controls.Add(this.tb_kfp);
            this.pan_Connect.Controls.Add(this.bConn);
            this.pan_Connect.Controls.Add(this.l_kfp);
            this.pan_Connect.Location = new System.Drawing.Point(10, 4);
            this.pan_Connect.Name = "pan_Connect";
            this.pan_Connect.Size = new System.Drawing.Size(408, 35);
            this.pan_Connect.TabIndex = 13;
            // 
            // tb_kfp
            // 
            this.tb_kfp.Location = new System.Drawing.Point(239, 9);
            this.tb_kfp.Margin = new System.Windows.Forms.Padding(2);
            this.tb_kfp.Name = "tb_kfp";
            this.tb_kfp.PasswordChar = '*';
            this.tb_kfp.Size = new System.Drawing.Size(164, 20);
            this.tb_kfp.TabIndex = 12;
            // 
            // l_kfp
            // 
            this.l_kfp.AutoSize = true;
            this.l_kfp.Location = new System.Drawing.Point(149, 12);
            this.l_kfp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_kfp.Name = "l_kfp";
            this.l_kfp.Size = new System.Drawing.Size(89, 13);
            this.l_kfp.TabIndex = 11;
            this.l_kfp.Text = "Key file password";
            // 
            // b_down_inv
            // 
            this.b_down_inv.Image = global::monitor3lx.Properties.Resources.downInv;
            this.b_down_inv.Location = new System.Drawing.Point(609, 223);
            this.b_down_inv.Margin = new System.Windows.Forms.Padding(2);
            this.b_down_inv.Name = "b_down_inv";
            this.b_down_inv.Size = new System.Drawing.Size(32, 34);
            this.b_down_inv.TabIndex = 10;
            this.b_down_inv.UseVisualStyleBackColor = true;
            this.b_down_inv.Click += new System.EventHandler(this.b_down_Inv);
            // 
            // b_up_inv
            // 
            this.b_up_inv.Image = global::monitor3lx.Properties.Resources.upInv;
            this.b_up_inv.Location = new System.Drawing.Point(573, 223);
            this.b_up_inv.Margin = new System.Windows.Forms.Padding(2);
            this.b_up_inv.Name = "b_up_inv";
            this.b_up_inv.Size = new System.Drawing.Size(32, 34);
            this.b_up_inv.TabIndex = 9;
            this.b_up_inv.UseVisualStyleBackColor = true;
            this.b_up_inv.Click += new System.EventHandler(this.b_up_Inv);
            // 
            // b_down_
            // 
            this.b_down_.Image = global::monitor3lx.Properties.Resources.down;
            this.b_down_.Location = new System.Drawing.Point(499, 223);
            this.b_down_.Margin = new System.Windows.Forms.Padding(2);
            this.b_down_.Name = "b_down_";
            this.b_down_.Size = new System.Drawing.Size(32, 34);
            this.b_down_.TabIndex = 8;
            this.b_down_.UseVisualStyleBackColor = true;
            this.b_down_.Click += new System.EventHandler(this.b_down_Click);
            // 
            // b_Up_
            // 
            this.b_Up_.Image = global::monitor3lx.Properties.Resources.up;
            this.b_Up_.Location = new System.Drawing.Point(463, 223);
            this.b_Up_.Margin = new System.Windows.Forms.Padding(2);
            this.b_Up_.Name = "b_Up_";
            this.b_Up_.Size = new System.Drawing.Size(32, 34);
            this.b_Up_.TabIndex = 7;
            this.b_Up_.UseVisualStyleBackColor = true;
            this.b_Up_.Click += new System.EventHandler(this.b_Up_Click);
            // 
            // l_Kfs_with_TP
            // 
            this.l_Kfs_with_TP.AutoSize = true;
            this.l_Kfs_with_TP.Location = new System.Drawing.Point(254, 230);
            this.l_Kfs_with_TP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Kfs_with_TP.Name = "l_Kfs_with_TP";
            this.l_Kfs_with_TP.Size = new System.Drawing.Size(40, 13);
            this.l_Kfs_with_TP.TabIndex = 6;
            this.l_Kfs_with_TP.Text = "Kfs for ";
            // 
            // timer_BC
            // 
            this.timer_BC.Interval = 60000;
            this.timer_BC.Tick += new System.EventHandler(this.BC_Timer_Work);
            // 
            // timer_keepconn
            // 
            this.timer_keepconn.Interval = 300000;
            this.timer_keepconn.Tick += new System.EventHandler(this.KeepConnect);
            // 
            // timer_exprobot
            // 
            this.timer_exprobot.Interval = 2000;
            this.timer_exprobot.Tick += new System.EventHandler(this.timer_ExpRobot);
            // 
            // t_Expiration
            // 
            this.t_Expiration.BackColor = System.Drawing.Color.Thistle;
            this.t_Expiration.Controls.Add(this.pan_ExpRed);
            this.t_Expiration.Controls.Add(this.dgv_Exp_Robotsett);
            this.t_Expiration.Controls.Add(this.b_exp_state);
            this.t_Expiration.ForeColor = System.Drawing.SystemColors.MenuText;
            this.t_Expiration.Location = new System.Drawing.Point(4, 31);
            this.t_Expiration.Name = "t_Expiration";
            this.t_Expiration.Size = new System.Drawing.Size(1526, 492);
            this.t_Expiration.TabIndex = 5;
            this.t_Expiration.Text = "Expiration";
            // 
            // pan_ExpRed
            // 
            this.pan_ExpRed.BackColor = System.Drawing.Color.Red;
            this.pan_ExpRed.Controls.Add(this.cb_AutoExp);
            this.pan_ExpRed.Controls.Add(this.b_exp_itteration);
            this.pan_ExpRed.Location = new System.Drawing.Point(418, 3);
            this.pan_ExpRed.Name = "pan_ExpRed";
            this.pan_ExpRed.Size = new System.Drawing.Size(649, 46);
            this.pan_ExpRed.TabIndex = 5;
            // 
            // cb_AutoExp
            // 
            this.cb_AutoExp.AutoSize = true;
            this.cb_AutoExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_AutoExp.Location = new System.Drawing.Point(404, 16);
            this.cb_AutoExp.Name = "cb_AutoExp";
            this.cb_AutoExp.Size = new System.Drawing.Size(196, 19);
            this.cb_AutoExp.TabIndex = 5;
            this.cb_AutoExp.Text = "Automatic Balance change";
            this.cb_AutoExp.UseVisualStyleBackColor = true;
            this.cb_AutoExp.CheckedChanged += new System.EventHandler(this.cb_Exp_CchekChange);
            // 
            // b_exp_itteration
            // 
            this.b_exp_itteration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.b_exp_itteration.Location = new System.Drawing.Point(12, 8);
            this.b_exp_itteration.Name = "b_exp_itteration";
            this.b_exp_itteration.Size = new System.Drawing.Size(182, 32);
            this.b_exp_itteration.TabIndex = 4;
            this.b_exp_itteration.Text = "Next itteration";
            this.b_exp_itteration.UseVisualStyleBackColor = false;
            this.b_exp_itteration.Click += new System.EventHandler(this.b_itteration_click);
            // 
            // dgv_Exp_Robotsett
            // 
            this.dgv_Exp_Robotsett.AllowUserToAddRows = false;
            this.dgv_Exp_Robotsett.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Exp_Robotsett.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Exp_Robotsett.Location = new System.Drawing.Point(8, 55);
            this.dgv_Exp_Robotsett.Name = "dgv_Exp_Robotsett";
            this.dgv_Exp_Robotsett.RowHeadersWidth = 5;
            this.dgv_Exp_Robotsett.Size = new System.Drawing.Size(1059, 306);
            this.dgv_Exp_Robotsett.TabIndex = 3;
            // 
            // b_exp_state
            // 
            this.b_exp_state.BackColor = System.Drawing.Color.WhiteSmoke;
            this.b_exp_state.Location = new System.Drawing.Point(8, 13);
            this.b_exp_state.Name = "b_exp_state";
            this.b_exp_state.Size = new System.Drawing.Size(163, 32);
            this.b_exp_state.TabIndex = 2;
            this.b_exp_state.Text = "Show current state";
            this.b_exp_state.UseVisualStyleBackColor = false;
            this.b_exp_state.Click += new System.EventHandler(this.b_State_click);
            // 
            // t_BasisCount
            // 
            this.t_BasisCount.BackColor = System.Drawing.Color.Gainsboro;
            this.t_BasisCount.Controls.Add(this.b_loadParams);
            this.t_BasisCount.Controls.Add(this.dgv_LParams);
            this.t_BasisCount.Controls.Add(this.dgv_BC_Params);
            this.t_BasisCount.Controls.Add(this.l_BC_Params);
            this.t_BasisCount.Controls.Add(this.cb_BC_Autoreload);
            this.t_BasisCount.Controls.Add(this.tb_BC_Interval);
            this.t_BasisCount.Controls.Add(this.b_BC_Set);
            this.t_BasisCount.Controls.Add(this.b_BC_Load);
            this.t_BasisCount.Controls.Add(this.dgv_BC_settings);
            this.t_BasisCount.Location = new System.Drawing.Point(4, 31);
            this.t_BasisCount.Name = "t_BasisCount";
            this.t_BasisCount.Size = new System.Drawing.Size(1526, 492);
            this.t_BasisCount.TabIndex = 2;
            this.t_BasisCount.Text = "Basis Count";
            this.t_BasisCount.Enter += new System.EventHandler(this.BC_Enter);
            // 
            // b_loadParams
            // 
            this.b_loadParams.BackColor = System.Drawing.Color.WhiteSmoke;
            this.b_loadParams.Location = new System.Drawing.Point(691, 212);
            this.b_loadParams.Name = "b_loadParams";
            this.b_loadParams.Size = new System.Drawing.Size(111, 23);
            this.b_loadParams.TabIndex = 8;
            this.b_loadParams.Text = "Load Parameters";
            this.b_loadParams.UseVisualStyleBackColor = false;
            this.b_loadParams.Click += new System.EventHandler(this.b_loadParams_Click);
            // 
            // dgv_LParams
            // 
            this.dgv_LParams.AllowUserToAddRows = false;
            this.dgv_LParams.AllowUserToDeleteRows = false;
            this.dgv_LParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LParams.Location = new System.Drawing.Point(691, 241);
            this.dgv_LParams.Name = "dgv_LParams";
            this.dgv_LParams.RowHeadersWidth = 5;
            this.dgv_LParams.Size = new System.Drawing.Size(826, 181);
            this.dgv_LParams.TabIndex = 7;
            // 
            // dgv_BC_Params
            // 
            this.dgv_BC_Params.AllowUserToAddRows = false;
            this.dgv_BC_Params.AllowUserToDeleteRows = false;
            this.dgv_BC_Params.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BC_Params.Cursor = System.Windows.Forms.Cursors.No;
            this.dgv_BC_Params.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_BC_Params.Location = new System.Drawing.Point(11, 241);
            this.dgv_BC_Params.Name = "dgv_BC_Params";
            this.dgv_BC_Params.RowHeadersWidth = 5;
            this.dgv_BC_Params.Size = new System.Drawing.Size(659, 181);
            this.dgv_BC_Params.TabIndex = 6;
            this.dgv_BC_Params.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.BC_EndEdit);
            // 
            // l_BC_Params
            // 
            this.l_BC_Params.AutoSize = true;
            this.l_BC_Params.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_BC_Params.Location = new System.Drawing.Point(8, 215);
            this.l_BC_Params.Name = "l_BC_Params";
            this.l_BC_Params.Size = new System.Drawing.Size(174, 16);
            this.l_BC_Params.TabIndex = 5;
            this.l_BC_Params.Text = "Basis Count Parameters";
            // 
            // cb_BC_Autoreload
            // 
            this.cb_BC_Autoreload.AutoSize = true;
            this.cb_BC_Autoreload.Location = new System.Drawing.Point(1247, 18);
            this.cb_BC_Autoreload.Name = "cb_BC_Autoreload";
            this.cb_BC_Autoreload.Size = new System.Drawing.Size(173, 17);
            this.cb_BC_Autoreload.TabIndex = 4;
            this.cb_BC_Autoreload.Text = "Autoreload.   Interval (seconds)";
            this.cb_BC_Autoreload.UseVisualStyleBackColor = true;
            this.cb_BC_Autoreload.CheckStateChanged += new System.EventHandler(this.BC_Autoreload_check);
            // 
            // tb_BC_Interval
            // 
            this.tb_BC_Interval.Location = new System.Drawing.Point(1427, 16);
            this.tb_BC_Interval.Name = "tb_BC_Interval";
            this.tb_BC_Interval.Size = new System.Drawing.Size(90, 20);
            this.tb_BC_Interval.TabIndex = 3;
            this.tb_BC_Interval.Text = "60";
            // 
            // b_BC_Set
            // 
            this.b_BC_Set.BackColor = System.Drawing.Color.WhiteSmoke;
            this.b_BC_Set.Location = new System.Drawing.Point(159, 13);
            this.b_BC_Set.Name = "b_BC_Set";
            this.b_BC_Set.Size = new System.Drawing.Size(108, 23);
            this.b_BC_Set.TabIndex = 2;
            this.b_BC_Set.Text = "Count and Set";
            this.b_BC_Set.UseVisualStyleBackColor = false;
            this.b_BC_Set.Click += new System.EventHandler(this.BC_Set_Click);
            // 
            // b_BC_Load
            // 
            this.b_BC_Load.BackColor = System.Drawing.Color.WhiteSmoke;
            this.b_BC_Load.Location = new System.Drawing.Point(9, 13);
            this.b_BC_Load.Name = "b_BC_Load";
            this.b_BC_Load.Size = new System.Drawing.Size(108, 23);
            this.b_BC_Load.TabIndex = 1;
            this.b_BC_Load.Text = "Count";
            this.b_BC_Load.UseVisualStyleBackColor = false;
            this.b_BC_Load.Click += new System.EventHandler(this.BC_Count_Click);
            // 
            // dgv_BC_settings
            // 
            this.dgv_BC_settings.AllowDrop = true;
            this.dgv_BC_settings.AllowUserToAddRows = false;
            this.dgv_BC_settings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_BC_settings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BC_settings.Location = new System.Drawing.Point(8, 42);
            this.dgv_BC_settings.Name = "dgv_BC_settings";
            this.dgv_BC_settings.RowHeadersWidth = 5;
            this.dgv_BC_settings.Size = new System.Drawing.Size(1509, 160);
            this.dgv_BC_settings.TabIndex = 0;
            // 
            // t_FinresHistory
            // 
            this.t_FinresHistory.BackColor = System.Drawing.Color.LightGray;
            this.t_FinresHistory.Controls.Add(this.dgv_AssetMove);
            this.t_FinresHistory.Controls.Add(this.pan_AssetMoves);
            this.t_FinresHistory.Controls.Add(this.pan_FinresHist);
            this.t_FinresHistory.Controls.Add(this.dgvFRH);
            this.t_FinresHistory.Location = new System.Drawing.Point(4, 31);
            this.t_FinresHistory.Margin = new System.Windows.Forms.Padding(2);
            this.t_FinresHistory.Name = "t_FinresHistory";
            this.t_FinresHistory.Padding = new System.Windows.Forms.Padding(2);
            this.t_FinresHistory.Size = new System.Drawing.Size(1526, 492);
            this.t_FinresHistory.TabIndex = 3;
            this.t_FinresHistory.Text = "Finres History and Moves";
            // 
            // dgv_AssetMove
            // 
            this.dgv_AssetMove.AllowUserToAddRows = false;
            this.dgv_AssetMove.AllowUserToDeleteRows = false;
            this.dgv_AssetMove.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_AssetMove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AssetMove.Location = new System.Drawing.Point(1002, 112);
            this.dgv_AssetMove.Name = "dgv_AssetMove";
            this.dgv_AssetMove.ReadOnly = true;
            this.dgv_AssetMove.RowHeadersWidth = 5;
            this.dgv_AssetMove.Size = new System.Drawing.Size(515, 375);
            this.dgv_AssetMove.TabIndex = 0;
            this.dgv_AssetMove.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ce_am);
            this.dgv_AssetMove.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kd_am_delete);
            // 
            // pan_AssetMoves
            // 
            this.pan_AssetMoves.BackColor = System.Drawing.Color.Silver;
            this.pan_AssetMoves.Controls.Add(this.cb_CommentsVar);
            this.pan_AssetMoves.Controls.Add(this.b_Add);
            this.pan_AssetMoves.Controls.Add(this.dtp_MoveDate);
            this.pan_AssetMoves.Controls.Add(this.l_AssetMove);
            this.pan_AssetMoves.Controls.Add(this.l_Date);
            this.pan_AssetMoves.Controls.Add(this.l_Comment);
            this.pan_AssetMoves.Controls.Add(this.l_Value);
            this.pan_AssetMoves.Controls.Add(this.tb_Value);
            this.pan_AssetMoves.Location = new System.Drawing.Point(1002, 6);
            this.pan_AssetMoves.Name = "pan_AssetMoves";
            this.pan_AssetMoves.Size = new System.Drawing.Size(515, 100);
            this.pan_AssetMoves.TabIndex = 9;
            // 
            // cb_CommentsVar
            // 
            this.cb_CommentsVar.FormattingEnabled = true;
            this.cb_CommentsVar.Items.AddRange(new object[] {
            "Комиссия FORTS",
            "Комиссия ММВБ",
            "Дивиденды "});
            this.cb_CommentsVar.Location = new System.Drawing.Point(82, 60);
            this.cb_CommentsVar.Name = "cb_CommentsVar";
            this.cb_CommentsVar.Size = new System.Drawing.Size(320, 21);
            this.cb_CommentsVar.TabIndex = 9;
            // 
            // b_Add
            // 
            this.b_Add.BackColor = System.Drawing.Color.LightGray;
            this.b_Add.Location = new System.Drawing.Point(424, 63);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(75, 27);
            this.b_Add.TabIndex = 8;
            this.b_Add.Text = "Add";
            this.b_Add.UseVisualStyleBackColor = false;
            this.b_Add.Click += new System.EventHandler(this.b_AddClick);
            // 
            // dtp_MoveDate
            // 
            this.dtp_MoveDate.Location = new System.Drawing.Point(82, 32);
            this.dtp_MoveDate.Name = "dtp_MoveDate";
            this.dtp_MoveDate.Size = new System.Drawing.Size(149, 20);
            this.dtp_MoveDate.TabIndex = 2;
            // 
            // l_AssetMove
            // 
            this.l_AssetMove.AutoSize = true;
            this.l_AssetMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_AssetMove.Location = new System.Drawing.Point(8, 7);
            this.l_AssetMove.Name = "l_AssetMove";
            this.l_AssetMove.Size = new System.Drawing.Size(120, 16);
            this.l_AssetMove.TabIndex = 1;
            this.l_AssetMove.Text = "Add asset move";
            // 
            // l_Date
            // 
            this.l_Date.AutoSize = true;
            this.l_Date.Location = new System.Drawing.Point(10, 32);
            this.l_Date.Name = "l_Date";
            this.l_Date.Size = new System.Drawing.Size(30, 13);
            this.l_Date.TabIndex = 3;
            this.l_Date.Text = "Date";
            // 
            // l_Comment
            // 
            this.l_Comment.AutoSize = true;
            this.l_Comment.Location = new System.Drawing.Point(10, 63);
            this.l_Comment.Name = "l_Comment";
            this.l_Comment.Size = new System.Drawing.Size(51, 13);
            this.l_Comment.TabIndex = 6;
            this.l_Comment.Text = "Comment";
            // 
            // l_Value
            // 
            this.l_Value.AutoSize = true;
            this.l_Value.Location = new System.Drawing.Point(290, 39);
            this.l_Value.Name = "l_Value";
            this.l_Value.Size = new System.Drawing.Size(34, 13);
            this.l_Value.TabIndex = 4;
            this.l_Value.Text = "Value";
            // 
            // tb_Value
            // 
            this.tb_Value.Location = new System.Drawing.Point(330, 34);
            this.tb_Value.Name = "tb_Value";
            this.tb_Value.Size = new System.Drawing.Size(169, 20);
            this.tb_Value.TabIndex = 5;
            // 
            // pan_FinresHist
            // 
            this.pan_FinresHist.BackColor = System.Drawing.Color.Silver;
            this.pan_FinresHist.Controls.Add(this.lFRH_TP);
            this.pan_FinresHist.Controls.Add(this.bFRH_Show);
            this.pan_FinresHist.Controls.Add(this.cbFRH_TP);
            this.pan_FinresHist.Location = new System.Drawing.Point(9, 6);
            this.pan_FinresHist.Name = "pan_FinresHist";
            this.pan_FinresHist.Size = new System.Drawing.Size(920, 29);
            this.pan_FinresHist.TabIndex = 9;
            // 
            // lFRH_TP
            // 
            this.lFRH_TP.AutoSize = true;
            this.lFRH_TP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFRH_TP.Location = new System.Drawing.Point(6, 5);
            this.lFRH_TP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFRH_TP.Name = "lFRH_TP";
            this.lFRH_TP.Size = new System.Drawing.Size(70, 17);
            this.lFRH_TP.TabIndex = 6;
            this.lFRH_TP.Text = "Tradepair";
            // 
            // bFRH_Show
            // 
            this.bFRH_Show.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bFRH_Show.Location = new System.Drawing.Point(346, 3);
            this.bFRH_Show.Margin = new System.Windows.Forms.Padding(2);
            this.bFRH_Show.Name = "bFRH_Show";
            this.bFRH_Show.Size = new System.Drawing.Size(189, 24);
            this.bFRH_Show.TabIndex = 8;
            this.bFRH_Show.Text = "Show History";
            this.bFRH_Show.UseVisualStyleBackColor = false;
            this.bFRH_Show.Click += new System.EventHandler(this.Show_FRH);
            // 
            // cbFRH_TP
            // 
            this.cbFRH_TP.FormattingEnabled = true;
            this.cbFRH_TP.Location = new System.Drawing.Point(78, 4);
            this.cbFRH_TP.Margin = new System.Windows.Forms.Padding(2);
            this.cbFRH_TP.Name = "cbFRH_TP";
            this.cbFRH_TP.Size = new System.Drawing.Size(264, 21);
            this.cbFRH_TP.TabIndex = 5;
            // 
            // dgvFRH
            // 
            this.dgvFRH.AllowUserToAddRows = false;
            this.dgvFRH.AllowUserToDeleteRows = false;
            this.dgvFRH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFRH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFRH.Location = new System.Drawing.Point(9, 39);
            this.dgvFRH.Margin = new System.Windows.Forms.Padding(1);
            this.dgvFRH.Name = "dgvFRH";
            this.dgvFRH.RowHeadersWidth = 5;
            this.dgvFRH.RowTemplate.Height = 24;
            this.dgvFRH.Size = new System.Drawing.Size(920, 450);
            this.dgvFRH.TabIndex = 7;
            // 
            // t_Finres
            // 
            this.t_Finres.BackColor = System.Drawing.Color.Gainsboro;
            this.t_Finres.Controls.Add(this.bFR_AddSave);
            this.t_Finres.Controls.Add(this.lFR_AddFull);
            this.t_Finres.Controls.Add(this.lFR_WithAdd);
            this.t_Finres.Controls.Add(this.lFR_Addition);
            this.t_Finres.Controls.Add(this.tbFR_Addition);
            this.t_Finres.Controls.Add(this.lFR_Result);
            this.t_Finres.Controls.Add(this.lFR_FullResult);
            this.t_Finres.Controls.Add(this.dgvFR_Reval);
            this.t_Finres.Controls.Add(this.lFR_TP);
            this.t_Finres.Controls.Add(this.cbFR_TP);
            this.t_Finres.Controls.Add(this.bFR_Count);
            this.t_Finres.Controls.Add(this.lFR_Date);
            this.t_Finres.Controls.Add(this.dtpFR_date);
            this.t_Finres.Location = new System.Drawing.Point(4, 31);
            this.t_Finres.Margin = new System.Windows.Forms.Padding(2);
            this.t_Finres.Name = "t_Finres";
            this.t_Finres.Padding = new System.Windows.Forms.Padding(2);
            this.t_Finres.Size = new System.Drawing.Size(1526, 492);
            this.t_Finres.TabIndex = 1;
            this.t_Finres.Text = "Finres";
            // 
            // bFR_AddSave
            // 
            this.bFR_AddSave.BackColor = System.Drawing.Color.White;
            this.bFR_AddSave.Location = new System.Drawing.Point(10, 278);
            this.bFR_AddSave.Name = "bFR_AddSave";
            this.bFR_AddSave.Size = new System.Drawing.Size(183, 28);
            this.bFR_AddSave.TabIndex = 12;
            this.bFR_AddSave.Text = "Save Addition";
            this.bFR_AddSave.UseVisualStyleBackColor = false;
            this.bFR_AddSave.Click += new System.EventHandler(this.bFR_SaveAdd_Click);
            // 
            // lFR_AddFull
            // 
            this.lFR_AddFull.AutoSize = true;
            this.lFR_AddFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFR_AddFull.ForeColor = System.Drawing.Color.Navy;
            this.lFR_AddFull.Location = new System.Drawing.Point(113, 253);
            this.lFR_AddFull.Name = "lFR_AddFull";
            this.lFR_AddFull.Size = new System.Drawing.Size(17, 18);
            this.lFR_AddFull.TabIndex = 11;
            this.lFR_AddFull.Text = "0";
            // 
            // lFR_WithAdd
            // 
            this.lFR_WithAdd.AutoSize = true;
            this.lFR_WithAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFR_WithAdd.Location = new System.Drawing.Point(8, 253);
            this.lFR_WithAdd.Name = "lFR_WithAdd";
            this.lFR_WithAdd.Size = new System.Drawing.Size(107, 18);
            this.lFR_WithAdd.TabIndex = 10;
            this.lFR_WithAdd.Text = "Full With Add =";
            // 
            // lFR_Addition
            // 
            this.lFR_Addition.AutoSize = true;
            this.lFR_Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFR_Addition.ForeColor = System.Drawing.Color.Indigo;
            this.lFR_Addition.Location = new System.Drawing.Point(6, 203);
            this.lFR_Addition.Name = "lFR_Addition";
            this.lFR_Addition.Size = new System.Drawing.Size(75, 20);
            this.lFR_Addition.TabIndex = 9;
            this.lFR_Addition.Text = "Addition";
            // 
            // tbFR_Addition
            // 
            this.tbFR_Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFR_Addition.Location = new System.Drawing.Point(8, 226);
            this.tbFR_Addition.Name = "tbFR_Addition";
            this.tbFR_Addition.Size = new System.Drawing.Size(185, 22);
            this.tbFR_Addition.TabIndex = 8;
            this.tbFR_Addition.Text = "0";
            // 
            // lFR_Result
            // 
            this.lFR_Result.AutoSize = true;
            this.lFR_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFR_Result.Location = new System.Drawing.Point(7, 126);
            this.lFR_Result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFR_Result.Name = "lFR_Result";
            this.lFR_Result.Size = new System.Drawing.Size(63, 18);
            this.lFR_Result.TabIndex = 7;
            this.lFR_Result.Text = "Result =";
            // 
            // lFR_FullResult
            // 
            this.lFR_FullResult.AutoSize = true;
            this.lFR_FullResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFR_FullResult.ForeColor = System.Drawing.Color.Navy;
            this.lFR_FullResult.Location = new System.Drawing.Point(67, 126);
            this.lFR_FullResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFR_FullResult.Name = "lFR_FullResult";
            this.lFR_FullResult.Size = new System.Drawing.Size(17, 18);
            this.lFR_FullResult.TabIndex = 6;
            this.lFR_FullResult.Text = "0";
            // 
            // dgvFR_Reval
            // 
            this.dgvFR_Reval.AllowUserToAddRows = false;
            this.dgvFR_Reval.AllowUserToDeleteRows = false;
            this.dgvFR_Reval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFR_Reval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFR_Reval.Location = new System.Drawing.Point(283, 11);
            this.dgvFR_Reval.Margin = new System.Windows.Forms.Padding(1);
            this.dgvFR_Reval.Name = "dgvFR_Reval";
            this.dgvFR_Reval.RowHeadersWidth = 5;
            this.dgvFR_Reval.RowTemplate.Height = 24;
            this.dgvFR_Reval.Size = new System.Drawing.Size(1235, 478);
            this.dgvFR_Reval.TabIndex = 5;
            // 
            // lFR_TP
            // 
            this.lFR_TP.AutoSize = true;
            this.lFR_TP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFR_TP.Location = new System.Drawing.Point(6, 21);
            this.lFR_TP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFR_TP.Name = "lFR_TP";
            this.lFR_TP.Size = new System.Drawing.Size(70, 17);
            this.lFR_TP.TabIndex = 4;
            this.lFR_TP.Text = "Tradepair";
            // 
            // cbFR_TP
            // 
            this.cbFR_TP.FormattingEnabled = true;
            this.cbFR_TP.Location = new System.Drawing.Point(77, 18);
            this.cbFR_TP.Margin = new System.Windows.Forms.Padding(2);
            this.cbFR_TP.Name = "cbFR_TP";
            this.cbFR_TP.Size = new System.Drawing.Size(190, 21);
            this.cbFR_TP.TabIndex = 3;
            // 
            // bFR_Count
            // 
            this.bFR_Count.BackColor = System.Drawing.Color.White;
            this.bFR_Count.Location = new System.Drawing.Point(77, 85);
            this.bFR_Count.Margin = new System.Windows.Forms.Padding(2);
            this.bFR_Count.Name = "bFR_Count";
            this.bFR_Count.Size = new System.Drawing.Size(189, 26);
            this.bFR_Count.TabIndex = 2;
            this.bFR_Count.Text = "Count";
            this.bFR_Count.UseVisualStyleBackColor = false;
            this.bFR_Count.Click += new System.EventHandler(this.bFR_CountClick);
            // 
            // lFR_Date
            // 
            this.lFR_Date.AutoSize = true;
            this.lFR_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFR_Date.Location = new System.Drawing.Point(7, 54);
            this.lFR_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFR_Date.Name = "lFR_Date";
            this.lFR_Date.Size = new System.Drawing.Size(38, 17);
            this.lFR_Date.TabIndex = 1;
            this.lFR_Date.Text = "Date";
            // 
            // dtpFR_date
            // 
            this.dtpFR_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFR_date.Location = new System.Drawing.Point(77, 51);
            this.dtpFR_date.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFR_date.Name = "dtpFR_date";
            this.dtpFR_date.Size = new System.Drawing.Size(190, 21);
            this.dtpFR_date.TabIndex = 0;
            // 
            // t_CurrPos
            // 
            this.t_CurrPos.BackColor = System.Drawing.Color.Gainsboro;
            this.t_CurrPos.Controls.Add(this.p_Commands);
            this.t_CurrPos.Controls.Add(this.l_OrdersDelays);
            this.t_CurrPos.Controls.Add(this.dgvDelays);
            this.t_CurrPos.Controls.Add(this.b_FullBall);
            this.t_CurrPos.Controls.Add(this.dgvFullBalance);
            this.t_CurrPos.Controls.Add(this.l_TP_Balance);
            this.t_CurrPos.Controls.Add(this.dgvTPBalances);
            this.t_CurrPos.Controls.Add(this.b_CurrPos);
            this.t_CurrPos.Location = new System.Drawing.Point(4, 31);
            this.t_CurrPos.Margin = new System.Windows.Forms.Padding(2);
            this.t_CurrPos.Name = "t_CurrPos";
            this.t_CurrPos.Padding = new System.Windows.Forms.Padding(2);
            this.t_CurrPos.Size = new System.Drawing.Size(1526, 492);
            this.t_CurrPos.TabIndex = 0;
            this.t_CurrPos.Text = "Current Positions";
            // 
            // l_OrdersDelays
            // 
            this.l_OrdersDelays.AutoSize = true;
            this.l_OrdersDelays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_OrdersDelays.Location = new System.Drawing.Point(5, 344);
            this.l_OrdersDelays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_OrdersDelays.Name = "l_OrdersDelays";
            this.l_OrdersDelays.Size = new System.Drawing.Size(99, 17);
            this.l_OrdersDelays.TabIndex = 7;
            this.l_OrdersDelays.Text = "Orders Delays";
            // 
            // dgvDelays
            // 
            this.dgvDelays.AllowUserToAddRows = false;
            this.dgvDelays.AllowUserToDeleteRows = false;
            this.dgvDelays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelays.Location = new System.Drawing.Point(6, 366);
            this.dgvDelays.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDelays.Name = "dgvDelays";
            this.dgvDelays.RowHeadersWidth = 5;
            this.dgvDelays.RowTemplate.Height = 24;
            this.dgvDelays.Size = new System.Drawing.Size(470, 122);
            this.dgvDelays.TabIndex = 6;
            // 
            // b_FullBall
            // 
            this.b_FullBall.BackColor = System.Drawing.Color.White;
            this.b_FullBall.Location = new System.Drawing.Point(1105, 6);
            this.b_FullBall.Margin = new System.Windows.Forms.Padding(2);
            this.b_FullBall.Name = "b_FullBall";
            this.b_FullBall.Size = new System.Drawing.Size(112, 28);
            this.b_FullBall.TabIndex = 5;
            this.b_FullBall.Text = "Full Balance";
            this.b_FullBall.UseVisualStyleBackColor = false;
            this.b_FullBall.Click += new System.EventHandler(this.ClickFullBalance);
            // 
            // dgvFullBalance
            // 
            this.dgvFullBalance.AllowUserToAddRows = false;
            this.dgvFullBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFullBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFullBalance.Location = new System.Drawing.Point(495, 38);
            this.dgvFullBalance.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFullBalance.Name = "dgvFullBalance";
            this.dgvFullBalance.RowHeadersWidth = 4;
            this.dgvFullBalance.RowTemplate.Height = 24;
            this.dgvFullBalance.Size = new System.Drawing.Size(722, 447);
            this.dgvFullBalance.TabIndex = 4;
            // 
            // l_TP_Balance
            // 
            this.l_TP_Balance.AutoSize = true;
            this.l_TP_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_TP_Balance.Location = new System.Drawing.Point(492, 15);
            this.l_TP_Balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_TP_Balance.Name = "l_TP_Balance";
            this.l_TP_Balance.Size = new System.Drawing.Size(94, 16);
            this.l_TP_Balance.TabIndex = 3;
            this.l_TP_Balance.Text = "Full Balance";
            // 
            // dgvTPBalances
            // 
            this.dgvTPBalances.AllowUserToAddRows = false;
            this.dgvTPBalances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTPBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTPBalances.Location = new System.Drawing.Point(6, 38);
            this.dgvTPBalances.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTPBalances.Name = "dgvTPBalances";
            this.dgvTPBalances.RowHeadersWidth = 4;
            this.dgvTPBalances.RowTemplate.Height = 24;
            this.dgvTPBalances.Size = new System.Drawing.Size(470, 302);
            this.dgvTPBalances.TabIndex = 2;
            this.dgvTPBalances.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_TP_Balance);
            // 
            // b_CurrPos
            // 
            this.b_CurrPos.BackColor = System.Drawing.Color.White;
            this.b_CurrPos.Location = new System.Drawing.Point(6, 5);
            this.b_CurrPos.Margin = new System.Windows.Forms.Padding(2);
            this.b_CurrPos.Name = "b_CurrPos";
            this.b_CurrPos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_CurrPos.Size = new System.Drawing.Size(112, 28);
            this.b_CurrPos.TabIndex = 1;
            this.b_CurrPos.Text = "Current Position";
            this.b_CurrPos.UseVisualStyleBackColor = false;
            this.b_CurrPos.Click += new System.EventHandler(this.b_CurrPos_Click);
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.t_CurrPos);
            this.tabControl_Main.Controls.Add(this.t_BasisCount);
            this.tabControl_Main.Controls.Add(this.t_Finres);
            this.tabControl_Main.Controls.Add(this.t_FinresHistory);
            this.tabControl_Main.Controls.Add(this.t_TPStruct);
            this.tabControl_Main.Controls.Add(this.t_Expiration);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Enabled = false;
            this.tabControl_Main.ItemSize = new System.Drawing.Size(150, 27);
            this.tabControl_Main.Location = new System.Drawing.Point(0, 262);
            this.tabControl_Main.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1534, 527);
            this.tabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Main.TabIndex = 7;
            // 
            // t_TPStruct
            // 
            this.t_TPStruct.BackColor = System.Drawing.Color.Gainsboro;
            this.t_TPStruct.Controls.Add(this.panel1);
            this.t_TPStruct.Controls.Add(this.dgv_tps_hedgekf);
            this.t_TPStruct.Controls.Add(this.p_tps_sec);
            this.t_TPStruct.Controls.Add(this.dgv_tps_tpsec);
            this.t_TPStruct.Controls.Add(this.p_tps_tp);
            this.t_TPStruct.Controls.Add(this.dgv_tps_list);
            this.t_TPStruct.Location = new System.Drawing.Point(4, 31);
            this.t_TPStruct.Name = "t_TPStruct";
            this.t_TPStruct.Size = new System.Drawing.Size(1526, 492);
            this.t_TPStruct.TabIndex = 6;
            this.t_TPStruct.Text = "Tradepairs Structure";
            this.t_TPStruct.Enter += new System.EventHandler(this.TPStructEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.b_tps_restore);
            this.panel1.Controls.Add(this.b_tps_import);
            this.panel1.Controls.Add(this.l_tps_upload);
            this.panel1.Controls.Add(this.cb_tps_acc1);
            this.panel1.Controls.Add(this.l_tps_acc1);
            this.panel1.Controls.Add(this.l_tps_tpid1);
            this.panel1.Controls.Add(this.l_tps_tmp2);
            this.panel1.Location = new System.Drawing.Point(1013, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 118);
            this.panel1.TabIndex = 17;
            // 
            // b_tps_import
            // 
            this.b_tps_import.BackColor = System.Drawing.Color.Silver;
            this.b_tps_import.Location = new System.Drawing.Point(12, 82);
            this.b_tps_import.Name = "b_tps_import";
            this.b_tps_import.Size = new System.Drawing.Size(122, 26);
            this.b_tps_import.TabIndex = 17;
            this.b_tps_import.Text = "<< Import";
            this.b_tps_import.UseVisualStyleBackColor = false;
            this.b_tps_import.Click += new System.EventHandler(this.tps_import_click);
            // 
            // l_tps_upload
            // 
            this.l_tps_upload.AutoSize = true;
            this.l_tps_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_tps_upload.ForeColor = System.Drawing.Color.Maroon;
            this.l_tps_upload.Location = new System.Drawing.Point(12, 8);
            this.l_tps_upload.Name = "l_tps_upload";
            this.l_tps_upload.Size = new System.Drawing.Size(168, 16);
            this.l_tps_upload.TabIndex = 19;
            this.l_tps_upload.Text = "Upload hedge portfolio";
            // 
            // cb_tps_acc1
            // 
            this.cb_tps_acc1.FormattingEnabled = true;
            this.cb_tps_acc1.Location = new System.Drawing.Point(157, 55);
            this.cb_tps_acc1.Name = "cb_tps_acc1";
            this.cb_tps_acc1.Size = new System.Drawing.Size(121, 21);
            this.cb_tps_acc1.TabIndex = 18;
            // 
            // l_tps_acc1
            // 
            this.l_tps_acc1.AutoSize = true;
            this.l_tps_acc1.Location = new System.Drawing.Point(9, 59);
            this.l_tps_acc1.Name = "l_tps_acc1";
            this.l_tps_acc1.Size = new System.Drawing.Size(142, 13);
            this.l_tps_acc1.TabIndex = 17;
            this.l_tps_acc1.Text = "Account for hedge securities";
            // 
            // l_tps_tpid1
            // 
            this.l_tps_tpid1.AutoSize = true;
            this.l_tps_tpid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_tps_tpid1.Location = new System.Drawing.Point(95, 37);
            this.l_tps_tpid1.Name = "l_tps_tpid1";
            this.l_tps_tpid1.Size = new System.Drawing.Size(14, 13);
            this.l_tps_tpid1.TabIndex = 18;
            this.l_tps_tpid1.Text = "0";
            // 
            // l_tps_tmp2
            // 
            this.l_tps_tmp2.AutoSize = true;
            this.l_tps_tmp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_tps_tmp2.Location = new System.Drawing.Point(9, 38);
            this.l_tps_tmp2.Name = "l_tps_tmp2";
            this.l_tps_tmp2.Size = new System.Drawing.Size(76, 13);
            this.l_tps_tmp2.TabIndex = 17;
            this.l_tps_tmp2.Text = "Tradepair Id";
            // 
            // dgv_tps_hedgekf
            // 
            this.dgv_tps_hedgekf.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_tps_hedgekf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tps_hedgekf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_code,
            this.Column_hedgekf});
            this.dgv_tps_hedgekf.Location = new System.Drawing.Point(1013, 8);
            this.dgv_tps_hedgekf.Name = "dgv_tps_hedgekf";
            this.dgv_tps_hedgekf.RowHeadersWidth = 20;
            this.dgv_tps_hedgekf.Size = new System.Drawing.Size(298, 359);
            this.dgv_tps_hedgekf.TabIndex = 16;
            this.dgv_tps_hedgekf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tps_buffer_insert);
            // 
            // Column_code
            // 
            this.Column_code.HeaderText = "Code";
            this.Column_code.Name = "Column_code";
            // 
            // Column_hedgekf
            // 
            this.Column_hedgekf.HeaderText = "HedgeKf";
            this.Column_hedgekf.Name = "Column_hedgekf";
            // 
            // p_tps_sec
            // 
            this.p_tps_sec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p_tps_sec.Controls.Add(this.b_tps_delete);
            this.p_tps_sec.Controls.Add(this.b_tps_addupdate);
            this.p_tps_sec.Controls.Add(this.tb_tps_p2pkf);
            this.p_tps_sec.Controls.Add(this.l_tps_p2pkf);
            this.p_tps_sec.Controls.Add(this.tb_tps_pdkf);
            this.p_tps_sec.Controls.Add(this.l_tps_pfkf);
            this.p_tps_sec.Controls.Add(this.tb_tps_hedgekf);
            this.p_tps_sec.Controls.Add(this.l_tps_hedgekf);
            this.p_tps_sec.Controls.Add(this.cb_tps_acc);
            this.p_tps_sec.Controls.Add(this.l_tps_acc);
            this.p_tps_sec.Controls.Add(this.cb_tps_pdfor);
            this.p_tps_sec.Controls.Add(this.l_tps_pdto);
            this.p_tps_sec.Controls.Add(this.cb_tps_sectype);
            this.p_tps_sec.Controls.Add(this.l_tps_sectype);
            this.p_tps_sec.Controls.Add(this.cb_tps_code);
            this.p_tps_sec.Controls.Add(this.l_tps_code);
            this.p_tps_sec.Controls.Add(this.l_tps_tpid);
            this.p_tps_sec.Controls.Add(this.l_tps_tmp1);
            this.p_tps_sec.Location = new System.Drawing.Point(386, 373);
            this.p_tps_sec.Name = "p_tps_sec";
            this.p_tps_sec.Size = new System.Drawing.Size(609, 116);
            this.p_tps_sec.TabIndex = 15;
            // 
            // b_tps_delete
            // 
            this.b_tps_delete.BackColor = System.Drawing.Color.Silver;
            this.b_tps_delete.Location = new System.Drawing.Point(461, 82);
            this.b_tps_delete.Name = "b_tps_delete";
            this.b_tps_delete.Size = new System.Drawing.Size(122, 26);
            this.b_tps_delete.TabIndex = 16;
            this.b_tps_delete.Text = "Delete";
            this.b_tps_delete.UseVisualStyleBackColor = false;
            this.b_tps_delete.Click += new System.EventHandler(this.b_tps_delete_click);
            // 
            // b_tps_addupdate
            // 
            this.b_tps_addupdate.BackColor = System.Drawing.Color.Silver;
            this.b_tps_addupdate.Location = new System.Drawing.Point(6, 82);
            this.b_tps_addupdate.Name = "b_tps_addupdate";
            this.b_tps_addupdate.Size = new System.Drawing.Size(138, 26);
            this.b_tps_addupdate.TabIndex = 12;
            this.b_tps_addupdate.Text = "Add or Update";
            this.b_tps_addupdate.UseVisualStyleBackColor = false;
            this.b_tps_addupdate.Click += new System.EventHandler(this.b_tps_addupdate_click);
            // 
            // tb_tps_p2pkf
            // 
            this.tb_tps_p2pkf.Location = new System.Drawing.Point(346, 56);
            this.tb_tps_p2pkf.Name = "tb_tps_p2pkf";
            this.tb_tps_p2pkf.Size = new System.Drawing.Size(83, 20);
            this.tb_tps_p2pkf.TabIndex = 15;
            // 
            // l_tps_p2pkf
            // 
            this.l_tps_p2pkf.AutoSize = true;
            this.l_tps_p2pkf.Location = new System.Drawing.Point(304, 60);
            this.l_tps_p2pkf.Name = "l_tps_p2pkf";
            this.l_tps_p2pkf.Size = new System.Drawing.Size(40, 13);
            this.l_tps_p2pkf.TabIndex = 14;
            this.l_tps_p2pkf.Text = "P2P Kf";
            // 
            // tb_tps_pdkf
            // 
            this.tb_tps_pdkf.Location = new System.Drawing.Point(194, 56);
            this.tb_tps_pdkf.Name = "tb_tps_pdkf";
            this.tb_tps_pdkf.Size = new System.Drawing.Size(83, 20);
            this.tb_tps_pdkf.TabIndex = 13;
            // 
            // l_tps_pfkf
            // 
            this.l_tps_pfkf.AutoSize = true;
            this.l_tps_pfkf.Location = new System.Drawing.Point(157, 59);
            this.l_tps_pfkf.Name = "l_tps_pfkf";
            this.l_tps_pfkf.Size = new System.Drawing.Size(35, 13);
            this.l_tps_pfkf.TabIndex = 12;
            this.l_tps_pfkf.Text = "PD Kf";
            // 
            // tb_tps_hedgekf
            // 
            this.tb_tps_hedgekf.Location = new System.Drawing.Point(61, 56);
            this.tb_tps_hedgekf.Name = "tb_tps_hedgekf";
            this.tb_tps_hedgekf.Size = new System.Drawing.Size(83, 20);
            this.tb_tps_hedgekf.TabIndex = 11;
            // 
            // l_tps_hedgekf
            // 
            this.l_tps_hedgekf.AutoSize = true;
            this.l_tps_hedgekf.Location = new System.Drawing.Point(3, 59);
            this.l_tps_hedgekf.Name = "l_tps_hedgekf";
            this.l_tps_hedgekf.Size = new System.Drawing.Size(52, 13);
            this.l_tps_hedgekf.TabIndex = 10;
            this.l_tps_hedgekf.Text = "Hedge Kf";
            // 
            // cb_tps_acc
            // 
            this.cb_tps_acc.FormattingEnabled = true;
            this.cb_tps_acc.Location = new System.Drawing.Point(193, 29);
            this.cb_tps_acc.Name = "cb_tps_acc";
            this.cb_tps_acc.Size = new System.Drawing.Size(124, 21);
            this.cb_tps_acc.TabIndex = 9;
            // 
            // l_tps_acc
            // 
            this.l_tps_acc.AutoSize = true;
            this.l_tps_acc.Location = new System.Drawing.Point(146, 33);
            this.l_tps_acc.Name = "l_tps_acc";
            this.l_tps_acc.Size = new System.Drawing.Size(47, 13);
            this.l_tps_acc.TabIndex = 8;
            this.l_tps_acc.Text = "Account";
            // 
            // cb_tps_pdfor
            // 
            this.cb_tps_pdfor.FormattingEnabled = true;
            this.cb_tps_pdfor.Location = new System.Drawing.Point(477, 29);
            this.cb_tps_pdfor.Name = "cb_tps_pdfor";
            this.cb_tps_pdfor.Size = new System.Drawing.Size(122, 21);
            this.cb_tps_pdfor.TabIndex = 7;
            // 
            // l_tps_pdto
            // 
            this.l_tps_pdto.AutoSize = true;
            this.l_tps_pdto.Location = new System.Drawing.Point(434, 33);
            this.l_tps_pdto.Name = "l_tps_pdto";
            this.l_tps_pdto.Size = new System.Drawing.Size(37, 13);
            this.l_tps_pdto.TabIndex = 6;
            this.l_tps_pdto.Text = "PD for";
            // 
            // cb_tps_sectype
            // 
            this.cb_tps_sectype.FormattingEnabled = true;
            this.cb_tps_sectype.Location = new System.Drawing.Point(356, 30);
            this.cb_tps_sectype.Name = "cb_tps_sectype";
            this.cb_tps_sectype.Size = new System.Drawing.Size(74, 21);
            this.cb_tps_sectype.TabIndex = 5;
            this.cb_tps_sectype.SelectedValueChanged += new System.EventHandler(this.tps_activate_pd);
            // 
            // l_tps_sectype
            // 
            this.l_tps_sectype.AutoSize = true;
            this.l_tps_sectype.Location = new System.Drawing.Point(323, 32);
            this.l_tps_sectype.Name = "l_tps_sectype";
            this.l_tps_sectype.Size = new System.Drawing.Size(31, 13);
            this.l_tps_sectype.TabIndex = 4;
            this.l_tps_sectype.Text = "Type";
            // 
            // cb_tps_code
            // 
            this.cb_tps_code.FormattingEnabled = true;
            this.cb_tps_code.Location = new System.Drawing.Point(37, 29);
            this.cb_tps_code.Name = "cb_tps_code";
            this.cb_tps_code.Size = new System.Drawing.Size(107, 21);
            this.cb_tps_code.TabIndex = 3;
            // 
            // l_tps_code
            // 
            this.l_tps_code.AutoSize = true;
            this.l_tps_code.Location = new System.Drawing.Point(3, 33);
            this.l_tps_code.Name = "l_tps_code";
            this.l_tps_code.Size = new System.Drawing.Size(32, 13);
            this.l_tps_code.TabIndex = 2;
            this.l_tps_code.Text = "Code";
            // 
            // l_tps_tpid
            // 
            this.l_tps_tpid.AutoSize = true;
            this.l_tps_tpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_tps_tpid.Location = new System.Drawing.Point(82, 8);
            this.l_tps_tpid.Name = "l_tps_tpid";
            this.l_tps_tpid.Size = new System.Drawing.Size(62, 13);
            this.l_tps_tpid.TabIndex = 1;
            this.l_tps_tpid.Text = "l_tps_tpid";
            // 
            // l_tps_tmp1
            // 
            this.l_tps_tmp1.AutoSize = true;
            this.l_tps_tmp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_tps_tmp1.Location = new System.Drawing.Point(6, 8);
            this.l_tps_tmp1.Name = "l_tps_tmp1";
            this.l_tps_tmp1.Size = new System.Drawing.Size(76, 13);
            this.l_tps_tmp1.TabIndex = 0;
            this.l_tps_tmp1.Text = "Tradepair Id";
            // 
            // dgv_tps_tpsec
            // 
            this.dgv_tps_tpsec.AllowUserToAddRows = false;
            this.dgv_tps_tpsec.AllowUserToDeleteRows = false;
            this.dgv_tps_tpsec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tps_tpsec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tps_tpsec.Location = new System.Drawing.Point(386, 8);
            this.dgv_tps_tpsec.Name = "dgv_tps_tpsec";
            this.dgv_tps_tpsec.RowHeadersWidth = 5;
            this.dgv_tps_tpsec.Size = new System.Drawing.Size(609, 359);
            this.dgv_tps_tpsec.TabIndex = 13;
            this.dgv_tps_tpsec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tps_tpsec_enter);
            // 
            // p_tps_tp
            // 
            this.p_tps_tp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p_tps_tp.Controls.Add(this.l_tps_addedit);
            this.p_tps_tp.Controls.Add(this.cb_tps_struct);
            this.p_tps_tp.Controls.Add(this.cb_tps_params);
            this.p_tps_tp.Controls.Add(this.tb_tps_id);
            this.p_tps_tp.Controls.Add(this.cb_tps_copyfrom);
            this.p_tps_tp.Controls.Add(this.l_tps_name);
            this.p_tps_tp.Controls.Add(this.l_tps_copy);
            this.p_tps_tp.Controls.Add(this.tb_tps_name);
            this.p_tps_tp.Controls.Add(this.b_tps_savetp);
            this.p_tps_tp.Controls.Add(this.cb_tps_active);
            this.p_tps_tp.Location = new System.Drawing.Point(5, 373);
            this.p_tps_tp.Name = "p_tps_tp";
            this.p_tps_tp.Size = new System.Drawing.Size(375, 116);
            this.p_tps_tp.TabIndex = 12;
            // 
            // l_tps_addedit
            // 
            this.l_tps_addedit.AutoSize = true;
            this.l_tps_addedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_tps_addedit.Location = new System.Drawing.Point(3, 5);
            this.l_tps_addedit.Name = "l_tps_addedit";
            this.l_tps_addedit.Size = new System.Drawing.Size(142, 16);
            this.l_tps_addedit.TabIndex = 1;
            this.l_tps_addedit.Text = "Add Tradepair Id = ";
            // 
            // cb_tps_struct
            // 
            this.cb_tps_struct.AutoSize = true;
            this.cb_tps_struct.Location = new System.Drawing.Point(300, 59);
            this.cb_tps_struct.Name = "cb_tps_struct";
            this.cb_tps_struct.Size = new System.Drawing.Size(69, 17);
            this.cb_tps_struct.TabIndex = 11;
            this.cb_tps_struct.TabStop = false;
            this.cb_tps_struct.Text = "Structure";
            this.cb_tps_struct.UseVisualStyleBackColor = true;
            // 
            // cb_tps_params
            // 
            this.cb_tps_params.AutoSize = true;
            this.cb_tps_params.Location = new System.Drawing.Point(240, 59);
            this.cb_tps_params.Name = "cb_tps_params";
            this.cb_tps_params.Size = new System.Drawing.Size(61, 17);
            this.cb_tps_params.TabIndex = 10;
            this.cb_tps_params.Text = "Params";
            this.cb_tps_params.UseVisualStyleBackColor = true;
            // 
            // tb_tps_id
            // 
            this.tb_tps_id.Location = new System.Drawing.Point(146, 4);
            this.tb_tps_id.Name = "tb_tps_id";
            this.tb_tps_id.Size = new System.Drawing.Size(111, 20);
            this.tb_tps_id.TabIndex = 3;
            // 
            // cb_tps_copyfrom
            // 
            this.cb_tps_copyfrom.FormattingEnabled = true;
            this.cb_tps_copyfrom.Location = new System.Drawing.Point(62, 56);
            this.cb_tps_copyfrom.Name = "cb_tps_copyfrom";
            this.cb_tps_copyfrom.Size = new System.Drawing.Size(172, 21);
            this.cb_tps_copyfrom.TabIndex = 9;
            // 
            // l_tps_name
            // 
            this.l_tps_name.AutoSize = true;
            this.l_tps_name.Location = new System.Drawing.Point(6, 32);
            this.l_tps_name.Name = "l_tps_name";
            this.l_tps_name.Size = new System.Drawing.Size(35, 13);
            this.l_tps_name.TabIndex = 4;
            this.l_tps_name.Text = "Name";
            // 
            // l_tps_copy
            // 
            this.l_tps_copy.AutoSize = true;
            this.l_tps_copy.Location = new System.Drawing.Point(6, 59);
            this.l_tps_copy.Name = "l_tps_copy";
            this.l_tps_copy.Size = new System.Drawing.Size(54, 13);
            this.l_tps_copy.TabIndex = 8;
            this.l_tps_copy.Text = "Copy from";
            // 
            // tb_tps_name
            // 
            this.tb_tps_name.Location = new System.Drawing.Point(42, 30);
            this.tb_tps_name.Name = "tb_tps_name";
            this.tb_tps_name.Size = new System.Drawing.Size(327, 20);
            this.tb_tps_name.TabIndex = 5;
            // 
            // b_tps_savetp
            // 
            this.b_tps_savetp.BackColor = System.Drawing.Color.Silver;
            this.b_tps_savetp.Location = new System.Drawing.Point(6, 83);
            this.b_tps_savetp.Name = "b_tps_savetp";
            this.b_tps_savetp.Size = new System.Drawing.Size(125, 26);
            this.b_tps_savetp.TabIndex = 7;
            this.b_tps_savetp.Text = "Add";
            this.b_tps_savetp.UseVisualStyleBackColor = false;
            this.b_tps_savetp.Click += new System.EventHandler(this.b_tps_savetp_Click);
            // 
            // cb_tps_active
            // 
            this.cb_tps_active.AutoSize = true;
            this.cb_tps_active.Location = new System.Drawing.Point(300, 7);
            this.cb_tps_active.Name = "cb_tps_active";
            this.cb_tps_active.Size = new System.Drawing.Size(64, 17);
            this.cb_tps_active.TabIndex = 6;
            this.cb_tps_active.Text = "IsActive";
            this.cb_tps_active.UseVisualStyleBackColor = true;
            // 
            // dgv_tps_list
            // 
            this.dgv_tps_list.AllowUserToAddRows = false;
            this.dgv_tps_list.AllowUserToDeleteRows = false;
            this.dgv_tps_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tps_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tps_list.Location = new System.Drawing.Point(5, 8);
            this.dgv_tps_list.Name = "dgv_tps_list";
            this.dgv_tps_list.RowHeadersWidth = 5;
            this.dgv_tps_list.Size = new System.Drawing.Size(375, 359);
            this.dgv_tps_list.TabIndex = 0;
            this.dgv_tps_list.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tps_tp_endedit);
            this.dgv_tps_list.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.tps_tp_enter);
            // 
            // b_tps_restore
            // 
            this.b_tps_restore.BackColor = System.Drawing.Color.Silver;
            this.b_tps_restore.Location = new System.Drawing.Point(157, 82);
            this.b_tps_restore.Name = "b_tps_restore";
            this.b_tps_restore.Size = new System.Drawing.Size(122, 26);
            this.b_tps_restore.TabIndex = 20;
            this.b_tps_restore.Text = "Restore >>";
            this.b_tps_restore.UseVisualStyleBackColor = false;
            this.b_tps_restore.Click += new System.EventHandler(this.tps_restore_click);
            // 
            // p_Commands
            // 
            this.p_Commands.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p_Commands.Controls.Add(this.b_mess_stophedge);
            this.p_Commands.Controls.Add(this.b_mess_starthedge);
            this.p_Commands.Controls.Add(this.b_mess_stop);
            this.p_Commands.Controls.Add(this.b_mess_start);
            this.p_Commands.Controls.Add(this.label1);
            this.p_Commands.Location = new System.Drawing.Point(1238, 6);
            this.p_Commands.Name = "p_Commands";
            this.p_Commands.Size = new System.Drawing.Size(280, 480);
            this.p_Commands.TabIndex = 8;
            this.p_Commands.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message to MTS3";
            // 
            // b_mess_start
            // 
            this.b_mess_start.Location = new System.Drawing.Point(10, 37);
            this.b_mess_start.Name = "b_mess_start";
            this.b_mess_start.Size = new System.Drawing.Size(125, 23);
            this.b_mess_start.TabIndex = 1;
            this.b_mess_start.Text = "start";
            this.b_mess_start.UseVisualStyleBackColor = true;
            this.b_mess_start.Click += new System.EventHandler(this.mess_send);
            // 
            // b_mess_stop
            // 
            this.b_mess_stop.Location = new System.Drawing.Point(145, 37);
            this.b_mess_stop.Name = "b_mess_stop";
            this.b_mess_stop.Size = new System.Drawing.Size(125, 23);
            this.b_mess_stop.TabIndex = 2;
            this.b_mess_stop.Text = "stop";
            this.b_mess_stop.UseVisualStyleBackColor = true;
            this.b_mess_stop.Click += new System.EventHandler(this.mess_send);
            // 
            // b_mess_stophedge
            // 
            this.b_mess_stophedge.Location = new System.Drawing.Point(145, 75);
            this.b_mess_stophedge.Name = "b_mess_stophedge";
            this.b_mess_stophedge.Size = new System.Drawing.Size(125, 23);
            this.b_mess_stophedge.TabIndex = 4;
            this.b_mess_stophedge.Text = "stophedge";
            this.b_mess_stophedge.UseVisualStyleBackColor = true;
            this.b_mess_stophedge.Click += new System.EventHandler(this.mess_send);
            // 
            // b_mess_starthedge
            // 
            this.b_mess_starthedge.Location = new System.Drawing.Point(10, 75);
            this.b_mess_starthedge.Name = "b_mess_starthedge";
            this.b_mess_starthedge.Size = new System.Drawing.Size(125, 23);
            this.b_mess_starthedge.TabIndex = 3;
            this.b_mess_starthedge.Text = "starthedge";
            this.b_mess_starthedge.UseVisualStyleBackColor = true;
            this.b_mess_starthedge.Click += new System.EventHandler(this.mess_send);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 861);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.pan_top);
            this.Controls.Add(this.tbLog);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "monitor3lx";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).EndInit();
            this.pan_top.ResumeLayout(false);
            this.pan_top.PerformLayout();
            this.pan_Connect.ResumeLayout(false);
            this.pan_Connect.PerformLayout();
            this.t_Expiration.ResumeLayout(false);
            this.pan_ExpRed.ResumeLayout(false);
            this.pan_ExpRed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exp_Robotsett)).EndInit();
            this.t_BasisCount.ResumeLayout(false);
            this.t_BasisCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LParams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BC_Params)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BC_settings)).EndInit();
            this.t_FinresHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AssetMove)).EndInit();
            this.pan_AssetMoves.ResumeLayout(false);
            this.pan_AssetMoves.PerformLayout();
            this.pan_FinresHist.ResumeLayout(false);
            this.pan_FinresHist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFRH)).EndInit();
            this.t_Finres.ResumeLayout(false);
            this.t_Finres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFR_Reval)).EndInit();
            this.t_CurrPos.ResumeLayout(false);
            this.t_CurrPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTPBalances)).EndInit();
            this.tabControl_Main.ResumeLayout(false);
            this.t_TPStruct.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tps_hedgekf)).EndInit();
            this.p_tps_sec.ResumeLayout(false);
            this.p_tps_sec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tps_tpsec)).EndInit();
            this.p_tps_tp.ResumeLayout(false);
            this.p_tps_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tps_list)).EndInit();
            this.p_Commands.ResumeLayout(false);
            this.p_Commands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button bConn;
        private System.Windows.Forms.DataGridView dgvTP;
        private System.Windows.Forms.Button bUpdateTP;
        private System.Windows.Forms.Button b_Apply;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.Timer timer_BC;
        private System.Windows.Forms.Label l_Kfs_with_TP;
        private System.Windows.Forms.Button b_Up_;
        private System.Windows.Forms.Button b_down_;
        private System.Windows.Forms.Button b_down_inv;
        private System.Windows.Forms.Button b_up_inv;
        private System.Windows.Forms.Timer timer_keepconn;
        private System.Windows.Forms.TextBox tb_kfp;
        private System.Windows.Forms.Label l_kfp;
        private System.Windows.Forms.Timer timer_exprobot;
        private System.Windows.Forms.Panel pan_Connect;
        private System.Windows.Forms.TabPage t_Expiration;
        private System.Windows.Forms.Panel pan_ExpRed;
        private System.Windows.Forms.CheckBox cb_AutoExp;
        private System.Windows.Forms.Button b_exp_itteration;
        private System.Windows.Forms.DataGridView dgv_Exp_Robotsett;
        private System.Windows.Forms.Button b_exp_state;
        private System.Windows.Forms.TabPage t_BasisCount;
        private System.Windows.Forms.Button b_loadParams;
        private System.Windows.Forms.DataGridView dgv_LParams;
        private System.Windows.Forms.DataGridView dgv_BC_Params;
        private System.Windows.Forms.Label l_BC_Params;
        private System.Windows.Forms.CheckBox cb_BC_Autoreload;
        private System.Windows.Forms.TextBox tb_BC_Interval;
        private System.Windows.Forms.Button b_BC_Set;
        private System.Windows.Forms.Button b_BC_Load;
        private System.Windows.Forms.DataGridView dgv_BC_settings;
        private System.Windows.Forms.TabPage t_FinresHistory;
        private System.Windows.Forms.DataGridView dgv_AssetMove;
        private System.Windows.Forms.Panel pan_AssetMoves;
        private System.Windows.Forms.ComboBox cb_CommentsVar;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.DateTimePicker dtp_MoveDate;
        private System.Windows.Forms.Label l_AssetMove;
        private System.Windows.Forms.Label l_Date;
        private System.Windows.Forms.Label l_Comment;
        private System.Windows.Forms.Label l_Value;
        private System.Windows.Forms.TextBox tb_Value;
        private System.Windows.Forms.Panel pan_FinresHist;
        private System.Windows.Forms.Label lFRH_TP;
        private System.Windows.Forms.Button bFRH_Show;
        private System.Windows.Forms.ComboBox cbFRH_TP;
        private System.Windows.Forms.DataGridView dgvFRH;
        private System.Windows.Forms.TabPage t_Finres;
        private System.Windows.Forms.Button bFR_AddSave;
        private System.Windows.Forms.Label lFR_AddFull;
        private System.Windows.Forms.Label lFR_WithAdd;
        private System.Windows.Forms.Label lFR_Addition;
        private System.Windows.Forms.TextBox tbFR_Addition;
        private System.Windows.Forms.Label lFR_Result;
        private System.Windows.Forms.Label lFR_FullResult;
        private System.Windows.Forms.DataGridView dgvFR_Reval;
        private System.Windows.Forms.Label lFR_TP;
        private System.Windows.Forms.ComboBox cbFR_TP;
        private System.Windows.Forms.Button bFR_Count;
        private System.Windows.Forms.Label lFR_Date;
        private System.Windows.Forms.DateTimePicker dtpFR_date;
        private System.Windows.Forms.TabPage t_CurrPos;
        private System.Windows.Forms.Label l_OrdersDelays;
        private System.Windows.Forms.DataGridView dgvDelays;
        private System.Windows.Forms.Button b_FullBall;
        private System.Windows.Forms.DataGridView dgvFullBalance;
        private System.Windows.Forms.Label l_TP_Balance;
        private System.Windows.Forms.DataGridView dgvTPBalances;
        private System.Windows.Forms.Button b_CurrPos;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage t_TPStruct;
        private System.Windows.Forms.DataGridView dgv_tps_list;
        private System.Windows.Forms.Button b_tps_savetp;
        private System.Windows.Forms.CheckBox cb_tps_active;
        private System.Windows.Forms.TextBox tb_tps_name;
        private System.Windows.Forms.Label l_tps_name;
        private System.Windows.Forms.TextBox tb_tps_id;
        private System.Windows.Forms.Label l_tps_addedit;
        private System.Windows.Forms.CheckBox cb_tps_struct;
        private System.Windows.Forms.CheckBox cb_tps_params;
        private System.Windows.Forms.ComboBox cb_tps_copyfrom;
        private System.Windows.Forms.Label l_tps_copy;
        private System.Windows.Forms.Panel p_tps_tp;
        private System.Windows.Forms.DataGridView dgv_tps_tpsec;
        private System.Windows.Forms.Panel p_tps_sec;
        private System.Windows.Forms.Label l_tps_tpid;
        private System.Windows.Forms.Label l_tps_tmp1;
        private System.Windows.Forms.ComboBox cb_tps_sectype;
        private System.Windows.Forms.Label l_tps_sectype;
        private System.Windows.Forms.ComboBox cb_tps_code;
        private System.Windows.Forms.Label l_tps_code;
        private System.Windows.Forms.ComboBox cb_tps_acc;
        private System.Windows.Forms.Label l_tps_acc;
        private System.Windows.Forms.ComboBox cb_tps_pdfor;
        private System.Windows.Forms.Label l_tps_pdto;
        private System.Windows.Forms.Button b_tps_addupdate;
        private System.Windows.Forms.TextBox tb_tps_p2pkf;
        private System.Windows.Forms.Label l_tps_p2pkf;
        private System.Windows.Forms.TextBox tb_tps_pdkf;
        private System.Windows.Forms.Label l_tps_pfkf;
        private System.Windows.Forms.TextBox tb_tps_hedgekf;
        private System.Windows.Forms.Label l_tps_hedgekf;
        private System.Windows.Forms.Button b_tps_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_tps_upload;
        private System.Windows.Forms.ComboBox cb_tps_acc1;
        private System.Windows.Forms.Label l_tps_acc1;
        private System.Windows.Forms.Label l_tps_tpid1;
        private System.Windows.Forms.Label l_tps_tmp2;
        private System.Windows.Forms.DataGridView dgv_tps_hedgekf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hedgekf;
        private System.Windows.Forms.Button b_tps_import;
        private System.Windows.Forms.Button b_tps_restore;
        private System.Windows.Forms.Panel p_Commands;
        private System.Windows.Forms.Button b_mess_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_mess_stophedge;
        private System.Windows.Forms.Button b_mess_starthedge;
        private System.Windows.Forms.Button b_mess_stop;
    }
}

