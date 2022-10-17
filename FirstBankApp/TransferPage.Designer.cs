namespace FirstBankApp
{
    partial class TransferPage
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
            this.txttransferpage = new System.Windows.Forms.Label();
            this.pnldepositpage2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtsuccessfulmsg = new System.Windows.Forms.Label();
            this.txtreceivertransferaccountnumber = new System.Windows.Forms.Label();
            this.txtsendertransferaccountnumber = new System.Windows.Forms.Label();
            this.txtamounttotransfer = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pnldepositpage.SuspendLayout();
            this.pnldepositpage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnldepositpage
            // 
            this.pnldepositpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnldepositpage.Controls.Add(this.txttransferpage);
            this.pnldepositpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnldepositpage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnldepositpage.Location = new System.Drawing.Point(238, 34);
            this.pnldepositpage.Name = "pnldepositpage";
            this.pnldepositpage.Size = new System.Drawing.Size(408, 43);
            this.pnldepositpage.TabIndex = 3;
            // 
            // txttransferpage
            // 
            this.txttransferpage.AutoSize = true;
            this.txttransferpage.Location = new System.Drawing.Point(60, 12);
            this.txttransferpage.Name = "txttransferpage";
            this.txttransferpage.Size = new System.Drawing.Size(288, 18);
            this.txttransferpage.TabIndex = 0;
            this.txttransferpage.Text = "Welcome To Your Account  Transfer Page";
            // 
            // pnldepositpage2
            // 
            this.pnldepositpage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnldepositpage2.Controls.Add(this.textBox3);
            this.pnldepositpage2.Controls.Add(this.txtamounttotransfer);
            this.pnldepositpage2.Controls.Add(this.textBox2);
            this.pnldepositpage2.Controls.Add(this.textBox1);
            this.pnldepositpage2.Controls.Add(this.txtsuccessfulmsg);
            this.pnldepositpage2.Controls.Add(this.txtreceivertransferaccountnumber);
            this.pnldepositpage2.Controls.Add(this.txtsendertransferaccountnumber);
            this.pnldepositpage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnldepositpage2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnldepositpage2.Location = new System.Drawing.Point(82, 120);
            this.pnldepositpage2.Name = "pnldepositpage2";
            this.pnldepositpage2.Size = new System.Drawing.Size(745, 291);
            this.pnldepositpage2.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(337, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 24);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 24);
            this.textBox1.TabIndex = 3;
            // 
            // txtsuccessfulmsg
            // 
            this.txtsuccessfulmsg.AutoSize = true;
            this.txtsuccessfulmsg.Location = new System.Drawing.Point(234, 259);
            this.txtsuccessfulmsg.Name = "txtsuccessfulmsg";
            this.txtsuccessfulmsg.Size = new System.Drawing.Size(258, 18);
            this.txtsuccessfulmsg.TabIndex = 2;
            this.txtsuccessfulmsg.Text = "Hey yo! Amount Transfer Successfully";
            // 
            // txtreceivertransferaccountnumber
            // 
            this.txtreceivertransferaccountnumber.AutoSize = true;
            this.txtreceivertransferaccountnumber.Location = new System.Drawing.Point(34, 118);
            this.txtreceivertransferaccountnumber.Name = "txtreceivertransferaccountnumber";
            this.txtreceivertransferaccountnumber.Size = new System.Drawing.Size(280, 18);
            this.txtreceivertransferaccountnumber.TabIndex = 1;
            this.txtreceivertransferaccountnumber.Text = "Please Enter Receiver\'s Account Number";
            // 
            // txtsendertransferaccountnumber
            // 
            this.txtsendertransferaccountnumber.AutoSize = true;
            this.txtsendertransferaccountnumber.Location = new System.Drawing.Point(34, 41);
            this.txtsendertransferaccountnumber.Name = "txtsendertransferaccountnumber";
            this.txtsendertransferaccountnumber.Size = new System.Drawing.Size(269, 18);
            this.txtsendertransferaccountnumber.TabIndex = 0;
            this.txtsendertransferaccountnumber.Text = "Please Enter Sender\'s Account Number";
            // 
            // txtamounttotransfer
            // 
            this.txtamounttotransfer.AutoSize = true;
            this.txtamounttotransfer.Location = new System.Drawing.Point(34, 186);
            this.txtamounttotransfer.Name = "txtamounttotransfer";
            this.txtamounttotransfer.Size = new System.Drawing.Size(228, 18);
            this.txtamounttotransfer.TabIndex = 5;
            this.txtamounttotransfer.Text = "Please Enter Amount To Transfer";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(337, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(347, 24);
            this.textBox3.TabIndex = 6;
            // 
            // TransferPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 496);
            this.Controls.Add(this.pnldepositpage2);
            this.Controls.Add(this.pnldepositpage);
            this.Location = new System.Drawing.Point(291, 123);
            this.Name = "TransferPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TransferPage";
            this.pnldepositpage.ResumeLayout(false);
            this.pnldepositpage.PerformLayout();
            this.pnldepositpage2.ResumeLayout(false);
            this.pnldepositpage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldepositpage;
        private System.Windows.Forms.Label txttransferpage;
        private System.Windows.Forms.Panel pnldepositpage2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtamounttotransfer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtsuccessfulmsg;
        private System.Windows.Forms.Label txtreceivertransferaccountnumber;
        private System.Windows.Forms.Label txtsendertransferaccountnumber;
    }
}