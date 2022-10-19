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
        txtLoginpage userLogin = null;
        SetUpUserAccount stacc = null;
        public Welcome()
        {
            InitializeComponent();
            userLogin = new txtLoginpage();
            stacc = new SetUpUserAccount();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {
            //stacc.MdiParent = this;
            stacc.Show();
            this.Hide();
            //Application.ExitThread();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void txtLogin_Click(object sender, EventArgs e)
        {
            //userLogin.MdiParent = this;
            userLogin.Show();
            this.Hide();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
