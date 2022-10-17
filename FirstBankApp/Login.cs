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
    public partial class txtLoginpage : Form
    {
        private string myTextBox1 = "";
        private string myTextBox2 = "";

        public txtLoginpage()
        {
            InitializeComponent();
        }

        private void txtlogin_Click(object sender, EventArgs e)
        {
            TransactionPage TrxnPage = new TransactionPage();
            if (myTextBox1 == "" || myTextBox2 == "")
            {
                MessageBox.Show("Kindly enter your email and password");
            }
            else
            {
                TrxnPage.Show();
            }
            
        }

        private void Logi_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            myTextBox1 = objTextBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            myTextBox2 = objTextBox.Text;
        }
    }
}
