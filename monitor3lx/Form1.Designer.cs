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
            this.bGetTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLog.Location = new System.Drawing.Point(0, 191);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(1021, 230);
            this.tbLog.TabIndex = 0;
            // 
            // bConn
            // 
            this.bConn.Location = new System.Drawing.Point(13, 24);
            this.bConn.Name = "bConn";
            this.bConn.Size = new System.Drawing.Size(75, 23);
            this.bConn.TabIndex = 1;
            this.bConn.Text = "Connect";
            this.bConn.UseVisualStyleBackColor = true;
            this.bConn.Click += new System.EventHandler(this.ConnClick);
            // 
            // bGetTP
            // 
            this.bGetTP.Location = new System.Drawing.Point(336, 23);
            this.bGetTP.Name = "bGetTP";
            this.bGetTP.Size = new System.Drawing.Size(75, 23);
            this.bGetTP.TabIndex = 2;
            this.bGetTP.Text = "getTP";
            this.bGetTP.UseVisualStyleBackColor = true;
            this.bGetTP.Click += new System.EventHandler(this.getTP);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 421);
            this.Controls.Add(this.bGetTP);
            this.Controls.Add(this.bConn);
            this.Controls.Add(this.tbLog);
            this.Name = "Form1";
            this.Text = "monitor3lx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button bConn;
        private System.Windows.Forms.Button bGetTP;
    }
}

