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

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
                AdminINFO Current_Admin = BankBusinessLogic.TryTogetAdminInfo(txtUserName.Text);
            if (Current_Admin == null) 
            {
                MessageBox.Show("User Name not found");
                return;
            }
            if (txtpassword.Text == Current_Admin.Password)
                {

                    Form frm = new MainForm(Current_Admin);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show(" Password not correct");
                }
           
                

        }

    }
}
