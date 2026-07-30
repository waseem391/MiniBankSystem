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
    public partial class Clients : Form
    {
        AdminINFO _Current_admin = new AdminINFO();
        DataTable _dataTable = new DataTable();
        private void RefreshClientsList()
        {
            try
            {
                _dataTable = BankBusinessLogic.GetAllClients();
                dgvClients.DataSource = _dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Clients data.\n" + ex.Message);
            }

        }
        public Clients(AdminINFO admin)
        {
            InitializeComponent();
            _Current_admin = admin;
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            RefreshClientsList();
        }

    }
}
