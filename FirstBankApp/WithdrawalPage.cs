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
    public partial class txtwithdrawalpage : Form
    {
        private UserRegistration registration = null;
        private User user = null;
        private string accountNumber;
        private string withDrawAmount;
        private bool shouldWithdraw = true;
        public txtwithdrawalpage()
        {
            InitializeComponent();
        }

        public txtwithdrawalpage(UserRegistration registration, User user)
        {
            InitializeComponent();
            this.registration = registration;
            this.user = user;
        }

        private void txtwithdrawalpage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsetupaccount_Click(object sender, EventArgs e)
        {//Submit
            if (accountNumber.Length < 10 || accountNumber.Length > 10 || withDrawAmount == "")
            {
                MessageBox.Show("Account number is less, more than 10 digits or withdrawl amount is empty");
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
                    if (double.TryParse(withDrawAmount, out double value))
                    {
                        double amountToWithdraw = double.Parse(withDrawAmount);
                        if (shouldWithdraw)
                        {
                            UpdateUserBalance(userTransaction, amountToWithdraw);
                        }

                    }
                    else
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

        public void UpdateUserBalance(Transaction transaction, double amountToWithdrwal)
        {
            Stack<Balance> balances = transaction.GetBalances();
            Stack<Withdrawal> withdrawals = transaction.GetWithdrawals();
            Stack<Deposit> deposits = transaction.GetDeposits();

            Withdrawal withdrawal = new Withdrawal(amountToWithdrwal);
            Deposit deposit = new Deposit(0.00);
            Balance balance = balances.Peek();
            double oldBalance = balance.Amount;

            if (oldBalance > amountToWithdrwal)
            {
                Balance newBalance = new Balance(oldBalance - amountToWithdrwal);
                transaction.SetDeposit(deposit);
                transaction.SetWithdrawal(withdrawal);
                transaction.SetBalance(newBalance);

                txtsuccessfulmsg.Text = "Hey yo! Amount Withdraw Successfully";
                shouldWithdraw = false;
            } else
            {//insufficient balance
                MessageBox.Show("Insufficient balance");
            }
        }

        private void back_transaction_page_Click(object sender, EventArgs e)
        {//back
            TransactionPage transactionPage = new TransactionPage(registration, user);
            transactionPage.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//Account number
            TextBox objTextBox = (TextBox)sender;
            accountNumber = objTextBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {//Amount to withdraw
            TextBox objTextBox = (TextBox)sender;
            withDrawAmount = objTextBox.Text;
        }

        private void pnldepositpage2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
