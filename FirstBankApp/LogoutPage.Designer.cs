namespace FirstBankApp
{
    partial class LogoutPage
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
            this.pnldepositpage2 = new System.Windows.Forms.Panel();
            this.txtsuccessfulmsg = new System.Windows.Forms.Label();
            this.txtlogoutpage = new System.Windows.Forms.Label();
            this.btnsetupaccount = new System.Windows.Forms.Button();
            this.btnloginexistinguser = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.pnldepositpage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnldepositpage2
            // 
            this.pnldepositpage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnldepositpage2.Controls.Add(this.btnexit);
            this.pnldepositpage2.Controls.Add(this.btnloginexistinguser);
            this.pnldepositpage2.Controls.Add(this.btnsetupaccount);
            this.pnldepositpage2.Controls.Add(this.txtsuccessfulmsg);
            this.pnldepositpage2.Controls.Add(this.txtlogoutpage);
            this.pnldepositpage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnldepositpage2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnldepositpage2.Location = new System.Drawing.Point(68, 103);
            this.pnldepositpage2.Name = "pnldepositpage2";
            this.pnldepositpage2.Size = new System.Drawing.Size(745, 291);
            this.pnldepositpage2.TabIndex = 5;
            // 
            // txtsuccessfulmsg
            // 
            this.txtsuccessfulmsg.AutoSize = true;
            this.txtsuccessfulmsg.Location = new System.Drawing.Point(214, 259);
            this.txtsuccessfulmsg.Name = "txtsuccessfulmsg";
            this.txtsuccessfulmsg.Size = new System.Drawing.Size(255, 20);
            this.txtsuccessfulmsg.TabIndex = 2;
            this.txtsuccessfulmsg.Text = "Hey yo! Please Select Your Option.";
            // 
            // txtlogoutpage
            // 
            this.txtlogoutpage.AutoSize = true;
            this.txtlogoutpage.Location = new System.Drawing.Point(34, 41);
            this.txtlogoutpage.Name = "txtlogoutpage";
            this.txtlogoutpage.Size = new System.Drawing.Size(0, 20);
            this.txtlogoutpage.TabIndex = 0;
            // 
            // btnsetupaccount
            // 
            this.btnsetupaccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsetupaccount.Location = new System.Drawing.Point(214, 24);
            this.btnsetupaccount.Name = "btnsetupaccount";
            this.btnsetupaccount.Size = new System.Drawing.Size(255, 52);
            this.btnsetupaccount.TabIndex = 3;
            this.btnsetupaccount.Text = "Set Up New User Account";
            this.btnsetupaccount.UseVisualStyleBackColor = true;
            this.btnsetupaccount.Click += new System.EventHandler(this.btnsetupaccount_Click);
            // 
            // btnloginexistinguser
            // 
            this.btnloginexistinguser.ForeColor = System.Drawing.Color.Black;
            this.btnloginexistinguser.Location = new System.Drawing.Point(214, 109);
            this.btnloginexistinguser.Name = "btnloginexistinguser";
            this.btnloginexistinguser.Size = new System.Drawing.Size(255, 40);
            this.btnloginexistinguser.TabIndex = 4;
            this.btnloginexistinguser.Text = "Login";
            this.btnloginexistinguser.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnexit.Location = new System.Drawing.Point(214, 185);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(255, 43);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // LogoutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 496);
            this.Controls.Add(this.pnldepositpage2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(291, 123);
            this.Name = "LogoutPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LogoutPage";
            this.pnldepositpage2.ResumeLayout(false);
            this.pnldepositpage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldepositpage2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnloginexistinguser;
        private System.Windows.Forms.Button btnsetupaccount;
        private System.Windows.Forms.Label txtsuccessfulmsg;
        private System.Windows.Forms.Label txtlogoutpage;
    }
}