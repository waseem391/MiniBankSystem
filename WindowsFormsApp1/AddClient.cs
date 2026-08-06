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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }
        private void AddNewClient(ClientINFO client) 
        {
            if (BankBusinessLogic.CreateClientAccount(client))
            {
                MessageBox.Show("Client Added successful");
                this.Close();
            }
            else
                MessageBox.Show("Error in entered information");
        }
 
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientINFO client = new ClientINFO();
            client.FullName = txtFullName.Text;
            client.NationalID = txtNationalID.Text;
            client.PhoneNumber = txtPhoneNumber.Text;
            client.BirthDate = dtpBirthDate.Value;
            AddNewClient(client);
            
            
            
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
