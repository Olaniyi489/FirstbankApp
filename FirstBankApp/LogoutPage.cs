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
    public partial class LogoutPage : Form
    {
        public LogoutPage()
        {
            InitializeComponent();
        }

        private void btnsetupaccount_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Set Up New User Account Number");
        }
    }
}
