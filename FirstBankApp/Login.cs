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
        List<UserRegistration> registrations = null;

        public txtLoginpage()
        {
            InitializeComponent();
        }

        public txtLoginpage(List<UserRegistration> registrations)
        {
            InitializeComponent();
            this.registrations = registrations;
        }

        private void txtlogin_Click(object sender, EventArgs e)
        {
            if (registrations != null)
            {
                if (myTextBox1 == "" || myTextBox2 == "")
                {
                    MessageBox.Show("Kindly enter your email and password");
                }
                else
                {
                    UserRegistration userRegistration = null;
                    User user = null;
                    foreach (var registration in registrations)
                    {
                        user = registration.GetUser(myTextBox1, myTextBox2);
                        if (user != null)
                        {
                            userRegistration = registration;
                            break;
                        }
                    }

                    if (userRegistration == null)
                    {
                        MessageBox.Show("Email or Password is wrong.");
                    }

                    if (userRegistration != null)
                    {
                        TransactionPage TrxnPage = new TransactionPage(userRegistration, user);
                        TrxnPage.Show();
                        this.Close();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Kindly register before you login");
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

        private void home_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show(); 
            this.Close();
        }
    }
}
