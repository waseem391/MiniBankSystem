using BankBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankBusiness.BankBusinessLogic;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private AdminINFO _Current_Admin;
        private String _selectedImagePath = "";
        private void EnterEditProfileMode() 
        {
            pnlContent.Visible = false;


            btnLogout.Visible = false;
            btnEditProfile.Visible = false;
            btnEditAdmin.Visible = false;
            btnAddAdmin.Visible = false;
            

            btnEditPicture.Visible = true;
            btnSaveChanges.Visible = true;
            btnCancelChanges.Visible = true;

            txtUNameVal.ReadOnly = false;

        }
        private void ExitEditProfileMode() 
        {
            pnlContent.Visible = true;


            btnLogout.Visible = true;
            btnEditProfile.Visible = true;

            ApplyLeaderPermissions(_Current_Admin);


            btnEditPicture.Visible = false;
            btnSaveChanges.Visible = false;
            btnCancelChanges.Visible = false;     


            txtUNameVal.ReadOnly = true;

            DisplayCurrentAdminInfo(_Current_Admin);

        }
        private void DisplayCurrentAdminInfo(AdminINFO Current_Admin)
        {
            lblAdminName.Text = Current_Admin.UserName;
            lblFullNameVal.Text = Current_Admin.FullName;
            lblPanelName.Text = Current_Admin.FullName.Split(' ')[0] + " Admin";
            txtUNameVal.Text = Current_Admin.UserName;

            if (File.Exists(Current_Admin.picturePath))
            {
                pictureBox1.Image = Image.FromFile(Current_Admin.picturePath);
            }
        }
        public void ApplyLeaderPermissions(AdminINFO admin)
        {
            bool isLeader = BankBusinessLogic.HasFullPermissions(admin);
            ToggleLeaderControls(isLeader);
        }
        private void ToggleLeaderControls(bool isLeader)
        {
            btnAddAdmin.Visible = isLeader;
            btnEditAdmin.Visible = isLeader;
        }
        public MainForm(AdminINFO Current_Admin)
        {
            InitializeComponent();
            _Current_Admin = Current_Admin;
            
            
        } 
    
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?!!", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form frm = new LogIn();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            
        }
        private void btnAddAdmins_Click(object sender, EventArgs e)
        {
            Form frm = new SignIn();
            frm.ShowDialog();
        }

        private void btnEditAdmin_Click(object sender, EventArgs e)
        {
            Form editForm = new ManageAdmins(_Current_Admin);
            editForm.StartPosition = FormStartPosition.CenterParent;
            editForm.ShowDialog(this);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayCurrentAdminInfo(_Current_Admin);
            ApplyLeaderPermissions(_Current_Admin);
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EnterEditProfileMode();
        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            ExitEditProfileMode();

            
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            string userName = txtUNameVal.Text;
            string picturePath =_selectedImagePath;
            if (String.IsNullOrWhiteSpace(picturePath))
                picturePath = _Current_Admin.picturePath;
            if (BankBusinessLogic.EditAdminInfo(_Current_Admin.AdminID,_Current_Admin.FullName, userName,_Current_Admin.Role ,picturePath))
            {
                _Current_Admin.UserName = userName;
                _Current_Admin.picturePath = picturePath;
                MessageBox.Show("Profile updated successfully.");
                ExitEditProfileMode();

            }
            else 
            {
                MessageBox.Show("the user name is unavailable");
            }   
        }
        public String SaveAdminImage()
        {
            if (string.IsNullOrEmpty(_selectedImagePath))
                return "";
            string Pic = Path.Combine(Application.StartupPath, "Admin Image");
            if (!Directory.Exists(Pic))
                Directory.CreateDirectory(Pic);
            string imageName = Guid.NewGuid().ToString() + Path.GetExtension(_selectedImagePath);
            string destinationPath = Path.Combine(Pic, imageName);
            File.Copy(_selectedImagePath, destinationPath);
            return destinationPath;
        }
        private void btnEditPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select Admin Image";
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                _Current_Admin.picturePath = SaveAdminImage();
                _selectedImagePath = open.FileName;
                pictureBox1.Image = Image.FromFile(_selectedImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            Clients ClientForm = new Clients(_Current_Admin);
            ClientForm.StartPosition = FormStartPosition.CenterParent;
            ClientForm.ShowDialog(this);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit transaction = new Deposit(_Current_Admin);
            transaction.ShowDialog();
        }
    }
}
