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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.t_CurrPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTPBalances)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLog.Location = new System.Drawing.Point(0, 883);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(1763, 88);
            this.tbLog.TabIndex = 0;
            // 
            // bConn
            // 
            this.bConn.BackColor = System.Drawing.Color.White;
            this.bConn.Location = new System.Drawing.Point(12, 12);
            this.bConn.Name = "bConn";
            this.bConn.Size = new System.Drawing.Size(150, 35);
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
            this.dgvTP.Name = "dgvTP";
            this.dgvTP.RowHeadersWidth = 5;
            this.dgvTP.RowTemplate.Height = 24;
            this.dgvTP.Size = new System.Drawing.Size(1739, 217);
            this.dgvTP.TabIndex = 3;
            this.dgvTP.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditFinished);
            this.dgvTP.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.WrongData);
            // 
            // bUpdateTP
            // 
            this.bUpdateTP.BackColor = System.Drawing.Color.White;
            this.bUpdateTP.Enabled = false;
            this.bUpdateTP.Location = new System.Drawing.Point(1601, 12);
            this.bUpdateTP.Name = "bUpdateTP";
            this.bUpdateTP.Size = new System.Drawing.Size(150, 35);
            this.bUpdateTP.TabIndex = 4;
            this.bUpdateTP.Text = "update TP";
            this.bUpdateTP.UseVisualStyleBackColor = false;
            this.bUpdateTP.Click += new System.EventHandler(this.updateTPclick);
            // 
            // b_Apply
            // 
            this.b_Apply.BackColor = System.Drawing.Color.White;
            this.b_Apply.Enabled = false;
            this.b_Apply.Location = new System.Drawing.Point(12, 275);
            this.b_Apply.Name = "b_Apply";
            this.b_Apply.Size = new System.Drawing.Size(150, 35);
            this.b_Apply.TabIndex = 5;
            this.b_Apply.Text = "Apply";
            this.b_Apply.UseVisualStyleBackColor = false;
            this.b_Apply.Click += new System.EventHandler(this.b_Apply_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.b_Apply);
            this.panel1.Controls.Add(this.dgvTP);
            this.panel1.Controls.Add(this.bUpdateTP);
            this.panel1.Controls.Add(this.bConn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1763, 323);
            this.panel1.TabIndex = 6;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.t_CurrPos);
            this.tabControl_Main.Controls.Add(this.t_Finres);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Enabled = false;
            this.tabControl_Main.ItemSize = new System.Drawing.Size(150, 27);
            this.tabControl_Main.Location = new System.Drawing.Point(0, 323);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1763, 560);
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
            this.t_CurrPos.Name = "t_CurrPos";
            this.t_CurrPos.Padding = new System.Windows.Forms.Padding(3);
            this.t_CurrPos.Size = new System.Drawing.Size(1755, 525);
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
            this.dgvDelays.Name = "dgvDelays";
            this.dgvDelays.RowHeadersWidth = 5;
            this.dgvDelays.RowTemplate.Height = 24;
            this.dgvDelays.Size = new System.Drawing.Size(629, 150);
            this.dgvDelays.TabIndex = 6;
            // 
            // b_FullBall
            // 
            this.b_FullBall.BackColor = System.Drawing.Color.White;
            this.b_FullBall.Location = new System.Drawing.Point(1597, 6);
            this.b_FullBall.Name = "b_FullBall";
            this.b_FullBall.Size = new System.Drawing.Size(150, 35);
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
            this.dgvFullBalance.Location = new System.Drawing.Point(658, 47);
            this.dgvFullBalance.Name = "dgvFullBalance";
            this.dgvFullBalance.RowHeadersWidth = 4;
            this.dgvFullBalance.RowTemplate.Height = 24;
            this.dgvFullBalance.Size = new System.Drawing.Size(1089, 472);
            this.dgvFullBalance.TabIndex = 4;
            // 
            // l_TP_Balance
            // 
            this.l_TP_Balance.AutoSize = true;
            this.l_TP_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_TP_Balance.Location = new System.Drawing.Point(654, 21);
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
            this.b_CurrPos.Name = "b_CurrPos";
            this.b_CurrPos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b_CurrPos.Size = new System.Drawing.Size(150, 35);
            this.b_CurrPos.TabIndex = 1;
            this.b_CurrPos.Text = "Current Position";
            this.b_CurrPos.UseVisualStyleBackColor = false;
            this.b_CurrPos.Click += new System.EventHandler(this.b_CurrPos_Click);
            // 
            // t_Finres
            // 
            this.t_Finres.BackColor = System.Drawing.Color.Gainsboro;
            this.t_Finres.Location = new System.Drawing.Point(4, 31);
            this.t_Finres.Name = "t_Finres";
            this.t_Finres.Padding = new System.Windows.Forms.Padding(3);
            this.t_Finres.Size = new System.Drawing.Size(1755, 525);
            this.t_Finres.TabIndex = 1;
            this.t_Finres.Text = "Finres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1763, 971);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbLog);
            this.Name = "Form1";
            this.Text = "monitor3lx";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl_Main.ResumeLayout(false);
            this.t_CurrPos.ResumeLayout(false);
            this.t_CurrPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFullBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTPBalances)).EndInit();
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
    }
}

