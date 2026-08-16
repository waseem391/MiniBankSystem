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
    public partial class Transfer : Form
    {
        private AdminINFO _Current_Admin;
        private ClientINFO SenderClient ;
        private ClientINFO ReceiverClient;
        public Transfer(AdminINFO admin)
        {
            InitializeComponent();
            _Current_Admin = admin;
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = _Current_Admin.FullName;
        }
        private void FillSenderClientData()
        {
            if (SenderClient == null) 
            {
                ClearSenderData();
                return;
            }
            lblFromName.Text = "Name: " + SenderClient.FullName;      
            lblFromAccount.Text = "Account : " + SenderClient.BankAccountNumber;
            lblFromBalance.Text = $"Balance: {SenderClient.Balance:N2} JD";
            switch (SenderClient.Status) 
            {
                case "Active":
                    lblFromStatus.Text = "● Account Active";
                    lblFromStatus.ForeColor = Color.Green;
                    break;
                case "Frozen":
                    lblFromStatus.Text = "● Account Frozen";
                    lblFromStatus.ForeColor = Color.Orange;
                    break;
                case "Closed":
                    lblFromStatus.Text = "● Account Closed";
                    lblFromStatus.ForeColor = Color.Red;
                    break;
            }
        }
        private void ClearSenderData()
        {
            lblFromAccount.Text = "Account Number: ";
            lblFromName.Text = "Name: ";
            lblFromBalance.Text = "Balance: ";
            SenderClient = null;
        }
        private void FillReceiverClientData()
        {
            if (ReceiverClient == null)
            {
                ClearReceiverData();
                return;
            }
            lblToName.Text = "Name: " + ReceiverClient.FullName;
            lblToAccount.Text = "Account Number: " + ReceiverClient.BankAccountNumber;
            switch (ReceiverClient.Status)
            {
                case "Active":
                    lblToStatus.Text = "● Account Active";
                    lblToStatus.ForeColor = Color.Green;
                    break;
                case "Frozen":
                    lblToStatus.Text = "● Account Frozen";
                    lblToStatus.ForeColor = Color.Orange;
                    break;
                case "Closed":
                    lblToStatus.Text = "● Account Closed";
                    lblToStatus.ForeColor = Color.Red;
                    break;
            }
        }
        private void ClearReceiverData()
        {
            lblToAccount.Text = "Account Number:.... ";
            lblToName.Text = "Name: ";
            ReceiverClient = null;
        }
        private void btnFromSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtFromSearch.Text)) 
            {
                MessageBox.Show("Please enter account number or national id");
                return;
            }
            SenderClient = BankBusinessLogic.FindClientByNationalID(txtFromSearch.Text);
            if (SenderClient == null)
            {
                MessageBox.Show("Client not found.");
                ClearSenderData();
                txtFromSearch.Focus();
                return;
            }
            FillSenderClientData();
        }

        private void btnToSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtFromSearch.Text))
            {
                MessageBox.Show("Please enter account number or national id");
                return;
            }
            ReceiverClient = BankBusinessLogic.FindClientByNationalID(txtToSearch.Text);
            if (ReceiverClient == null)
            {
                MessageBox.Show("Client not found.");
                ClearReceiverData();
                txtToSearch.Focus();
                return;
            }
            FillReceiverClientData();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            decimal Amount;
            int TransactionID;
            Decimal.TryParse(txtAmount.Text, out Amount);
            DialogResult result = MessageBox.Show("Are you sure you want to Transfer between this Accounts?!", "Important message!!!", MessageBoxButtons.YesNo);
            if (SenderClient == null || ReceiverClient == null)
            {
                MessageBox.Show("Please Enter Bank Accounts TO Complete This Transaction");
                return;
            }
            if (SenderClient.BankAccountID == ReceiverClient.BankAccountID) 
            {
                MessageBox.Show("You cannot transfer money to the same account. Please enter a valid receiver account.");
                txtToSearch.Focus();
                return;
            }
            if (result == DialogResult.Yes & BankBusinessLogic.TransferBetweenAcounts(SenderClient, ReceiverClient, Amount))
            {
                MessageBox.Show("The transfer process was successful.");
                Transaction transaction = new Transaction();
                transaction.TransactionTypeID = 3;
                transaction.AmountOfTransaction = Amount;
                transaction.BankAccountID = SenderClient.BankAccountID;
                transaction.Note = $"Transfer {Amount} JD From {SenderClient.BankAccountNumber} To {ReceiverClient.BankAccountNumber} by {_Current_Admin.FullName}";
                TransactionID = BankBusinessLogic.AddTransaction(transaction);
                TransferINFO transfer = new TransferINFO();
                transfer.TransactionID = TransactionID;
                transfer.SenderID = SenderClient.BankAccountID;
                transfer.ReceiverID = ReceiverClient.BankAccountID;
                BankBusinessLogic.AddTransfer(transfer);
                txtAmount.Text = "0.00";
                SenderClient = BankBusinessLogic.FindClientByNationalID(txtFromSearch.Text);
                FillSenderClientData();
            }
            else 
            {
                MessageBox.Show("The transfer was unsuccessful.");
            }

        }
    }
}
