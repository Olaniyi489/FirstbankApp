namespace FirstBankApp
{
    partial class txtwithdrawalpage
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
            this.pnldewithdrawalpage = new System.Windows.Forms.Panel();
            this.txtwithpagrawale = new System.Windows.Forms.Label();
            this.pnldepositpage2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtsuccessfulmsg = new System.Windows.Forms.Label();
            this.txtamounttodeposit = new System.Windows.Forms.Label();
            this.txtenteraccountnumber = new System.Windows.Forms.Label();
            this.pnldewithdrawalpage.SuspendLayout();
            this.pnldepositpage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnldewithdrawalpage
            // 
            this.pnldewithdrawalpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnldewithdrawalpage.Controls.Add(this.txtwithpagrawale);
            this.pnldewithdrawalpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnldewithdrawalpage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnldewithdrawalpage.Location = new System.Drawing.Point(225, 12);
            this.pnldewithdrawalpage.Name = "pnldewithdrawalpage";
            this.pnldewithdrawalpage.Size = new System.Drawing.Size(408, 43);
            this.pnldewithdrawalpage.TabIndex = 1;
            // 
            // txtwithpagrawale
            // 
            this.txtwithpagrawale.AutoSize = true;
            this.txtwithpagrawale.Location = new System.Drawing.Point(93, 13);
            this.txtwithpagrawale.Name = "txtwithpagrawale";
            this.txtwithpagrawale.Size = new System.Drawing.Size(212, 18);
            this.txtwithpagrawale.TabIndex = 0;
            this.txtwithpagrawale.Text = "Welcome To WithDrawal Page";
            this.txtwithpagrawale.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnldepositpage2
            // 
            this.pnldepositpage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnldepositpage2.Controls.Add(this.textBox2);
            this.pnldepositpage2.Controls.Add(this.textBox1);
            this.pnldepositpage2.Controls.Add(this.txtsuccessfulmsg);
            this.pnldepositpage2.Controls.Add(this.txtamounttodeposit);
            this.pnldepositpage2.Controls.Add(this.txtenteraccountnumber);
            this.pnldepositpage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnldepositpage2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnldepositpage2.Location = new System.Drawing.Point(137, 137);
            this.pnldepositpage2.Name = "pnldepositpage2";
            this.pnldepositpage2.Size = new System.Drawing.Size(636, 291);
            this.pnldepositpage2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(306, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(327, 24);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 24);
            this.textBox1.TabIndex = 3;
            // 
            // txtsuccessfulmsg
            // 
            this.txtsuccessfulmsg.AutoSize = true;
            this.txtsuccessfulmsg.Location = new System.Drawing.Point(214, 235);
            this.txtsuccessfulmsg.Name = "txtsuccessfulmsg";
            this.txtsuccessfulmsg.Size = new System.Drawing.Size(290, 18);
            this.txtsuccessfulmsg.TabIndex = 2;
            this.txtsuccessfulmsg.Text = "Hey yo!  Amount  Successfully WithDrawa!!";
            // 
            // txtamounttodeposit
            // 
            this.txtamounttodeposit.AutoSize = true;
            this.txtamounttodeposit.Location = new System.Drawing.Point(34, 134);
            this.txtamounttodeposit.Name = "txtamounttodeposit";
            this.txtamounttodeposit.Size = new System.Drawing.Size(237, 18);
            this.txtamounttodeposit.TabIndex = 1;
            this.txtamounttodeposit.Text = "Please Enter Amount  to WithDraw";
            // 
            // txtenteraccountnumber
            // 
            this.txtenteraccountnumber.AutoSize = true;
            this.txtenteraccountnumber.Location = new System.Drawing.Point(34, 41);
            this.txtenteraccountnumber.Name = "txtenteraccountnumber";
            this.txtenteraccountnumber.Size = new System.Drawing.Size(207, 18);
            this.txtenteraccountnumber.TabIndex = 0;
            this.txtenteraccountnumber.Text = "Please Enter Account Number";
            // 
            // txtwithdrawalpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 496);
            this.Controls.Add(this.pnldepositpage2);
            this.Controls.Add(this.pnldewithdrawalpage);
            this.Location = new System.Drawing.Point(291, 123);
            this.Name = "txtwithdrawalpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WithdrawalPage";
            this.Load += new System.EventHandler(this.txtwithdrawalpage_Load);
            this.pnldewithdrawalpage.ResumeLayout(false);
            this.pnldewithdrawalpage.PerformLayout();
            this.pnldepositpage2.ResumeLayout(false);
            this.pnldepositpage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldewithdrawalpage;
        private System.Windows.Forms.Label txtwithpagrawale;
        private System.Windows.Forms.Panel pnldepositpage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtsuccessfulmsg;
        private System.Windows.Forms.Label txtamounttodeposit;
        private System.Windows.Forms.Label txtenteraccountnumber;
    }
}