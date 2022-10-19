using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace FirstBankApp
{
    public partial class SetUpUserAccount : Form
    {
        List<UserRegistration> registrations = new List<UserRegistration>();
        string fullName = "";
        string email = "";
        string password = "";
        public SetUpUserAccount()
        {
            InitializeComponent();
        }

        private void txtfullname_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            fullName = objTextBox.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            email = objTextBox.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            password = objTextBox.Text;
        }

        private void btnsetupaccount_Click(object sender, EventArgs e)
        {
            if (fullName == "" || email == "" || password == "")
            {
                MessageBox.Show("Kindly enter your fullname, email and password");
            }
            else
            {
                UserRegistration registration = new UserRegistration();
                User user = new User(fullName, email, password);
                List<User> users = new List<User>();
                users.Add(user);
                registration.users = users;
                registrations.Add(registration);
                txtLoginpage loginpage = new txtLoginpage(registrations);
                loginpage.Show();
                this.Close();

                try
                {
                    var userJson = JsonConvert.SerializeObject(user);

                    File.AppendAllText(@"UserDataInJson.json", userJson);

                    MessageBox.Show("registration was succesful");
                        
                       
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Wrong input");
                }
            }
        }

        private void SetUpUserAccount_Load(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Close();
        }
    }
}
