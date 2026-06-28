namespace WindowsFormsApp1
{
    partial class ManageAdmins
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.cmsAdminsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblManageAdmin = new System.Windows.Forms.Label();
            this.txtSearchAdmins = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlSearchCard = new System.Windows.Forms.Panel();
            this.lblSearchHint = new System.Windows.Forms.Label();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.lblAdminsListTitle = new System.Windows.Forms.Label();
            this.pnlDetailsCard = new System.Windows.Forms.Panel();
            this.btnDeleteSelectedAdmin = new System.Windows.Forms.Button();
            this.btnEditSelectedAdmin = new System.Windows.Forms.Button();
            this.lblSelectedRoleValue = new System.Windows.Forms.Label();
            this.lblSelectedRole = new System.Windows.Forms.Label();
            this.lblSelectedUsernameValue = new System.Windows.Forms.Label();
            this.lblSelectedUsername = new System.Windows.Forms.Label();
            this.lblSelectedFullNameValue = new System.Windows.Forms.Label();
            this.lblSelectedFullName = new System.Windows.Forms.Label();
            this.lblAdminDetailsSubtitle = new System.Windows.Forms.Label();
            this.lblAdminDetailsTitle = new System.Windows.Forms.Label();
            this.pbSelectedAdminImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            this.cmsAdminsMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlSearchCard.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            this.pnlDetailsCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedAdminImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmins
            // 
            this.dgvAdmins.AllowUserToAddRows = false;
            this.dgvAdmins.AllowUserToDeleteRows = false;
            this.dgvAdmins.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.dgvAdmins.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdmins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmins.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdmins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdmins.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAdmins.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdmins.ColumnHeadersHeight = 42;
            this.dgvAdmins.ContextMenuStrip = this.cmsAdminsMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(102)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmins.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdmins.EnableHeadersVisualStyles = false;
            this.dgvAdmins.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.dgvAdmins.Location = new System.Drawing.Point(18, 56);
            this.dgvAdmins.MultiSelect = false;
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.RowHeadersVisible = false;
            this.dgvAdmins.RowTemplate.Height = 38;
            this.dgvAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmins.Size = new System.Drawing.Size(587, 310);
            this.dgvAdmins.TabIndex = 0;
            this.dgvAdmins.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAdmins_CellMouseDown);
            this.dgvAdmins.SelectionChanged += new System.EventHandler(this.dgvAdmins_SelectionChanged);
            // 
            // cmsAdminsMenu
            // 
            this.cmsAdminsMenu.BackColor = System.Drawing.Color.White;
            this.cmsAdminsMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsAdminsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsAdminsMenu.Name = "cmsAdminsMenu";
            this.cmsAdminsMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lblManageAdmin
            // 
            this.lblManageAdmin.AutoSize = true;
            this.lblManageAdmin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblManageAdmin.ForeColor = System.Drawing.Color.White;
            this.lblManageAdmin.Location = new System.Drawing.Point(92, 20);
            this.lblManageAdmin.Name = "lblManageAdmin";
            this.lblManageAdmin.Size = new System.Drawing.Size(200, 32);
            this.lblManageAdmin.TabIndex = 1;
            this.lblManageAdmin.Text = "Manage Admins";
            // 
            // txtSearchAdmins
            // 
            this.txtSearchAdmins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchAdmins.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearchAdmins.Location = new System.Drawing.Point(18, 52);
            this.txtSearchAdmins.Name = "txtSearchAdmins";
            this.txtSearchAdmins.Size = new System.Drawing.Size(323, 27);
            this.txtSearchAdmins.TabIndex = 2;
            this.txtSearchAdmins.TextChanged += new System.EventHandler(this.txtSearchAdmins_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.lblSearch.Location = new System.Drawing.Point(14, 21);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(102, 19);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search Admin";
            // 
            // btnMainForm
            // 
            this.btnMainForm.BackColor = System.Drawing.Color.White;
            this.btnMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.btnMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMainForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.btnMainForm.Location = new System.Drawing.Point(762, 25);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(126, 34);
            this.btnMainForm.TabIndex = 4;
            this.btnMainForm.Text = "Back to Main";
            this.btnMainForm.UseVisualStyleBackColor = false;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.pnlHeader.Controls.Add(this.btnMainForm);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.pnlLogo);
            this.pnlHeader.Controls.Add(this.lblManageAdmin);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 88);
            this.pnlHeader.TabIndex = 5;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(96, 53);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(251, 17);
            this.lblHeaderSubtitle.TabIndex = 7;
            this.lblHeaderSubtitle.Text = "Manage admin accounts and permissions";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(102)))), ((int)(((byte)(72)))));
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Location = new System.Drawing.Point(32, 22);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(44, 44);
            this.pnlLogo.TabIndex = 6;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(11, 5);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(28, 32);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "$";
            // 
            // pnlSearchCard
            // 
            this.pnlSearchCard.BackColor = System.Drawing.Color.White;
            this.pnlSearchCard.Controls.Add(this.lblSearchHint);
            this.pnlSearchCard.Controls.Add(this.lblSearch);
            this.pnlSearchCard.Controls.Add(this.txtSearchAdmins);
            this.pnlSearchCard.Location = new System.Drawing.Point(24, 110);
            this.pnlSearchCard.Name = "pnlSearchCard";
            this.pnlSearchCard.Size = new System.Drawing.Size(623, 100);
            this.pnlSearchCard.TabIndex = 6;
            // 
            // lblSearchHint
            // 
            this.lblSearchHint.AutoSize = true;
            this.lblSearchHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSearchHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblSearchHint.Location = new System.Drawing.Point(352, 58);
            this.lblSearchHint.Name = "lblSearchHint";
            this.lblSearchHint.Size = new System.Drawing.Size(180, 15);
            this.lblSearchHint.TabIndex = 4;
            this.lblSearchHint.Text = "Search by full name or username";
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.Controls.Add(this.lblAdminsListTitle);
            this.pnlGridCard.Controls.Add(this.dgvAdmins);
            this.pnlGridCard.Location = new System.Drawing.Point(24, 226);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(623, 384);
            this.pnlGridCard.TabIndex = 7;
            // 
            // lblAdminsListTitle
            // 
            this.lblAdminsListTitle.AutoSize = true;
            this.lblAdminsListTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAdminsListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.lblAdminsListTitle.Location = new System.Drawing.Point(14, 18);
            this.lblAdminsListTitle.Name = "lblAdminsListTitle";
            this.lblAdminsListTitle.Size = new System.Drawing.Size(92, 20);
            this.lblAdminsListTitle.TabIndex = 1;
            this.lblAdminsListTitle.Text = "Admins List";
            // 
            // pnlDetailsCard
            // 
            this.pnlDetailsCard.BackColor = System.Drawing.Color.White;
            this.pnlDetailsCard.Controls.Add(this.btnDeleteSelectedAdmin);
            this.pnlDetailsCard.Controls.Add(this.btnEditSelectedAdmin);
            this.pnlDetailsCard.Controls.Add(this.lblSelectedRoleValue);
            this.pnlDetailsCard.Controls.Add(this.lblSelectedRole);
            this.pnlDetailsCard.Controls.Add(this.lblSelectedUsernameValue);
            this.pnlDetailsCard.Controls.Add(this.lblSelectedUsername);
            this.pnlDetailsCard.Controls.Add(this.lblSelectedFullNameValue);
            this.pnlDetailsCard.Controls.Add(this.lblSelectedFullName);
            this.pnlDetailsCard.Controls.Add(this.lblAdminDetailsSubtitle);
            this.pnlDetailsCard.Controls.Add(this.lblAdminDetailsTitle);
            this.pnlDetailsCard.Controls.Add(this.pbSelectedAdminImage);
            this.pnlDetailsCard.Location = new System.Drawing.Point(666, 110);
            this.pnlDetailsCard.Name = "pnlDetailsCard";
            this.pnlDetailsCard.Size = new System.Drawing.Size(210, 500);
            this.pnlDetailsCard.TabIndex = 8;
            // 
            // btnDeleteSelectedAdmin
            // 
            this.btnDeleteSelectedAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteSelectedAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSelectedAdmin.FlatAppearance.BorderSize = 0;
            this.btnDeleteSelectedAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSelectedAdmin.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSelectedAdmin.Location = new System.Drawing.Point(24, 424);
            this.btnDeleteSelectedAdmin.Name = "btnDeleteSelectedAdmin";
            this.btnDeleteSelectedAdmin.Size = new System.Drawing.Size(162, 38);
            this.btnDeleteSelectedAdmin.TabIndex = 10;
            this.btnDeleteSelectedAdmin.Text = "Delete Admin";
            this.btnDeleteSelectedAdmin.UseVisualStyleBackColor = false;
            this.btnDeleteSelectedAdmin.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnEditSelectedAdmin
            // 
            this.btnEditSelectedAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(102)))), ((int)(((byte)(72)))));
            this.btnEditSelectedAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSelectedAdmin.FlatAppearance.BorderSize = 0;
            this.btnEditSelectedAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSelectedAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditSelectedAdmin.ForeColor = System.Drawing.Color.White;
            this.btnEditSelectedAdmin.Location = new System.Drawing.Point(24, 378);
            this.btnEditSelectedAdmin.Name = "btnEditSelectedAdmin";
            this.btnEditSelectedAdmin.Size = new System.Drawing.Size(162, 38);
            this.btnEditSelectedAdmin.TabIndex = 9;
            this.btnEditSelectedAdmin.Text = "Edit Admin";
            this.btnEditSelectedAdmin.UseVisualStyleBackColor = false;
            this.btnEditSelectedAdmin.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // lblSelectedRoleValue
            // 
            this.lblSelectedRoleValue.AutoSize = true;
            this.lblSelectedRoleValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedRoleValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.lblSelectedRoleValue.Location = new System.Drawing.Point(20, 326);
            this.lblSelectedRoleValue.Name = "lblSelectedRoleValue";
            this.lblSelectedRoleValue.Size = new System.Drawing.Size(93, 19);
            this.lblSelectedRoleValue.TabIndex = 8;
            this.lblSelectedRoleValue.Text = "Not selected";
            // 
            // lblSelectedRole
            // 
            this.lblSelectedRole.AutoSize = true;
            this.lblSelectedRole.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSelectedRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblSelectedRole.Location = new System.Drawing.Point(21, 304);
            this.lblSelectedRole.Name = "lblSelectedRole";
            this.lblSelectedRole.Size = new System.Drawing.Size(32, 15);
            this.lblSelectedRole.TabIndex = 7;
            this.lblSelectedRole.Text = "Role";
            // 
            // lblSelectedUsernameValue
            // 
            this.lblSelectedUsernameValue.AutoSize = true;
            this.lblSelectedUsernameValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedUsernameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.lblSelectedUsernameValue.Location = new System.Drawing.Point(20, 267);
            this.lblSelectedUsernameValue.Name = "lblSelectedUsernameValue";
            this.lblSelectedUsernameValue.Size = new System.Drawing.Size(93, 19);
            this.lblSelectedUsernameValue.TabIndex = 6;
            this.lblSelectedUsernameValue.Text = "Not selected";
            // 
            // lblSelectedUsername
            // 
            this.lblSelectedUsername.AutoSize = true;
            this.lblSelectedUsername.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSelectedUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblSelectedUsername.Location = new System.Drawing.Point(21, 245);
            this.lblSelectedUsername.Name = "lblSelectedUsername";
            this.lblSelectedUsername.Size = new System.Drawing.Size(64, 15);
            this.lblSelectedUsername.TabIndex = 5;
            this.lblSelectedUsername.Text = "Username";
            // 
            // lblSelectedFullNameValue
            // 
            this.lblSelectedFullNameValue.AutoSize = true;
            this.lblSelectedFullNameValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedFullNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.lblSelectedFullNameValue.Location = new System.Drawing.Point(20, 208);
            this.lblSelectedFullNameValue.Name = "lblSelectedFullNameValue";
            this.lblSelectedFullNameValue.Size = new System.Drawing.Size(93, 19);
            this.lblSelectedFullNameValue.TabIndex = 4;
            this.lblSelectedFullNameValue.Text = "Not selected";
            // 
            // lblSelectedFullName
            // 
            this.lblSelectedFullName.AutoSize = true;
            this.lblSelectedFullName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSelectedFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblSelectedFullName.Location = new System.Drawing.Point(21, 186);
            this.lblSelectedFullName.Name = "lblSelectedFullName";
            this.lblSelectedFullName.Size = new System.Drawing.Size(62, 15);
            this.lblSelectedFullName.TabIndex = 3;
            this.lblSelectedFullName.Text = "Full Name";
            // 
            // lblAdminDetailsSubtitle
            // 
            this.lblAdminDetailsSubtitle.AutoSize = true;
            this.lblAdminDetailsSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAdminDetailsSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblAdminDetailsSubtitle.Location = new System.Drawing.Point(21, 48);
            this.lblAdminDetailsSubtitle.Name = "lblAdminDetailsSubtitle";
            this.lblAdminDetailsSubtitle.Size = new System.Drawing.Size(153, 15);
            this.lblAdminDetailsSubtitle.TabIndex = 2;
            this.lblAdminDetailsSubtitle.Text = "Select admin from the table";
            // 
            // lblAdminDetailsTitle
            // 
            this.lblAdminDetailsTitle.AutoSize = true;
            this.lblAdminDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdminDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.lblAdminDetailsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblAdminDetailsTitle.Name = "lblAdminDetailsTitle";
            this.lblAdminDetailsTitle.Size = new System.Drawing.Size(118, 21);
            this.lblAdminDetailsTitle.TabIndex = 1;
            this.lblAdminDetailsTitle.Text = "Admin Details";
            // 
            // pbSelectedAdminImage
            // 
            this.pbSelectedAdminImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.pbSelectedAdminImage.Location = new System.Drawing.Point(58, 86);
            this.pbSelectedAdminImage.Name = "pbSelectedAdminImage";
            this.pbSelectedAdminImage.Size = new System.Drawing.Size(96, 82);
            this.pbSelectedAdminImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectedAdminImage.TabIndex = 0;
            this.pbSelectedAdminImage.TabStop = false;
            // 
            // ManageAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(900, 635);
            this.Controls.Add(this.pnlDetailsCard);
            this.Controls.Add(this.pnlGridCard);
            this.Controls.Add(this.pnlSearchCard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageAdmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System - Manage Admins";
            this.Load += new System.EventHandler(this.EditAdmins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.cmsAdminsMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlSearchCard.ResumeLayout(false);
            this.pnlSearchCard.PerformLayout();
            this.pnlGridCard.ResumeLayout(false);
            this.pnlGridCard.PerformLayout();
            this.pnlDetailsCard.ResumeLayout(false);
            this.pnlDetailsCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedAdminImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.ContextMenuStrip cmsAdminsMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label lblManageAdmin;
        private System.Windows.Forms.TextBox txtSearchAdmins;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnMainForm;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlSearchCard;
        private System.Windows.Forms.Label lblSearchHint;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Label lblAdminsListTitle;
        private System.Windows.Forms.Panel pnlDetailsCard;
        private System.Windows.Forms.PictureBox pbSelectedAdminImage;
        private System.Windows.Forms.Label lblAdminDetailsTitle;
        private System.Windows.Forms.Label lblAdminDetailsSubtitle;
        private System.Windows.Forms.Label lblSelectedFullName;
        private System.Windows.Forms.Label lblSelectedFullNameValue;
        private System.Windows.Forms.Label lblSelectedUsername;
        private System.Windows.Forms.Label lblSelectedUsernameValue;
        private System.Windows.Forms.Label lblSelectedRole;
        private System.Windows.Forms.Label lblSelectedRoleValue;
        private System.Windows.Forms.Button btnEditSelectedAdmin;
        private System.Windows.Forms.Button btnDeleteSelectedAdmin;
    }
}