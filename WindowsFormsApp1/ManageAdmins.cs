using BankBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class ManageAdmins : Form
    {
        AdminINFO _Current_Admin;
        private DataTable _dataTable;
        private void RefreshAdminsList() 
        {
            try
            {
                _dataTable = BankBusinessLogic.GetAllAdmins();
                dgvAdmins.DataSource = _dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load admins data.\n" + ex.Message);
            }
        
        }
        private void RefreshAdminsListBySearch(String Text) 
        {
            try
            {
                DataView dv = _dataTable.DefaultView;
                if (String.IsNullOrWhiteSpace(Text))
                {
                    dgvAdmins.DataSource = dv;
                    dv.RowFilter = "";
                    return;
                }
                Text = Text.Replace("'","''");
                dv.RowFilter = $"FullName LIKE '%{Text}%' OR UserName LIKE '%{Text}%'";
                dgvAdmins.DataSource = dv;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load admins data.\n" + ex.Message);
            }
        }
        private int GetSelectedAdminID()
        {
            if (dgvAdmins.CurrentRow == null)
                return -1;

            return Convert.ToInt32(dgvAdmins.CurrentRow.Cells["AdminID"].Value);
        }
        private void DisplaySelectedAdminDetails(int AdminID) 
        {
            AdminINFO admin = BankBusinessLogic.FindAdminByID(AdminID);
            if (admin == null)
                return;
            lblSelectedFullNameValue.Text = admin.FullName;
            lblSelectedUsernameValue.Text = admin.UserName;
            if (admin.Role == 0)
                lblSelectedRoleValue.Text = "Admin";
            else
                lblSelectedRoleValue.Text = "Leader";

            if (File.Exists(admin.picturePath))
            {
                pbSelectedAdminImage.Image = Image.FromFile(admin.picturePath);
            }
        }
        public ManageAdmins(AdminINFO Current_Admin)
        {
            InitializeComponent();
            _Current_Admin = Current_Admin;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        
        }
        public void RemoveFromLocalDataTable(int adminID)
        {
            DataRow[] row = _dataTable.Select("AdminID= " + adminID);
            if (row.Length > 0)
            {
                _dataTable.Rows.Remove(row[0]);
                _dataTable.AcceptChanges();
            }
        }
        public void DeleteSelectedAdmin(int AdminID)
        {
            if (AdminID < 0)
            {
                MessageBox.Show("Please select real admin");
                return;
            }
            if (_Current_Admin.AdminID == AdminID)
            {
                MessageBox.Show("You cannot delete your Current Account");
                return;
            }
             DialogResult result= MessageBox.Show("Are you sure you want to delete this admin ?!", "Delete Admin", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            if (BankBusinessLogic.DeleteAdmin(AdminID))
            {
                RemoveFromLocalDataTable(AdminID);
                MessageBox.Show("Admin was deleted");

            }
            
            
        }
        private void EditAdmins_Load(object sender, EventArgs e)
        {
            RefreshAdminsList();
        }
        private void txtSearchAdmins_TextChanged(object sender, EventArgs e)
        {
            
                RefreshAdminsListBySearch(txtSearchAdmins.Text);
          
        }
        public void UpdateAdminInLocalTable(int AdminID,String FullName,String UserName,int Role,String PicturePath) 
        {
            DataRow[] rows = _dataTable.Select("AdminID= " + AdminID);

            if (rows.Length == 0)
                return;
            DataRow row = rows[0];
            row["FullName"] = FullName;
            row["UserName"] = UserName;
            row["PicturePath"] = PicturePath;
            row["Role"] = Role;
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = GetSelectedAdminID();    
            if (ID > 0)
            {
                
                Form EditForm = new EditForm(ID);
                EditForm.ShowDialog();
                AdminINFO admin = BankBusinessLogic.FindAdminByID(ID);
                UpdateAdminInLocalTable(ID,admin.FullName,admin.UserName,admin.Role,admin.picturePath);


            }
            else
                MessageBox.Show("please selecet an admin");
        }
        private void dgvAdmins_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0) 
            {
                dgvAdmins.ClearSelection();
                dgvAdmins.Rows[e.RowIndex].Selected = true;
                dgvAdmins.CurrentCell = dgvAdmins.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedAdmin(GetSelectedAdminID());
        }
        private void btnMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvAdmins_SelectionChanged(object sender, EventArgs e)
        {
            DisplaySelectedAdminDetails(GetSelectedAdminID());
        }

    }
}
