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
    public partial class AccountStatementPage : Form
    {
        UserRegistration userRegistration;
        User user;
        public AccountStatementPage(UserRegistration userRegistration, User user)
        {
            InitializeComponent();
            this.userRegistration = userRegistration;
            this.user = user;

        }

        public void ToGetStatement()
        {
            List<Transaction> list = userRegistration.TransactionList; // List<string> 
            Transaction userTransaction = null;
            var accountNo = user.AccountNumber;

            if (list != null)
            {

                if (accountNo != null || accountNo != "")
                {
                    foreach (Transaction transaction in list)
                    {
                        if (transaction.GetAccountNumber() == accountNo)
                        {
                            userTransaction = transaction;
                        }
                    }

                    if (userTransaction != null)
                    {

                        Stack<Balance> balanceoutput = userTransaction.GetBalances();
                        Stack<Deposit> depositoutput = userTransaction.GetDeposits();
                        Stack<Withdrawal> withdrawaloutput = userTransaction.GetWithdrawals();

                        if (balanceoutput.Count == 0)
                        {
                            lbl_amount1.Text = "";
                            lbl_amount2.Text = "";
                        }
                        else if (balanceoutput.Count == 1)
                        {
                            lbl_amount2.Text = "";
                            lbl_deposit1.Text = depositoutput.Peek().Amount.ToString();
                            lbl_balance1.Text = balanceoutput.Peek().Amount.ToString();
                            lbl_withdrawal2.Text = withdrawaloutput.Peek().Amount.ToString();



                        }
                        else
                        {
                            var bln = balanceoutput.Peek();
                            var bln_dp = depositoutput.Peek();
                            var bln_wth = withdrawaloutput.Peek();

                            lbl_amount2.Text = "Amount";
                            lbl_deposit1.Text = depositoutput.Peek().Amount.ToString();
                            lbl_balance1.Text = balanceoutput.Peek().Amount.ToString();
                            lbl_withdrawal2.Text = withdrawaloutput.Peek().Amount.ToString();

                            balanceoutput.Pop();
                            depositoutput.Pop();
                            withdrawaloutput.Pop();


                            lbl_deposit2.Text = depositoutput.Peek().Amount.ToString();
                            lbl_balance2.Text = balanceoutput.Peek().Amount.ToString();
                            lbl_withdrawal2.Text = withdrawaloutput.Peek().Amount.ToString();

                            balanceoutput.Push(bln);
                            depositoutput.Push(bln_dp);
                            withdrawaloutput.Push(bln_wth);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Account Number");
                    }
                }
                else
                {
                    MessageBox.Show("Account is empty");
                }
            }

        }

        private void txtdate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AccountStatementPage_Load(object sender, EventArgs e)
        {

        }

        private void btn_getstatement_Click(object sender, EventArgs e)
        {
            ToGetStatement();
        }
    }
}
