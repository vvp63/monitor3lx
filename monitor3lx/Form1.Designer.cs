﻿namespace monitor3lx
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.t_CurrPos = new System.Windows.Forms.TabPage();
            this.l_OrdersDelays = new System.Windows.Forms.Label();
            this.dgvDelays = new System.Windows.Forms.DataGridView();
            this.b_FullBall = new System.Windows.Forms.Button();
            this.dgvFullBalance = new System.Windows.Forms.DataGridView();
            this.l_TP_Balance = new System.Windows.Forms.Label();
            this.dgvTPBalances = new System.Windows.Forms.DataGridView();
            this.b_CurrPos = new System.Windows.Forms.Button();
            this.t_Finres = new System.Windows.Forms.TabPage();
            this.lFR_Result = new System.Windows.Forms.Label();
            this.lFR_FullResult = new System.Windows.Forms.Label();
            this.dgvFR_Reval = new System.Windows.Forms.DataGridView();
            this.lFR_TP = new System.Windows.Forms.Label();
            this.cbFR_TP = new System.Windows.Forms.ComboBox();
            this.bFR_Count = new System.Windows.Forms.Button();
            this.lFR_Date = new System.Windows.Forms.Label();
            this.dtpFR_date = new System.Windows.Forms.DateTimePicker();
            this.t_BasisCount = new System.Windows.Forms.TabPage();
            this.cb_BC_Autoreload = new System.Windows.Forms.CheckBox();
            this.tb_BC_Interval = new System.Windows.Forms.TextBox();
            this.b_BC_Set = new System.Windows.Forms.Button();
            this.b_BC_Load = new System.Windows.Forms.Button();
            this.dgv_BC_settings = new System.Windows.Forms.DataGridView();
            this.timer_BC = new System.Windows.Forms.Timer(this.components);
            this.l_Kfs_with_TP = new System.Windows.Forms.Label();
            this.b_down_inv = new System.Windows.Forms.Button();
            this.b_up_inv = new System.Windows.Forms.Button();
            this.b_down_ = new System.Windows.Forms.Button();
            this.b_Up_ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.t_CurrPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTPBalances)).BeginInit();
            this.t_Finres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFR_Reval)).BeginInit();
            this.t_BasisCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BC_settings)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLog.Location = new System.Drawing.Point(0, 889);
            this.tbLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(1782, 88);
            this.tbLog.TabIndex = 0;
            // 
            // bConn
            // 
            this.bConn.BackColor = System.Drawing.Color.White;
            this.bConn.Location = new System.Drawing.Point(12, 12);
            this.bConn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bConn.Name = "bConn";
            this.bConn.Size = new System.Drawing.Size(149, 34);
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
            this.dgvTP.Location = new System.Drawing.Point(12, 52);
            this.dgvTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTP.Name = "dgvTP";
            this.dgvTP.RowHeadersWidth = 5;
            this.dgvTP.RowTemplate.Height = 24;
            this.dgvTP.Size = new System.Drawing.Size(1758, 217);
            this.dgvTP.TabIndex = 3;
            this.dgvTP.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditFinished);
            this.dgvTP.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EnterTpTable);
            this.dgvTP.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.WrongData);
            // 
            // bUpdateTP
            // 
            this.bUpdateTP.BackColor = System.Drawing.Color.White;
            this.bUpdateTP.Enabled = false;
            this.bUpdateTP.Location = new System.Drawing.Point(1621, 14);
            this.bUpdateTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bUpdateTP.Name = "bUpdateTP";
            this.bUpdateTP.Size = new System.Drawing.Size(149, 34);
            this.bUpdateTP.TabIndex = 4;
            this.bUpdateTP.Text = "update TP";
            this.bUpdateTP.UseVisualStyleBackColor = false;
            this.bUpdateTP.Click += new System.EventHandler(this.updateTPclick);
            // 
            // b_Apply
            // 
            this.b_Apply.BackColor = System.Drawing.Color.White;
            this.b_Apply.Enabled = false;
            this.b_Apply.Location = new System.Drawing.Point(12, 274);
            this.b_Apply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_Apply.Name = "b_Apply";
            this.b_Apply.Size = new System.Drawing.Size(149, 34);
            this.b_Apply.TabIndex = 5;
            this.b_Apply.Text = "Apply";
            this.b_Apply.UseVisualStyleBackColor = false;
            this.b_Apply.Click += new System.EventHandler(this.b_Apply_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.b_down_inv);
            this.panel1.Controls.Add(this.b_up_inv);
            this.panel1.Controls.Add(this.b_down_);
            this.panel1.Controls.Add(this.b_Up_);
            this.panel1.Controls.Add(this.l_Kfs_with_TP);
            this.panel1.Controls.Add(this.b_Apply);
            this.panel1.Controls.Add(this.dgvTP);
            this.panel1.Controls.Add(this.bUpdateTP);
            this.panel1.Controls.Add(this.bConn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1782, 322);
            this.panel1.TabIndex = 6;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.t_CurrPos);
            this.tabControl_Main.Controls.Add(this.t_Finres);
            this.tabControl_Main.Controls.Add(this.t_BasisCount);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Enabled = false;
            this.tabControl_Main.ItemSize = new System.Drawing.Size(150, 27);
            this.tabControl_Main.Location = new System.Drawing.Point(0, 322);
            this.tabControl_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1782, 567);
            this.tabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Main.TabIndex = 7;
            // 
            // t_CurrPos
            // 
            this.t_CurrPos.BackColor = System.Drawing.Color.Gainsboro;
            this.t_CurrPos.Controls.Add(this.l_OrdersDelays);
            this.t_CurrPos.Controls.Add(this.dgvDelays);
            this.t_CurrPos.Controls.Add(this.b_FullBall);
            this.t_CurrPos.Controls.Add(this.dgvFullBalance);
            this.t_CurrPos.Controls.Add(this.l_TP_Balance);
            this.t_CurrPos.Controls.Add(this.dgvTPBalances);
            this.t_CurrPos.Controls.Add(this.b_CurrPos);
            this.t_CurrPos.Location = new System.Drawing.Point(4, 31);
            this.t_CurrPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t_CurrPos.Name = "t_CurrPos";
            this.t_CurrPos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t_CurrPos.Size = new System.Drawing.Size(1774, 532);
            this.t_CurrPos.TabIndex = 0;
            this.t_CurrPos.Text = "Current Positions";
            // 
            // l_OrdersDelays
            // 
            this.l_OrdersDelays.AutoSize = true;
            this.l_OrdersDelays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_OrdersDelays.Location = new System.Drawing.Point(8, 340);
            this.l_OrdersDelays.Name = "l_OrdersDelays";
            this.l_OrdersDelays.Size = new System.Drawing.Size(118, 20);
            this.l_OrdersDelays.TabIndex = 7;
            this.l_OrdersDelays.Text = "Orders Delays";
            // 
            // dgvDelays
            // 
            this.dgvDelays.AllowUserToAddRows = false;
            this.dgvDelays.AllowUserToDeleteRows = false;
            this.dgvDelays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelays.Location = new System.Drawing.Point(8, 369);
            this.dgvDelays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDelays.Name = "dgvDelays";
            this.dgvDelays.RowHeadersWidth = 5;
            this.dgvDelays.RowTemplate.Height = 24;
            this.dgvDelays.Size = new System.Drawing.Size(629, 150);
            this.dgvDelays.TabIndex = 6;
            // 
            // b_FullBall
            // 
            this.b_FullBall.BackColor = System.Drawing.Color.White;
            this.b_FullBall.Location = new System.Drawing.Point(1617, 6);
            this.b_FullBall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_FullBall.Name = "b_FullBall";
            this.b_FullBall.Size = new System.Drawing.Size(149, 34);
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
            this.dgvFullBalance.Location = new System.Drawing.Point(659, 47);
            this.dgvFullBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFullBalance.Name = "dgvFullBalance";
            this.dgvFullBalance.RowHeadersWidth = 4;
            this.dgvFullBalance.RowTemplate.Height = 24;
            this.dgvFullBalance.Size = new System.Drawing.Size(1107, 473);
            this.dgvFullBalance.TabIndex = 4;
            // 
            // l_TP_Balance
            // 
            this.l_TP_Balance.AutoSize = true;
            this.l_TP_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_TP_Balance.Location = new System.Drawing.Point(653, 21);
            this.l_TP_Balance.Name = "l_TP_Balance";
            this.l_TP_Balance.Size = new System.Drawing.Size(102, 20);
            this.l_TP_Balance.TabIndex = 3;
            this.l_TP_Balance.Text = "Full Balance";
            // 
            // dgvTPBalances
            // 
            this.dgvTPBalances.AllowUserToAddRows = false;
            this.dgvTPBalances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTPBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTPBalances.Location = new System.Drawing.Point(8, 47);
            this.dgvTPBalances.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTPBalances.Name = "dgvTPBalances";
            this.dgvTPBalances.RowHeadersWidth = 4;
            this.dgvTPBalances.RowTemplate.Height = 24;
            this.dgvTPBalances.Size = new System.Drawing.Size(629, 277);
            this.dgvTPBalances.TabIndex = 2;
            this.dgvTPBalances.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_TP_Balance);
            // 
            // b_CurrPos
            // 
            this.b_CurrPos.BackColor = System.Drawing.Color.White;
            this.b_CurrPos.Location = new System.Drawing.Point(8, 6);
            this.b_CurrPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_CurrPos.Name = "b_CurrPos";
            this.b_CurrPos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_CurrPos.Size = new System.Drawing.Size(149, 34);
            this.b_CurrPos.TabIndex = 1;
            this.b_CurrPos.Text = "Current Position";
            this.b_CurrPos.UseVisualStyleBackColor = false;
            this.b_CurrPos.Click += new System.EventHandler(this.b_CurrPos_Click);
            // 
            // t_Finres
            // 
            this.t_Finres.BackColor = System.Drawing.Color.Gainsboro;
            this.t_Finres.Controls.Add(this.lFR_Result);
            this.t_Finres.Controls.Add(this.lFR_FullResult);
            this.t_Finres.Controls.Add(this.dgvFR_Reval);
            this.t_Finres.Controls.Add(this.lFR_TP);
            this.t_Finres.Controls.Add(this.cbFR_TP);
            this.t_Finres.Controls.Add(this.bFR_Count);
            this.t_Finres.Controls.Add(this.lFR_Date);
            this.t_Finres.Controls.Add(this.dtpFR_date);
            this.t_Finres.Location = new System.Drawing.Point(4, 31);
            this.t_Finres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t_Finres.Name = "t_Finres";
            this.t_Finres.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t_Finres.Size = new System.Drawing.Size(1774, 532);
            this.t_Finres.TabIndex = 1;
            this.t_Finres.Text = "Finres";
            // 
            // lFR_Result
            // 
            this.lFR_Result.AutoSize = true;
            this.lFR_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFR_Result.Location = new System.Drawing.Point(9, 171);
            this.lFR_Result.Name = "lFR_Result";
            this.lFR_Result.Size = new System.Drawing.Size(83, 25);
            this.lFR_Result.TabIndex = 7;
            this.lFR_Result.Text = "Result =";
            // 
            // lFR_FullResult
            // 
            this.lFR_FullResult.AutoSize = true;
            this.lFR_FullResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFR_FullResult.ForeColor = System.Drawing.Color.Navy;
            this.lFR_FullResult.Location = new System.Drawing.Point(99, 171);
            this.lFR_FullResult.Name = "lFR_FullResult";
            this.lFR_FullResult.Size = new System.Drawing.Size(24, 25);
            this.lFR_FullResult.TabIndex = 6;
            this.lFR_FullResult.Text = "0";
            // 
            // dgvFR_Reval
            // 
            this.dgvFR_Reval.AllowUserToAddRows = false;
            this.dgvFR_Reval.AllowUserToDeleteRows = false;
            this.dgvFR_Reval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFR_Reval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFR_Reval.Location = new System.Drawing.Point(377, 14);
            this.dgvFR_Reval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFR_Reval.Name = "dgvFR_Reval";
            this.dgvFR_Reval.RowHeadersWidth = 5;
            this.dgvFR_Reval.RowTemplate.Height = 24;
            this.dgvFR_Reval.Size = new System.Drawing.Size(1360, 490);
            this.dgvFR_Reval.TabIndex = 5;
            // 
            // lFR_TP
            // 
            this.lFR_TP.AutoSize = true;
            this.lFR_TP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFR_TP.Location = new System.Drawing.Point(8, 26);
            this.lFR_TP.Name = "lFR_TP";
            this.lFR_TP.Size = new System.Drawing.Size(80, 20);
            this.lFR_TP.TabIndex = 4;
            this.lFR_TP.Text = "Tradepair";
            // 
            // cbFR_TP
            // 
            this.cbFR_TP.FormattingEnabled = true;
            this.cbFR_TP.Location = new System.Drawing.Point(103, 22);
            this.cbFR_TP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFR_TP.Name = "cbFR_TP";
            this.cbFR_TP.Size = new System.Drawing.Size(252, 24);
            this.cbFR_TP.TabIndex = 3;
            // 
            // bFR_Count
            // 
            this.bFR_Count.BackColor = System.Drawing.Color.White;
            this.bFR_Count.Location = new System.Drawing.Point(103, 110);
            this.bFR_Count.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bFR_Count.Name = "bFR_Count";
            this.bFR_Count.Size = new System.Drawing.Size(252, 39);
            this.bFR_Count.TabIndex = 2;
            this.bFR_Count.Text = "Count";
            this.bFR_Count.UseVisualStyleBackColor = false;
            this.bFR_Count.Click += new System.EventHandler(this.bFR_CountClick);
            // 
            // lFR_Date
            // 
            this.lFR_Date.AutoSize = true;
            this.lFR_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFR_Date.Location = new System.Drawing.Point(9, 66);
            this.lFR_Date.Name = "lFR_Date";
            this.lFR_Date.Size = new System.Drawing.Size(45, 20);
            this.lFR_Date.TabIndex = 1;
            this.lFR_Date.Text = "Date";
            // 
            // dtpFR_date
            // 
            this.dtpFR_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpFR_date.Location = new System.Drawing.Point(103, 63);
            this.dtpFR_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFR_date.Name = "dtpFR_date";
            this.dtpFR_date.Size = new System.Drawing.Size(252, 24);
            this.dtpFR_date.TabIndex = 0;
            // 
            // t_BasisCount
            // 
            this.t_BasisCount.BackColor = System.Drawing.Color.Gainsboro;
            this.t_BasisCount.Controls.Add(this.cb_BC_Autoreload);
            this.t_BasisCount.Controls.Add(this.tb_BC_Interval);
            this.t_BasisCount.Controls.Add(this.b_BC_Set);
            this.t_BasisCount.Controls.Add(this.b_BC_Load);
            this.t_BasisCount.Controls.Add(this.dgv_BC_settings);
            this.t_BasisCount.Location = new System.Drawing.Point(4, 31);
            this.t_BasisCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_BasisCount.Name = "t_BasisCount";
            this.t_BasisCount.Size = new System.Drawing.Size(1774, 532);
            this.t_BasisCount.TabIndex = 2;
            this.t_BasisCount.Text = "Basis Count";
            // 
            // cb_BC_Autoreload
            // 
            this.cb_BC_Autoreload.AutoSize = true;
            this.cb_BC_Autoreload.Location = new System.Drawing.Point(1380, 18);
            this.cb_BC_Autoreload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_BC_Autoreload.Name = "cb_BC_Autoreload";
            this.cb_BC_Autoreload.Size = new System.Drawing.Size(228, 21);
            this.cb_BC_Autoreload.TabIndex = 4;
            this.cb_BC_Autoreload.Text = "Autoreload.   Interval (seconds)";
            this.cb_BC_Autoreload.UseVisualStyleBackColor = true;
            this.cb_BC_Autoreload.CheckStateChanged += new System.EventHandler(this.BC_Autoreload_check);
            // 
            // tb_BC_Interval
            // 
            this.tb_BC_Interval.Location = new System.Drawing.Point(1620, 16);
            this.tb_BC_Interval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_BC_Interval.Name = "tb_BC_Interval";
            this.tb_BC_Interval.Size = new System.Drawing.Size(119, 22);
            this.tb_BC_Interval.TabIndex = 3;
            this.tb_BC_Interval.Text = "60";
            // 
            // b_BC_Set
            // 
            this.b_BC_Set.BackColor = System.Drawing.Color.WhiteSmoke;
            this.b_BC_Set.Location = new System.Drawing.Point(212, 16);
            this.b_BC_Set.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_BC_Set.Name = "b_BC_Set";
            this.b_BC_Set.Size = new System.Drawing.Size(144, 28);
            this.b_BC_Set.TabIndex = 2;
            this.b_BC_Set.Text = "Count and Set";
            this.b_BC_Set.UseVisualStyleBackColor = false;
            this.b_BC_Set.Click += new System.EventHandler(this.BC_Set_Click);
            // 
            // b_BC_Load
            // 
            this.b_BC_Load.BackColor = System.Drawing.Color.WhiteSmoke;
            this.b_BC_Load.Location = new System.Drawing.Point(12, 16);
            this.b_BC_Load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_BC_Load.Name = "b_BC_Load";
            this.b_BC_Load.Size = new System.Drawing.Size(144, 28);
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
            this.dgv_BC_settings.Location = new System.Drawing.Point(11, 52);
            this.dgv_BC_settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_BC_settings.Name = "dgv_BC_settings";
            this.dgv_BC_settings.RowHeadersWidth = 5;
            this.dgv_BC_settings.Size = new System.Drawing.Size(1731, 140);
            this.dgv_BC_settings.TabIndex = 0;
            // 
            // timer_BC
            // 
            this.timer_BC.Interval = 60000;
            this.timer_BC.Tick += new System.EventHandler(this.BC_Timer_Work);
            // 
            // l_Kfs_with_TP
            // 
            this.l_Kfs_with_TP.AutoSize = true;
            this.l_Kfs_with_TP.Location = new System.Drawing.Point(236, 283);
            this.l_Kfs_with_TP.Name = "l_Kfs_with_TP";
            this.l_Kfs_with_TP.Size = new System.Drawing.Size(53, 17);
            this.l_Kfs_with_TP.TabIndex = 6;
            this.l_Kfs_with_TP.Text = "Kfs for ";
            // 
            // b_down_inv
            // 
            this.b_down_inv.Image = global::monitor3lx.Properties.Resources.downInv;
            this.b_down_inv.Location = new System.Drawing.Point(709, 274);
            this.b_down_inv.Name = "b_down_inv";
            this.b_down_inv.Size = new System.Drawing.Size(42, 42);
            this.b_down_inv.TabIndex = 10;
            this.b_down_inv.UseVisualStyleBackColor = true;
            this.b_down_inv.Click += new System.EventHandler(this.b_down_Inv);
            // 
            // b_up_inv
            // 
            this.b_up_inv.Image = global::monitor3lx.Properties.Resources.upInv;
            this.b_up_inv.Location = new System.Drawing.Point(661, 274);
            this.b_up_inv.Name = "b_up_inv";
            this.b_up_inv.Size = new System.Drawing.Size(42, 42);
            this.b_up_inv.TabIndex = 9;
            this.b_up_inv.UseVisualStyleBackColor = true;
            this.b_up_inv.Click += new System.EventHandler(this.b_up_Inv);
            // 
            // b_down_
            // 
            this.b_down_.Image = global::monitor3lx.Properties.Resources.down;
            this.b_down_.Location = new System.Drawing.Point(562, 275);
            this.b_down_.Name = "b_down_";
            this.b_down_.Size = new System.Drawing.Size(42, 42);
            this.b_down_.TabIndex = 8;
            this.b_down_.UseVisualStyleBackColor = true;
            this.b_down_.Click += new System.EventHandler(this.b_down_Click);
            // 
            // b_Up_
            // 
            this.b_Up_.Image = global::monitor3lx.Properties.Resources.up;
            this.b_Up_.Location = new System.Drawing.Point(514, 275);
            this.b_Up_.Name = "b_Up_";
            this.b_Up_.Size = new System.Drawing.Size(42, 42);
            this.b_Up_.TabIndex = 7;
            this.b_Up_.UseVisualStyleBackColor = true;
            this.b_Up_.Click += new System.EventHandler(this.b_Up_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 977);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbLog);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "monitor3lx";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl_Main.ResumeLayout(false);
            this.t_CurrPos.ResumeLayout(false);
            this.t_CurrPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTPBalances)).EndInit();
            this.t_Finres.ResumeLayout(false);
            this.t_Finres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFR_Reval)).EndInit();
            this.t_BasisCount.ResumeLayout(false);
            this.t_BasisCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BC_settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button bConn;
        private System.Windows.Forms.DataGridView dgvTP;
        private System.Windows.Forms.Button bUpdateTP;
        private System.Windows.Forms.Button b_Apply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage t_CurrPos;
        private System.Windows.Forms.TabPage t_Finres;
        private System.Windows.Forms.Button b_CurrPos;
        private System.Windows.Forms.DataGridView dgvTPBalances;
        private System.Windows.Forms.DataGridView dgvFullBalance;
        private System.Windows.Forms.Label l_TP_Balance;
        private System.Windows.Forms.Button b_FullBall;
        private System.Windows.Forms.Label l_OrdersDelays;
        private System.Windows.Forms.DataGridView dgvDelays;
        private System.Windows.Forms.DateTimePicker dtpFR_date;
        private System.Windows.Forms.Label lFR_Date;
        private System.Windows.Forms.Button bFR_Count;
        private System.Windows.Forms.Label lFR_TP;
        private System.Windows.Forms.ComboBox cbFR_TP;
        private System.Windows.Forms.DataGridView dgvFR_Reval;
        private System.Windows.Forms.Label lFR_FullResult;
        private System.Windows.Forms.Label lFR_Result;
        private System.Windows.Forms.TabPage t_BasisCount;
        private System.Windows.Forms.DataGridView dgv_BC_settings;
        private System.Windows.Forms.Button b_BC_Load;
        private System.Windows.Forms.Button b_BC_Set;
        private System.Windows.Forms.CheckBox cb_BC_Autoreload;
        private System.Windows.Forms.TextBox tb_BC_Interval;
        private System.Windows.Forms.Timer timer_BC;
        private System.Windows.Forms.Label l_Kfs_with_TP;
        private System.Windows.Forms.Button b_Up_;
        private System.Windows.Forms.Button b_down_;
        private System.Windows.Forms.Button b_down_inv;
        private System.Windows.Forms.Button b_up_inv;
    }
}

