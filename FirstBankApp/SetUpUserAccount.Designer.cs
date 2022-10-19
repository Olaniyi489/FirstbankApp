namespace FirstBankApp
{
    partial class SetUpUserAccount
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
            this.txtfullname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtemailaddress = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtenterpassword = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnsetupaccount = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfullname
            // 
            this.txtfullname.AutoSize = true;
            this.txtfullname.Location = new System.Drawing.Point(254, 47);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(82, 13);
            this.txtfullname.TabIndex = 0;
            this.txtfullname.Text = "Enter Full Name";
            this.txtfullname.Click += new System.EventHandler(this.txtfullname_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtemailaddress
            // 
            this.txtemailaddress.AutoSize = true;
            this.txtemailaddress.Location = new System.Drawing.Point(245, 128);
            this.txtemailaddress.Name = "txtemailaddress";
            this.txtemailaddress.Size = new System.Drawing.Size(101, 13);
            this.txtemailaddress.TabIndex = 2;
            this.txtemailaddress.Text = "Enter Email Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(460, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtenterpassword
            // 
            this.txtenterpassword.AutoSize = true;
            this.txtenterpassword.Location = new System.Drawing.Point(245, 199);
            this.txtenterpassword.Name = "txtenterpassword";
            this.txtenterpassword.Size = new System.Drawing.Size(84, 13);
            this.txtenterpassword.TabIndex = 4;
            this.txtenterpassword.Text = "Enter PassWord";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(460, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(340, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnsetupaccount
            // 
            this.btnsetupaccount.Location = new System.Drawing.Point(532, 287);
            this.btnsetupaccount.Name = "btnsetupaccount";
            this.btnsetupaccount.Size = new System.Drawing.Size(205, 23);
            this.btnsetupaccount.TabIndex = 6;
            this.btnsetupaccount.Text = "Submit";
            this.btnsetupaccount.UseVisualStyleBackColor = true;
            this.btnsetupaccount.Click += new System.EventHandler(this.btnsetupaccount_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(29, 37);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(99, 23);
            this.home.TabIndex = 7;
            this.home.Text = "Back";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // SetUpUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 575);
            this.Controls.Add(this.home);
            this.Controls.Add(this.btnsetupaccount);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtenterpassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtemailaddress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtfullname);
            this.Location = new System.Drawing.Point(258, 66);
            this.Name = "SetUpUserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SetUpUserAccount";
            this.Load += new System.EventHandler(this.SetUpUserAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtfullname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtemailaddress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtenterpassword;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnsetupaccount;
        private System.Windows.Forms.Button home;
    }
}