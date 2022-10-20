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
using System.Text.RegularExpressions;
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

        private static bool PerformRegEx(string pattern, string value)
        {
            Regex re = new Regex(pattern);


            if (re.IsMatch(value))
                return (true);
            else
                return (false);
        }

        private void txtfullname_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            fullName = objTextBox.Text;
        }
        public bool CheckName(string fullname)
        {
            string strRegex = @"^[A-Z]";

            return PerformRegEx(strRegex, fullname);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            email = objTextBox.Text;
        }
        public bool CheckEmail(string email)
        {
            string strRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return PerformRegEx(strRegex, email);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            password = objTextBox.Text;
        }
        public bool CheckPassword(string password)
        {
            string strRegex = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$";
            return PerformRegEx(strRegex, password);
        }

        private void btnsetupaccount_Click(object sender, EventArgs e)
        {
            if (CheckName(fullName) != true || CheckEmail(email) != true || CheckPassword(password) != true)
            {
                MessageBox.Show("Kindly enter your details in this format Name \"Waris Salami\": Email \"Wareez@gmail.com\" : password \"Elephant20**\"");
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
