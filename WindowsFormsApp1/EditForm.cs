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

namespace WindowsFormsApp1
{
    public partial class EditForm : Form
    {
        private AdminINFO _Current_Admin;
        public EditForm(int SelectedAdminID)
        {
            InitializeComponent();
              _Current_Admin=BankBusinessLogic.FindAdminByID(SelectedAdminID);
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
           
            lblManageAdmin.Text = "Manage Admin , ID= " + _Current_Admin.AdminID;
            txtFullName.Text = _Current_Admin.FullName;
            txtUserName.Text = _Current_Admin.UserName;
            if (_Current_Admin.Role == 1)
                rbLeader.Checked = true;
            else
                rbAdmin.Checked = true;
            if (!String.IsNullOrWhiteSpace(_Current_Admin.picturePath)) 
            {
                pbEditAdminPicture.Image = Image.FromFile(_Current_Admin.picturePath);         
            } 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            String FullName=txtFullName.Text;
            String UserName = txtUserName.Text;
            int Role;
            if (rbLeader.Checked)
                Role = 1;
            else
                Role = 0;
            String PicturePath = _Current_Admin.picturePath;
            if (!string.IsNullOrWhiteSpace(_selectedImagePath))
            {
                PicturePath = SaveAdminImage();
            }
            if (BankBusinessLogic.EditAdminInfo(_Current_Admin.AdminID, FullName, UserName, Role,PicturePath))
            {
                MessageBox.Show("Profile updated successfully.");
                this.Close();
            }
            else
                MessageBox.Show("Username is invalid or already taken.");


        }
        private String _selectedImagePath;
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
        private void btnUploadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();

            open.Title = "Select Admin Image";
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                _selectedImagePath = open.FileName;

                pbEditAdminPicture.Image = Image.FromFile(_selectedImagePath);
                pbEditAdminPicture.SizeMode = PictureBoxSizeMode.Zoom;
            }


        }
    }
}
