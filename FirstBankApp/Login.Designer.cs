namespace FirstBankApp
{
    partial class txtLoginpage
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
            this.txtenteryouremail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtenteryourpassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtenteryouremail
            // 
            this.txtenteryouremail.AutoSize = true;
            this.txtenteryouremail.Location = new System.Drawing.Point(261, 58);
            this.txtenteryouremail.Name = "txtenteryouremail";
            this.txtenteryouremail.Size = new System.Drawing.Size(85, 13);
            this.txtenteryouremail.TabIndex = 0;
            this.txtenteryouremail.Text = "Enter Your Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(479, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtenteryourpassword
            // 
            this.txtenteryourpassword.AutoSize = true;
            this.txtenteryourpassword.Location = new System.Drawing.Point(261, 152);
            this.txtenteryourpassword.Name = "txtenteryourpassword";
            this.txtenteryourpassword.Size = new System.Drawing.Size(109, 13);
            this.txtenteryourpassword.TabIndex = 2;
            this.txtenteryourpassword.Text = "Enter Your PassWord";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(479, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(348, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(563, 244);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(194, 23);
            this.txtlogin.TabIndex = 4;
            this.txtlogin.Text = "Login";
            this.txtlogin.UseVisualStyleBackColor = true;
            this.txtlogin.Click += new System.EventHandler(this.txtlogin_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(65, 28);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(110, 23);
            this.home.TabIndex = 5;
            this.home.Text = "Back";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // txtLoginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 575);
            this.Controls.Add(this.home);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtenteryourpassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtenteryouremail);
            this.Location = new System.Drawing.Point(258, 66);
            this.Name = "txtLoginpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.Logi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtenteryouremail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtenteryourpassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button txtlogin;
        private System.Windows.Forms.Button home;
    }
}