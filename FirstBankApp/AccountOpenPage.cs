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
    public partial class AccountOpenPage : Form
    {
        private static int accountNumberDefault  = 1012346783;
        private bool shouldSetUpAccountOnce = true;
        private string name;

        private string comboBoxValue = "";
        private string amountValue = "";

        private UserRegistration registration = null;
        private User user = null;
        public AccountOpenPage()
        {
            InitializeComponent();
        }

        public AccountOpenPage(UserRegistration registration, User user)
        {
            InitializeComponent();
            this.registration = registration;
            this.user = user;
            this.name = user.FullName;
            user_name.Text = name;
            congrats.Text = "";
            account_no.Text = "";
        }

        public void SetShouldSetUpAccount(Transaction transaction, bool shouldSetUpAccount)
        {
            transaction.SetShouldSetUpAccount(shouldSetUpAccount);
        }

        public bool GetShouldSetUpAccount(Transaction transaction)
        {
            return transaction.GetShouldSetUpAccount();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//select account type
            object b = comboBox1.SelectedItem;
            comboBoxValue = Convert.ToString(b);
        }

        private void AccountOpenPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//amount
            TextBox objTextBox = (TextBox)sender;
            amountValue = objTextBox.Text;
        }

        private void txtlogin_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(amountValue, out int value) || comboBoxValue != "")
            {
                int amount = int.Parse(amountValue);
                if(amount < 1000)
                {
                    MessageBox.Show("Kindly deposit at least #1000");
                } 
                else
                {
                    if (shouldSetUpAccountOnce)
                    {
                        int accNo = GenerateAccountNumber();
                        user.AccountNumber = accNo.ToString();
                        congrats.Text = "Congratulations!  Account Number Generated Succesfully";
                        account_no.Text = accNo.ToString();
                        setTransaction(accNo.ToString(), amount, registration);
                    }
                }
            } else
            {
                MessageBox.Show("Error in amount or Account type is empty");
            }

        }

        private void setTransaction(string accountNumber, int depositAmount, UserRegistration registration)
        {
            Transaction transaction = new Transaction(accountNumber);

            Deposit deposit = new Deposit(depositAmount);
            transaction.SetDeposit(deposit);
            Withdrawal withdrawal = new Withdrawal(0.00);
            transaction.SetWithdrawal(withdrawal);
            Balance balance = new Balance(depositAmount);
            transaction.SetBalance(balance);
            List<Transaction> transactions = new List<Transaction>();
            transactions.Add(transaction);
            registration.TransactionList = transactions;

            SetShouldSetUpAccount(transaction, false);
            shouldSetUpAccountOnce = false;
        }

        private int GenerateAccountNumber()
        {
            accountNumberDefault++;
            return accountNumberDefault;
        }

        private void back_to_transaction_Click(object sender, EventArgs e)
        {
            TransactionPage trssc = new TransactionPage(registration, user);
            trssc.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void user_name_Click(object sender, EventArgs e)
        {


        }

        private void congrats_Click(object sender, EventArgs e)
        {

        }

        private void account_no_Click(object sender, EventArgs e)
        {

        }
    }
}
