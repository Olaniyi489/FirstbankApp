using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstBankApp
{
    public partial class txtAccountBalancePage : Form
    {
        private string accountNumber = "";
        private UserRegistration registration = null;
        private User user = null;
        public txtAccountBalancePage()
        {
            InitializeComponent();
        }

        public txtAccountBalancePage(UserRegistration registration, User user)
        {
            InitializeComponent();
            this.registration = registration;
            this.user = user;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAccountBalancePage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//AccountNumber
            TextBox objTextBox = (TextBox)sender;
            accountNumber = objTextBox.Text;
        }

        private void btn_check_balance_Click(object sender, EventArgs e)
        {//submit check balance
            if (accountNumber.Length < 10 || accountNumber.Length > 10)
            {
                MessageBox.Show("Account number is less or more than 10 digits");
            } else
            {
                List<Transaction> list = registration.TransactionList;
                Transaction userTransaction = null;
                int listSize = list.Capacity;

                if (listSize == 0)
                {
                    MessageBox.Show("Invalid Account Number");
                } else
                {
                    foreach (Transaction transaction in list)
                    {
                        if (transaction.GetAccountNumber() == accountNumber)
                        {
                            userTransaction = transaction;
                        }
                    }

                    if (userTransaction != null)
                    {
                        GetUserBalance(userTransaction);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account Number");
                    }
                }
                
            }
        }

        private void GetUserBalance(Transaction transaction)
        {
            Stack<Balance> balances = transaction.GetBalances();
            Balance balance = balances.Peek();
            double amount = balance.Amount;
            show_balance.Text = amount.ToString();
        }

        private void back_to_transaction_Click(object sender, EventArgs e)
        {
            TransactionPage transactionPage = new TransactionPage(registration, user);
            transactionPage.Show();
            this.Close();
        }
    }
}
