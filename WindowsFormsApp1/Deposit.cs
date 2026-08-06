using BankBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Deposit : Form
    {
        AdminINFO _Current_Admin;
        public Deposit(AdminINFO admin)
        {
            InitializeComponent();
            _Current_Admin = admin;
        }

        private void Deposit_Load_1(object sender, EventArgs e)
        {

        }
    }
}
