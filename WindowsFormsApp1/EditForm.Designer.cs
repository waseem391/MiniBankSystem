namespace WindowsFormsApp1
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblManageAdmin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.rbLeader = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.gbRole = new System.Windows.Forms.GroupBox();
            this.pbEditAdminPicture = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.gbRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditAdminPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageAdmin
            // 
            this.lblManageAdmin.AutoSize = true;
            this.lblManageAdmin.Location = new System.Drawing.Point(116, 31);
            this.lblManageAdmin.Name = "lblManageAdmin";
            this.lblManageAdmin.Size = new System.Drawing.Size(106, 13);
            this.lblManageAdmin.TabIndex = 0;
            this.lblManageAdmin.Text = "Manage Admin , ID=";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(316, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(98, 90);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(182, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(98, 158);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(182, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // rbLeader
            // 
            this.rbLeader.AutoSize = true;
            this.rbLeader.Location = new System.Drawing.Point(45, 20);
            this.rbLeader.Name = "rbLeader";
            this.rbLeader.Size = new System.Drawing.Size(58, 17);
            this.rbLeader.TabIndex = 6;
            this.rbLeader.TabStop = true;
            this.rbLeader.Text = "Leader";
            this.rbLeader.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(45, 43);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbAdmin.TabIndex = 7;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(15, 97);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(60, 13);
            this.lblFullName.TabIndex = 8;
            this.lblFullName.Text = "Full Name: ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(15, 161);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User Name:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(15, 254);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 13);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "Role:";
            // 
            // gbRole
            // 
            this.gbRole.Controls.Add(this.rbAdmin);
            this.gbRole.Controls.Add(this.rbLeader);
            this.gbRole.Location = new System.Drawing.Point(115, 211);
            this.gbRole.Name = "gbRole";
            this.gbRole.Size = new System.Drawing.Size(165, 82);
            this.gbRole.TabIndex = 11;
            this.gbRole.TabStop = false;
            this.gbRole.Text = "Role";
            // 
            // pbEditAdminPicture
            // 
            this.pbEditAdminPicture.Image = global::WindowsFormsApp1.Properties.Resources._1000_F_24940114_byTrVVviV4zCscBU3F3uFzfY9j7CoPjG;
            this.pbEditAdminPicture.Location = new System.Drawing.Point(21, 321);
            this.pbEditAdminPicture.Name = "pbEditAdminPicture";
            this.pbEditAdminPicture.Size = new System.Drawing.Size(201, 154);
            this.pbEditAdminPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditAdminPicture.TabIndex = 12;
            this.pbEditAdminPicture.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(228, 374);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(61, 46);
            this.btnUploadImage.TabIndex = 13;
            this.btnUploadImage.Text = "Upload";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(228, 483);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(62, 46);
            this.btnSaveChange.TabIndex = 14;
            this.btnSaveChange.Text = "Save Change";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 528);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.pbEditAdminPicture);
            this.Controls.Add(this.gbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblManageAdmin);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.gbRole.ResumeLayout(false);
            this.gbRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditAdminPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageAdmin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.RadioButton rbLeader;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.GroupBox gbRole;
        private System.Windows.Forms.PictureBox pbEditAdminPicture;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnSaveChange;
    }
}