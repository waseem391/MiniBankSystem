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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                dgvClients.Columns["UserID"].Visible = false;
                dgvClients.Columns["UserID1"].Visible = false;
                dgvClients.Columns["BankAccountID"].Visible = false;
                dgvClients.Columns["Balance"].Visible=false;
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
        private void DisplaySelectedClientDetails() 
        {
            if (dgvClients.CurrentRow == null)
                return;
            lblUserIDVal.Text = dgvClients.CurrentRow.Cells["UserID"].Value.ToString();
            lblFullNameval.Text = dgvClients.CurrentRow.Cells["FullName"].Value.ToString();
            lblNationalIDVal.Text = dgvClients.CurrentRow.Cells["NationalID"].Value.ToString();
            lblPhoneNumberVal.Text = dgvClients.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            lblBankAccountVal.Text = dgvClients.CurrentRow.Cells["BankAccountNumber"].Value.ToString();
            lblAmountVal.Text = dgvClients.CurrentRow.Cells["Balance"].Value.ToString()+" JOD";
        }
        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            DisplaySelectedClientDetails();
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

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.ShowDialog();
            RefreshClientsList();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {

            pnlDisabled.Visible = true;
            tbPhoneNumber.Text = lblPhoneNumberVal.Text;
            lblEditFullName.Text = lblFullNameval.Text;
            cbStatus.Text = dgvClients.CurrentRow.Cells["Status"].Value.ToString();
            btnAddClient.Visible = false;

        }
        private void SaveChanges() 
        {
            String NewPhoneNumber = tbPhoneNumber.Text;
            String NewStatus = cbStatus.Text;
            int UserID = Convert.ToInt32(lblUserIDVal.Text);

            if (BankBusinessLogic.SaveClientChanges(UserID, NewPhoneNumber, NewStatus))
                MessageBox.Show("The editing process was successful.");
            else
                MessageBox.Show("something went wrong!");
        }
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            pnlDisabled.Visible = false;
            btnAddClient.Visible = true;
            SaveChanges();
            RefreshClientsList();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            pnlDisabled.Visible = false;
            btnAddClient.Visible = true;
        }
    }
}
