using BankBusiness;
using BankModels;
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
        private int GetSelectedClientID() 
        {
            if (dgvClients.CurrentRow == null)
                return -1;
            return Convert.ToInt32(dgvClients.CurrentRow.Cells["UserID"].Value);
        }
        private void DisplaySelectedClientDetails(int UserID) 
        {
            if (UserID == -1)
                return;
            ClientINFO client = new ClientINFO();
            client = BankBusinessLogic.FindClientByID(UserID);
            lblFullNameval.Text = client.FullName;
            lblNationalIDVal.Text = client.NationalID;
            lblPhoneNumberVal.Text = client.PhoneNumber;
            lblBankAccountVal.Text = client.BankAccountNumber;
            lblAmountVal.Text = $"{client.Balance:N2} JOD";
        }
        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            DisplaySelectedClientDetails(GetSelectedClientID());
        }

        private void pnlClientInfo_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RefreshClientsListBySearch(String text) 
        {
            DataView dataView = _dataTable.DefaultView;
            try
            {
                if (String.IsNullOrEmpty(text)) 
                {
                    dgvClients.DataSource = dataView;
                    dataView.RowFilter= "";
                    return;
                }
                text = text.Replace("'","''");
                dataView.RowFilter = $"FullName LIKE '%{text}%'";
                dgvClients.DataSource = dataView;

            }
            catch (Exception ex) 
            {
                MessageBox.Show("error ///"+ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RefreshClientsListBySearch(tbsearch.Text);
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
