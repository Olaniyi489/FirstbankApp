namespace FirstBankApp
{
    partial class Welcome
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
            this.txtSetUpUserAcc = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSetUpUserAcc
            // 
            this.txtSetUpUserAcc.AutoSize = true;
            this.txtSetUpUserAcc.Location = new System.Drawing.Point(5, 43);
            this.txtSetUpUserAcc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtSetUpUserAcc.Name = "txtSetUpUserAcc";
            this.txtSetUpUserAcc.Size = new System.Drawing.Size(179, 20);
            this.txtSetUpUserAcc.TabIndex = 0;
            this.txtSetUpUserAcc.Text = "Set Up User Account";
            this.txtSetUpUserAcc.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.Lavender;
            this.txtLogin.Location = new System.Drawing.Point(31, 108);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(78, 29);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "Login";
            this.txtLogin.Click += new System.EventHandler(this.txtLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtSetUpUserAcc);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.ForeColor = System.Drawing.Color.Lavender;
            this.panel1.Location = new System.Drawing.Point(25, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 208);
            this.panel1.TabIndex = 3;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 692);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Welcome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtSetUpUserAcc;
        private System.Windows.Forms.Label txtLogin;
        private System.Windows.Forms.Panel panel1;
    }
}

