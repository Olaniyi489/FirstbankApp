﻿namespace FirstBankApp
{
    partial class AccountDetailsPage
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
            this.pnldepositpage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlsection = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt1balance = new System.Windows.Forms.Label();
            this.txt1accounttype = new System.Windows.Forms.Label();
            this.txt1accountnumber = new System.Windows.Forms.Label();
            this.txtaccountownername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtfullname = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.Label();
            this.txtaccounnumber = new System.Windows.Forms.Label();
            this.txtaccounttype = new System.Windows.Forms.Label();
            this.btn_accntdetailspage = new System.Windows.Forms.Button();
            this.btn_clicktoviewdetails = new System.Windows.Forms.Button();
            this.pnldepositpage.SuspendLayout();
            this.pnlsection.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnldepositpage
            // 
            this.pnldepositpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnldepositpage.Controls.Add(this.label1);
            this.pnldepositpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnldepositpage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnldepositpage.Location = new System.Drawing.Point(202, 26);
            this.pnldepositpage.Name = "pnldepositpage";
            this.pnldepositpage.Size = new System.Drawing.Size(408, 43);
            this.pnldepositpage.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Your Account Details Page";
            // 
            // pnlsection
            // 
            this.pnlsection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlsection.Controls.Add(this.btn_clicktoviewdetails);
            this.pnlsection.Controls.Add(this.panel3);
            this.pnlsection.Controls.Add(this.panel2);
            this.pnlsection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlsection.Location = new System.Drawing.Point(12, 128);
            this.pnlsection.Name = "pnlsection";
            this.pnlsection.Size = new System.Drawing.Size(814, 252);
            this.pnlsection.TabIndex = 2;
            this.pnlsection.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlsection_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt1balance);
            this.panel3.Controls.Add(this.txt1accounttype);
            this.panel3.Controls.Add(this.txt1accountnumber);
            this.panel3.Controls.Add(this.txtaccountownername);
            this.panel3.Location = new System.Drawing.Point(55, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 55);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txt1balance
            // 
            this.txt1balance.AutoSize = true;
            this.txt1balance.Location = new System.Drawing.Point(604, 25);
            this.txt1balance.Name = "txt1balance";
            this.txt1balance.Size = new System.Drawing.Size(10, 13);
            this.txt1balance.TabIndex = 3;
            this.txt1balance.Text = " ";
            this.txt1balance.Click += new System.EventHandler(this.txt1balance_Click);
            // 
            // txt1accounttype
            // 
            this.txt1accounttype.AutoSize = true;
            this.txt1accounttype.Location = new System.Drawing.Point(400, 25);
            this.txt1accounttype.Name = "txt1accounttype";
            this.txt1accounttype.Size = new System.Drawing.Size(10, 13);
            this.txt1accounttype.TabIndex = 2;
            this.txt1accounttype.Text = " ";
            this.txt1accounttype.Click += new System.EventHandler(this.txt1accounttype_Click);
            // 
            // txt1accountnumber
            // 
            this.txt1accountnumber.AutoSize = true;
            this.txt1accountnumber.Location = new System.Drawing.Point(217, 25);
            this.txt1accountnumber.Name = "txt1accountnumber";
            this.txt1accountnumber.Size = new System.Drawing.Size(10, 13);
            this.txt1accountnumber.TabIndex = 1;
            this.txt1accountnumber.Text = " ";
            this.txt1accountnumber.Click += new System.EventHandler(this.txt1accountnumber_Click);
            // 
            // txtaccountownername
            // 
            this.txtaccountownername.AutoSize = true;
            this.txtaccountownername.Location = new System.Drawing.Point(37, 25);
            this.txtaccountownername.Name = "txtaccountownername";
            this.txtaccountownername.Size = new System.Drawing.Size(10, 13);
            this.txtaccountownername.TabIndex = 0;
            this.txtaccountownername.Text = " ";
            this.txtaccountownername.Click += new System.EventHandler(this.txtaccountownername_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtfullname);
            this.panel2.Controls.Add(this.txtbalance);
            this.panel2.Controls.Add(this.txtaccounnumber);
            this.panel2.Controls.Add(this.txtaccounttype);
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(55, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 53);
            this.panel2.TabIndex = 4;
            // 
            // txtfullname
            // 
            this.txtfullname.AutoSize = true;
            this.txtfullname.Location = new System.Drawing.Point(37, 20);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(67, 13);
            this.txtfullname.TabIndex = 0;
            this.txtfullname.Text = "FULL NAME";
            // 
            // txtbalance
            // 
            this.txtbalance.AutoSize = true;
            this.txtbalance.Location = new System.Drawing.Point(604, 20);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(56, 13);
            this.txtbalance.TabIndex = 3;
            this.txtbalance.Text = "BALANCE";
            // 
            // txtaccounnumber
            // 
            this.txtaccounnumber.AutoSize = true;
            this.txtaccounnumber.Location = new System.Drawing.Point(217, 20);
            this.txtaccounnumber.Name = "txtaccounnumber";
            this.txtaccounnumber.Size = new System.Drawing.Size(109, 13);
            this.txtaccounnumber.TabIndex = 1;
            this.txtaccounnumber.Text = "ACCOUNT NUMBER";
            // 
            // txtaccounttype
            // 
            this.txtaccounttype.AutoSize = true;
            this.txtaccounttype.Location = new System.Drawing.Point(400, 20);
            this.txtaccounttype.Name = "txtaccounttype";
            this.txtaccounttype.Size = new System.Drawing.Size(90, 13);
            this.txtaccounttype.TabIndex = 2;
            this.txtaccounttype.Text = "ACCOUNT TYPE";
            // 
            // btn_accntdetailspage
            // 
            this.btn_accntdetailspage.Location = new System.Drawing.Point(24, 26);
            this.btn_accntdetailspage.Name = "btn_accntdetailspage";
            this.btn_accntdetailspage.Size = new System.Drawing.Size(75, 23);
            this.btn_accntdetailspage.TabIndex = 3;
            this.btn_accntdetailspage.Text = "Back";
            this.btn_accntdetailspage.UseVisualStyleBackColor = true;
            this.btn_accntdetailspage.Click += new System.EventHandler(this.btn_accntdetailspage_Click);
            // 
            // btn_clicktoviewdetails
            // 
            this.btn_clicktoviewdetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clicktoviewdetails.Location = new System.Drawing.Point(360, 177);
            this.btn_clicktoviewdetails.Name = "btn_clicktoviewdetails";
            this.btn_clicktoviewdetails.Size = new System.Drawing.Size(75, 23);
            this.btn_clicktoviewdetails.TabIndex = 5;
            this.btn_clicktoviewdetails.Text = "Click Here";
            this.btn_clicktoviewdetails.UseVisualStyleBackColor = true;
            this.btn_clicktoviewdetails.Click += new System.EventHandler(this.btn_clicktoviewdetails_Click);
            // 
            // AccountDetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 496);
            this.Controls.Add(this.btn_accntdetailspage);
            this.Controls.Add(this.pnlsection);
            this.Controls.Add(this.pnldepositpage);
            this.Location = new System.Drawing.Point(291, 123);
            this.Name = "AccountDetailsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AccountDetailsPage";
            this.Load += new System.EventHandler(this.AccountDetailsPage_Load);
            this.pnldepositpage.ResumeLayout(false);
            this.pnldepositpage.PerformLayout();
            this.pnlsection.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldepositpage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlsection;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txt1balance;
        private System.Windows.Forms.Label txt1accounttype;
        private System.Windows.Forms.Label txt1accountnumber;
        private System.Windows.Forms.Label txtaccountownername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtfullname;
        private System.Windows.Forms.Label txtbalance;
        private System.Windows.Forms.Label txtaccounnumber;
        private System.Windows.Forms.Label txtaccounttype;
        private System.Windows.Forms.Button btn_accntdetailspage;
        private System.Windows.Forms.Button btn_clicktoviewdetails;
    }
}