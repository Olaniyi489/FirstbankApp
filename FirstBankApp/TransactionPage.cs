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
    public partial class TransactionPage : Form
    {
        AccountOpenPage newAccount = null;
        txtAccountBalancePage balance = null;
        txtdepositPage depositPage = null;
        txtwithdrawalpage txtwithdrawalpage = null;
        AccountDetailsPage accountDetailsPage = null;
        AccountStatementPage accountStatementPage = null;
        TransferPage transferPage = null;
        LogoutPage logoutPage = null;

        private UserRegistration registration = null;

        public TransactionPage()
        {
            InitializeComponent();
        }

        public TransactionPage(UserRegistration registration, User user)
        {
            InitializeComponent();
            this.registration = registration;
            user_name_.Text = user.FullName;
            balance = new txtAccountBalancePage(registration, user);
            depositPage = new txtdepositPage(registration, user);
            txtwithdrawalpage = new txtwithdrawalpage(registration, user);
            accountDetailsPage = new AccountDetailsPage();
            accountStatementPage = new AccountStatementPage();
            transferPage = new TransferPage();
            logoutPage = new LogoutPage();

            newAccount = new AccountOpenPage(registration, user);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {//Deposit
            //if (registration.TransactionList.)
            //{
            //    depositPage.Visible = false;
            //}
            //else
            //{
            //    depositPage.Visible = true;
            //    //depositPage.MdiParent = this;
            //    depositPage.Show();
            //    this.Close();
            //}
            depositPage.Visible = true;
            depositPage.Show();
            this.Close();
        }

        private void TransactionPage_Load(object sender, EventArgs e)
        {
           
        }
        
        private void btnsetupaccount_Click(object sender, EventArgs e)
        {//SetUpAccount
            //newAccount.MdiParent = this;
            newAccount.Show();
            this.Close();
        }
       
        private void txtcheckbalance_Click(object sender, EventArgs e)
        {//CheckBalance
            //if (newAccount.GetShouldSetUpAccount())
            //{
            //    balance.Visible = false;
            //}
            //else
            //{
            //    balance.Visible = true;
            //    //balance.MdiParent = this;
            //    balance.Show();
            //    this.Close();
            //} 
            balance.Visible = true;
            balance.Show();
            this.Close();
        }
       
        private void txtwithdrawal_Click(object sender, EventArgs e)
        {//Withdrawal
            //if (newAccount.GetShouldSetUpAccount())
            //{
            //    txtwithdrawalpage.Visible = false;
            //}
            //else
            //{
            //    txtwithdrawalpage.Visible = true;
            //    txtwithdrawalpage.MdiParent = this;
            //    txtwithdrawalpage.Show();
            //}
            txtwithdrawalpage.Visible = true;
            txtwithdrawalpage.Show();
            this.Close();
        }
        
        private void txtaccntdetails_Click(object sender, EventArgs e)
        {//AccountDetails
         //if (newAccount.GetShouldSetUpAccount())
         //{
         //    accountDetailsPage.Visible = false;
         //}
         //else
         //{
         //    accountDetailsPage.Visible = false;
         //    accountDetailsPage.MdiParent = this;
         //    accountDetailsPage.Show();
         //}
            accountDetailsPage.Visible = false;
            accountDetailsPage.Show();
            this.Close();
        }
        
        private void txtaccntstatement_Click(object sender, EventArgs e)
        {//AccountStatement
            //if (newAccount.GetShouldSetUpAccount())
            //{
            //    accountStatementPage.Visible = false;
            //}
            //else
            //{
            //    accountStatementPage.Visible = false;
            //    accountStatementPage.MdiParent = this;
            //    accountStatementPage.Show();
            //}
            accountStatementPage.Visible = false;
            accountStatementPage.Show();
            this.Close();
        }
        
        private void txttransfer_Click(object sender, EventArgs e)
        {//Transfer
            //if (newAccount.GetShouldSetUpAccount())
            //{
            //    transferPage.Visible = false;
            //}
            //else
            //{
            //    transferPage.Visible = false;
            //    transferPage.MdiParent = this;
            //    transferPage.Show();
            //}
            transferPage.Visible = false;
            transferPage.Show();
            this.Close();
        }
       
        private void txtlogout_Click(object sender, EventArgs e)
        {//Logout
            //logoutPage.MdiParent = this;
           Welcome welcome = new Welcome();
           welcome.Show();
           this.Close();
        }
    }
}
