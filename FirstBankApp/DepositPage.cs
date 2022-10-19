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
    public partial class txtdepositPage : Form
    {
        private UserRegistration registration = null;
        private User user = null;
        private string accountNumber = "";
        private string amount = "";
        private bool shouldDeposit = true;
        public txtdepositPage()
        {
            InitializeComponent();
        }

        public txtdepositPage(UserRegistration registration, User user)
        {
            InitializeComponent();
            this.registration = registration;
            this.user = user;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {//Amount
            TextBox objTextBox = (TextBox)sender;
            amount = objTextBox.Text;
        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            if (accountNumber.Length < 10 || accountNumber.Length > 10 || amount == "")
            {
                MessageBox.Show("Account number is less, more than 10 digits or amount is empty");
            }
            else
            {
                List<Transaction> list = registration.TransactionList;
                Transaction userTransaction = null;
                foreach (Transaction transaction in list)
                {
                    if (transaction.GetAccountNumber() == accountNumber)
                    {
                        userTransaction = transaction;
                    }
                }

                if (userTransaction != null)
                {
                    if (double.TryParse(amount, out double value))
                    {
                        double amountToDeposit = double.Parse(amount);
                        if (shouldDeposit)
                        {
                            UpdateUserBalance(userTransaction, amountToDeposit);
                            shouldDeposit = false;
                        }

                    } else
                    {
                        MessageBox.Show("Enter amount in numbers");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Account Number");
                }
            }
        }

        public void UpdateUserBalance(Transaction transaction, double amountToDeposit)
        {
            Stack<Balance> balances = transaction.GetBalances();
            Stack<Withdrawal> withdrawals = transaction.GetWithdrawals();
            Stack<Deposit> deposits = transaction.GetDeposits();

            Withdrawal withdrawal = new Withdrawal(0.00);
            Deposit deposit = new Deposit(amountToDeposit);
            Balance balance = balances.Peek();
            double oldBalance = balance.Amount;
            Balance newBalance = new Balance(amountToDeposit + oldBalance);

            transaction.SetDeposit(deposit);
            transaction.SetWithdrawal(withdrawal);
            transaction.SetBalance(newBalance);

            txtsuccessfulmsg.Text = "Hey yo! Amount Deposited Successfully";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//Account number
            TextBox objTextBox = (TextBox)sender;
            accountNumber = objTextBox.Text;
        }

        private void back_to_transaction_Click(object sender, EventArgs e)
        {
            TransactionPage transactionPage = new TransactionPage(registration, user);
            transactionPage.Show();
            this.Close();
        }

        private void pnldepositpage2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
