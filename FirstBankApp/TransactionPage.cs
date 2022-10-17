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
        public TransactionPage()
        {
            InitializeComponent();
        }
        txtdepositPage depositPage = new txtdepositPage();
        private void button1_Click(object sender, EventArgs e)
        {
            
            depositPage.MdiParent = this;
            depositPage.Show();
        }

        private void TransactionPage_Load(object sender, EventArgs e)
        {

        }
        AccountOpenPage newAccount = new AccountOpenPage();
        private void btnsetupaccount_Click(object sender, EventArgs e)
        {
            newAccount.MdiParent = this;
            newAccount.Show();
        }
        txtAccountBalancePage balance = new txtAccountBalancePage();
        private void txtcheckbalance_Click(object sender, EventArgs e)
        {
            balance.MdiParent = this;
            balance.Show();
        }
        txtwithdrawalpage txtwithdrawalpage = new txtwithdrawalpage();
        private void txtwithdrawal_Click(object sender, EventArgs e)
        {
          
            txtwithdrawalpage.MdiParent = this;
            txtwithdrawalpage.Show();
        }
        AccountDetailsPage accountDetailsPage = new AccountDetailsPage();
        private void txtaccntdetails_Click(object sender, EventArgs e)
        {
           
            accountDetailsPage.MdiParent = this;
            accountDetailsPage.Show();
        }
        AccountStatementPage accountStatementPage = new AccountStatementPage();
        private void txtaccntstatement_Click(object sender, EventArgs e)
        {
            
            accountStatementPage.MdiParent = this;
            accountStatementPage.Show();
        }
        TransferPage transferPage = new TransferPage();
        private void txttransfer_Click(object sender, EventArgs e)
        {
            
            transferPage.MdiParent = this;
            transferPage.Show();
        }
        LogoutPage logoutPage = new LogoutPage();
        private void txtlogout_Click(object sender, EventArgs e)
        {
           
            logoutPage.MdiParent = this;
            logoutPage.Show();
        }
    }
}
