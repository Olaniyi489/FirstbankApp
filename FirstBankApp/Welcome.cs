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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        SetUpUserAccount stacc = new SetUpUserAccount();
        private void label1_Click(object sender, EventArgs e)
        {
            stacc.MdiParent = this;
            stacc.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        txtLoginpage userLogin = new txtLoginpage();
        private void txtLogin_Click(object sender, EventArgs e)
        {
            userLogin.MdiParent = this;
            userLogin.Show();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
