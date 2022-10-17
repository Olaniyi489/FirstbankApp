namespace FirstBankApp
{
    partial class txtdepositPage
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
            this.pnldepositpage2 = new System.Windows.Forms.Panel();
            this.txtenteraccountnumber = new System.Windows.Forms.Label();
            this.txtamounttodeposit = new System.Windows.Forms.Label();
            this.txtsuccessfulmsg = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnldepositpage.SuspendLayout();
            this.pnldepositpage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnldepositpage
            // 
            this.pnldepositpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnldepositpage.Controls.Add(this.label1);
            this.pnldepositpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnldepositpage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnldepositpage.Location = new System.Drawing.Point(210, 12);
            this.pnldepositpage.Name = "pnldepositpage";
            this.pnldepositpage.Size = new System.Drawing.Size(408, 43);
            this.pnldepositpage.TabIndex = 0;
            this.pnldepositpage.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Deposit Page";
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
            this.pnldepositpage2.Location = new System.Drawing.Point(114, 137);
            this.pnldepositpage2.Name = "pnldepositpage2";
            this.pnldepositpage2.Size = new System.Drawing.Size(636, 291);
            this.pnldepositpage2.TabIndex = 1;
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
            // txtamounttodeposit
            // 
            this.txtamounttodeposit.AutoSize = true;
            this.txtamounttodeposit.Location = new System.Drawing.Point(34, 134);
            this.txtamounttodeposit.Name = "txtamounttodeposit";
            this.txtamounttodeposit.Size = new System.Drawing.Size(356, 18);
            this.txtamounttodeposit.TabIndex = 1;
            this.txtamounttodeposit.Text = "Please Enter Amount To Deposit to (Owner account)";
            // 
            // txtsuccessfulmsg
            // 
            this.txtsuccessfulmsg.AutoSize = true;
            this.txtsuccessfulmsg.Location = new System.Drawing.Point(214, 235);
            this.txtsuccessfulmsg.Name = "txtsuccessfulmsg";
            this.txtsuccessfulmsg.Size = new System.Drawing.Size(270, 18);
            this.txtsuccessfulmsg.TabIndex = 2;
            this.txtsuccessfulmsg.Text = "Hey yo! Amount Deposited Successfully";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 24);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(394, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 24);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdepositPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 496);
            this.Controls.Add(this.pnldepositpage2);
            this.Controls.Add(this.pnldepositpage);
            this.Location = new System.Drawing.Point(291, 123);
            this.Name = "txtdepositPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DepositPage";
            this.pnldepositpage.ResumeLayout(false);
            this.pnldepositpage.PerformLayout();
            this.pnldepositpage2.ResumeLayout(false);
            this.pnldepositpage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldepositpage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnldepositpage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtsuccessfulmsg;
        private System.Windows.Forms.Label txtamounttodeposit;
        private System.Windows.Forms.Label txtenteraccountnumber;
    }
}