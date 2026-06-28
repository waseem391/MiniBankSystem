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
using static BankBusiness.BankBusinessLogic;

namespace WindowsFormsApp1
{

    public partial class SignIn : Form
    {
        public bool signInSuccess () 
        {
            AdminINFO admin = new AdminINFO();
            admin.UserName = txtUserName.Text;
            admin.Password = txtPassword.Text;
            admin.FullName = txtFullName.Text;
            admin.createdDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            admin.picturePath = SaveAdminImage();
            return TryToAddAdmin(admin.UserName, admin.Password, admin.FullName, admin.createdDate,admin.picturePath,admin.Role);
        }
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (signInSuccess())
            {
                MessageBox.Show("Sign In Successful");
                this.Close();
             }
             else
             {
                 MessageBox.Show("Invalid data entered");
            }
        }

        String _selectedImagePath = "";
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
        private void btnImageUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select Admin Image";
            open.Filter= "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                _selectedImagePath = open.FileName;
                pbAdminPictures.Image = Image.FromFile(_selectedImagePath);
                pbAdminPictures.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
