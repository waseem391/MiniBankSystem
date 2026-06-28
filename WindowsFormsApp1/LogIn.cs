using BankBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankBusiness.BankBusinessLogic;

namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
       
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (BankBusinessLogic.TryToLogin(txtUserName.Text, txtpassword.Text))
            {
                AdminINFO Current_Admin = BankBusinessLogic.TryTogetAdminInfo(txtUserName.Text);
                Form frm = new MainForm(Current_Admin);
                this.Hide();
                frm.ShowDialog();
                this.Close();

            }
            else
            {  
                MessageBox.Show("User Name or Password not found");
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
