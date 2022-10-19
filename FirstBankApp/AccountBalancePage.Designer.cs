namespace FirstBankApp
{
    partial class txtAccountBalancePage
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
            this.txtenteryouraccountnumber = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_check_balance = new System.Windows.Forms.Button();
            this.show_balance = new System.Windows.Forms.Label();
            this.back_to_transaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Your Account Balance Page";
            // 
            // txtenteryouraccountnumber
            // 
            this.txtenteryouraccountnumber.AutoSize = true;
            this.txtenteryouraccountnumber.Location = new System.Drawing.Point(69, 106);
            this.txtenteryouraccountnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtenteryouraccountnumber.Name = "txtenteryouraccountnumber";
            this.txtenteryouraccountnumber.Size = new System.Drawing.Size(217, 16);
            this.txtenteryouraccountnumber.TabIndex = 1;
            this.txtenteryouraccountnumber.Text = "Please Enter Your Account Number";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Navy;
            this.textBox1.Location = new System.Drawing.Point(385, 96);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Balance : ";
            // 
            // btn_check_balance
            // 
            this.btn_check_balance.Location = new System.Drawing.Point(527, 147);
            this.btn_check_balance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_check_balance.Name = "btn_check_balance";
            this.btn_check_balance.Size = new System.Drawing.Size(171, 35);
            this.btn_check_balance.TabIndex = 6;
            this.btn_check_balance.Text = "Submit";
            this.btn_check_balance.UseVisualStyleBackColor = true;
            this.btn_check_balance.Click += new System.EventHandler(this.btn_check_balance_Click);
            // 
            // show_balance
            // 
            this.show_balance.AutoSize = true;
            this.show_balance.Location = new System.Drawing.Point(154, 314);
            this.show_balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.show_balance.Name = "show_balance";
            this.show_balance.Size = new System.Drawing.Size(38, 16);
            this.show_balance.TabIndex = 7;
            this.show_balance.Text = "0.000";
            // 
            // back_to_transaction
            // 
            this.back_to_transaction.Location = new System.Drawing.Point(38, 21);
            this.back_to_transaction.Name = "back_to_transaction";
            this.back_to_transaction.Size = new System.Drawing.Size(81, 29);
            this.back_to_transaction.TabIndex = 10;
            this.back_to_transaction.Text = "Back";
            this.back_to_transaction.UseVisualStyleBackColor = true;
            this.back_to_transaction.Click += new System.EventHandler(this.back_to_transaction_Click);
            // 
            // txtAccountBalancePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 575);
            this.Controls.Add(this.back_to_transaction);
            this.Controls.Add(this.show_balance);
            this.Controls.Add(this.btn_check_balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtenteryouraccountnumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Location = new System.Drawing.Point(291, 123);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "txtAccountBalancePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AccountBalancePage";
            this.Load += new System.EventHandler(this.txtAccountBalancePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtenteryouraccountnumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_check_balance;
        private System.Windows.Forms.Label show_balance;
        private System.Windows.Forms.Button back_to_transaction;
    }
}