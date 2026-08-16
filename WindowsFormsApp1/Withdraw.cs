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
    public partial class Withdraw : Form
    {
        private ClientINFO _client = new ClientINFO();
        private AdminINFO _Current_Admin;
        public Withdraw(AdminINFO admin)
        {
            InitializeComponent();
            _Current_Admin = admin;
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = "Admin " + _Current_Admin.FullName;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Please enter National ID.");
                ClearClientData();
                txtSearch.Focus();
                return;
            }
            _client = BankBusinessLogic.FindClientByNationalID(txtSearch.Text);
            if (_client == null)
            {
                MessageBox.Show("Client not found.");
                ClearClientData();
                txtSearch.Focus();
                return;
            }
            FillClientData(_client);
        }
        private void FillClientData(ClientINFO client)
        {

            lblName.Text = client.FullName;
            lblPhone.Text =  client.PhoneNumber;
            lblNationalID.Text = client.NationalID;
            lblAccountNumber.Text = client.BankAccountNumber;
            lblBalance.Text = $"Balance: {client.Balance:N2} JD";
        }
        private void ClearClientData()
        {
            lblName.Text = "";
            lblPhone.Text = "";
            lblNationalID.Text = "";
            lblAccountNumber.Text = "";
            lblBalance.Text = "Balance: ";
            _client = null;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal Amount;
            Decimal.TryParse(txtAmount.Text, out Amount);
            DialogResult result = MessageBox.Show("Are you sure you want to withdraw from this Account?!", "Important message!!!",MessageBoxButtons.YesNo);
            if (_client == null) 
            {
                MessageBox.Show("Please Enter Bank Account TO Complete This Transaction");
                return;
            }
                
            if (result==DialogResult.Yes & BankBusinessLogic.WithdrawFromAccount(_client.UserID, Amount))
            {
                MessageBox.Show(_client.FullName.Substring(0, _client.FullName.IndexOf(" ") + 1) + " account balance has been updated");
                txtSearch.Text = _client.NationalID;
                _client = BankBusinessLogic.FindClientByNationalID(txtSearch.Text);
                FillClientData(_client);
                Transaction transaction = new Transaction();
                transaction.TransactionTypeID = 2;
                transaction.AmountOfTransaction = Amount;
                transaction.BankAccountID = _client.BankAccountID;
                transaction.Note = $"Withdraw {Amount} JD by {_Current_Admin.FullName}";
                BankBusinessLogic.AddTransaction(transaction);
                txtAmount.Text = "";
            }
            else
                MessageBox.Show("please enter valid Amount");
        }
    }
}
