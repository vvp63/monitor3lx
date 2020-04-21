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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLog.Location = new System.Drawing.Point(0, 570);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(1486, 144);
            this.tbLog.TabIndex = 0;
            // 
            // bConn
            // 
            this.bConn.Location = new System.Drawing.Point(12, 12);
            this.bConn.Name = "bConn";
            this.bConn.Size = new System.Drawing.Size(75, 23);
            this.bConn.TabIndex = 1;
            this.bConn.Text = "Connect";
            this.bConn.UseVisualStyleBackColor = true;
            this.bConn.Click += new System.EventHandler(this.ConnClick);
            // 
            // dgvTP
            // 
            this.dgvTP.AllowDrop = true;
            this.dgvTP.AllowUserToAddRows = false;
            this.dgvTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTP.Location = new System.Drawing.Point(12, 51);
            this.dgvTP.Name = "dgvTP";
            this.dgvTP.RowHeadersWidth = 5;
            this.dgvTP.RowTemplate.Height = 24;
            this.dgvTP.Size = new System.Drawing.Size(1462, 272);
            this.dgvTP.TabIndex = 3;
            // 
            // bUpdateTP
            // 
            this.bUpdateTP.Location = new System.Drawing.Point(839, 12);
            this.bUpdateTP.Name = "bUpdateTP";
            this.bUpdateTP.Size = new System.Drawing.Size(116, 23);
            this.bUpdateTP.TabIndex = 4;
            this.bUpdateTP.Text = "update TP";
            this.bUpdateTP.UseVisualStyleBackColor = true;
            this.bUpdateTP.Click += new System.EventHandler(this.updateTPclick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 714);
            this.Controls.Add(this.bUpdateTP);
            this.Controls.Add(this.dgvTP);
            this.Controls.Add(this.bConn);
            this.Controls.Add(this.tbLog);
            this.Name = "Form1";
            this.Text = "monitor3lx";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button bConn;
        private System.Windows.Forms.DataGridView dgvTP;
        private System.Windows.Forms.Button bUpdateTP;
    }
}

