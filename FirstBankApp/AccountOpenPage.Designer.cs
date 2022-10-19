namespace FirstBankApp
{
    partial class AccountOpenPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtselectaccounttype = new System.Windows.Forms.Label();
            this.congrats = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.back_to_transaction = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.account_no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Opening Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Initial Amount";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(324, 146);
            this.amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(506, 26);
            this.amount.TabIndex = 2;
            this.amount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "1. Personal Current Account",
            "2. Savings Account",
            "3. Corporate Account"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. Personal Current Account",
            "2. Savings Account",
            "3. Corporate Current Account"});
            this.comboBox1.Location = new System.Drawing.Point(324, 265);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(506, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtselectaccounttype
            // 
            this.txtselectaccounttype.AutoSize = true;
            this.txtselectaccounttype.Location = new System.Drawing.Point(84, 275);
            this.txtselectaccounttype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtselectaccounttype.Name = "txtselectaccounttype";
            this.txtselectaccounttype.Size = new System.Drawing.Size(155, 20);
            this.txtselectaccounttype.TabIndex = 4;
            this.txtselectaccounttype.Text = "Select Account Type";
            this.txtselectaccounttype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // congrats
            // 
            this.congrats.AutoSize = true;
            this.congrats.Location = new System.Drawing.Point(80, 407);
            this.congrats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.congrats.Name = "congrats";
            this.congrats.Size = new System.Drawing.Size(417, 20);
            this.congrats.TabIndex = 5;
            this.congrats.Text = "Congratulations!  Account Number Generated Succesfully";
            this.congrats.Click += new System.EventHandler(this.congrats_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 451);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Your Account Number is : ";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(452, 331);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(202, 40);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // back_to_transaction
            // 
            this.back_to_transaction.Location = new System.Drawing.Point(70, 21);
            this.back_to_transaction.Name = "back_to_transaction";
            this.back_to_transaction.Size = new System.Drawing.Size(80, 31);
            this.back_to_transaction.TabIndex = 8;
            this.back_to_transaction.Text = "Back";
            this.back_to_transaction.UseVisualStyleBackColor = true;
            this.back_to_transaction.Click += new System.EventHandler(this.back_to_transaction_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 10;
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(552, 74);
            this.user_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(0, 20);
            this.user_name.TabIndex = 11;
            this.user_name.Click += new System.EventHandler(this.user_name_Click);
            // 
            // account_no
            // 
            this.account_no.AutoSize = true;
            this.account_no.Location = new System.Drawing.Point(281, 451);
            this.account_no.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.account_no.Name = "account_no";
            this.account_no.Size = new System.Drawing.Size(67, 20);
            this.account_no.TabIndex = 12;
            this.account_no.Text = " 020000";
            this.account_no.Click += new System.EventHandler(this.account_no_Click);
            // 
            // AccountOpenPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 496);
            this.Controls.Add(this.account_no);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back_to_transaction);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.congrats);
            this.Controls.Add(this.txtselectaccounttype);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Location = new System.Drawing.Point(291, 123);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountOpenPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AccountOpenPage";
            this.Load += new System.EventHandler(this.AccountOpenPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txtselectaccounttype;
        private System.Windows.Forms.Label congrats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button back_to_transaction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label account_no;
    }
}