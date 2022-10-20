using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstBankApp
{
    public partial class AccountDetailsPage : Form
    {
        AccountDetails accountDetails = new AccountDetails();
        private string Balance = null;
        private string FullName = null;
        private string AccountType = null;
        private string AccountNumber = null;


        public AccountDetailsPage(string balance, string fullname, string accounttype, string accountnumber)
        {
            this.Balance = balance;
            this.FullName = fullname;
            this.AccountType = accounttype;
            this.AccountNumber = accountnumber;
        }
        
       
        public AccountDetailsPage()
        {
            InitializeComponent();
        }

        private void AccountDetailsPage_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btn_accntdetailspage_Click(object sender, EventArgs e)
        {
            TransactionPage transactionPage = new TransactionPage();
            transactionPage.Show();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt1accounttype_Click(object sender, EventArgs e)
        {

        }

        private void txtaccountownername_Click(object sender, EventArgs e)
        {
            
        }

        private void txt1accountnumber_Click(object sender, EventArgs e)
        {

        }

        private void txt1balance_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlsection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_clicktoviewdetails_Click(object sender, EventArgs e)
        {
            txt1accounttype.Text = "Savings Account"; //+ txt1accounttype.Text;
            txt1accountnumber.Text = "1714567123 "; //+ txt1accountnumber.Text;
            txtaccountownername.Text = "Salami Waris Olaniyi"; //+ txtaccountownername;
            txt1balance.Text = "20,000"; //+ txt1balance.Text;

        }
    }
}
