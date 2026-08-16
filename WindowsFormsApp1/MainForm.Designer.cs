namespace WindowsFormsApp1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pnlBrandIcon = new System.Windows.Forms.Panel();
            this.lblBrandIcon = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblManageSection = new System.Windows.Forms.Label();
            this.pnlManageCard = new System.Windows.Forms.Panel();
            this.pnlManageIcon = new System.Windows.Forms.Panel();
            this.lblManageIcon = new System.Windows.Forms.Label();
            this.lblManageTitle = new System.Windows.Forms.Label();
            this.lblManageSub = new System.Windows.Forms.Label();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.lblTxSection = new System.Windows.Forms.Label();
            this.pnlDepositCard = new System.Windows.Forms.Panel();
            this.pnlDepositIcon = new System.Windows.Forms.Panel();
            this.lblDepositIcon = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.pnlWithdrawCard = new System.Windows.Forms.Panel();
            this.pnlWithdrawIcon = new System.Windows.Forms.Panel();
            this.lblWithdrawIcon = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.pnlTransferCard = new System.Windows.Forms.Panel();
            this.pnlTransferIcon = new System.Windows.Forms.Panel();
            this.lblTransferIcon = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.pnlHistoryCard = new System.Windows.Forms.Panel();
            this.pnlHistoryIcon = new System.Windows.Forms.Panel();
            this.lblHistoryIcon = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditAdmin = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.pnlAvatarTop = new System.Windows.Forms.Panel();
            this.btnEditPicture = new System.Windows.Forms.Button();
            this.lblPanelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPanelRole = new System.Windows.Forms.Label();
            this.pnlPanelInfo = new System.Windows.Forms.Panel();
            this.txtUNameVal = new System.Windows.Forms.TextBox();
            this.lblUNameLbl = new System.Windows.Forms.Label();
            this.lblFullNameLbl = new System.Windows.Forms.Label();
            this.lblFullNameVal = new System.Windows.Forms.Label();
            this.lblLastLoginLbl = new System.Windows.Forms.Label();
            this.lblLastLoginVal = new System.Windows.Forms.Label();
            this.pnlPanelBtns = new System.Windows.Forms.Panel();
            this.btnCancelChanges = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlBrandIcon.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlManageCard.SuspendLayout();
            this.pnlManageIcon.SuspendLayout();
            this.pnlDepositCard.SuspendLayout();
            this.pnlDepositIcon.SuspendLayout();
            this.pnlWithdrawCard.SuspendLayout();
            this.pnlWithdrawIcon.SuspendLayout();
            this.pnlTransferCard.SuspendLayout();
            this.pnlTransferIcon.SuspendLayout();
            this.pnlHistoryCard.SuspendLayout();
            this.pnlHistoryIcon.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAvatarTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPanelInfo.SuspendLayout();
            this.pnlPanelBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.pnlBrandIcon);
            this.pnlTopBar.Controls.Add(this.lblBrandName);
            this.pnlTopBar.Controls.Add(this.lblAdminName);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(900, 56);
            this.pnlTopBar.TabIndex = 2;
            this.pnlTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopBar_Paint);
            // 
            // pnlBrandIcon
            // 
            this.pnlBrandIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(86)))));
            this.pnlBrandIcon.Controls.Add(this.lblBrandIcon);
            this.pnlBrandIcon.Location = new System.Drawing.Point(16, 13);
            this.pnlBrandIcon.Name = "pnlBrandIcon";
            this.pnlBrandIcon.Size = new System.Drawing.Size(30, 30);
            this.pnlBrandIcon.TabIndex = 0;
            // 
            // lblBrandIcon
            // 
            this.lblBrandIcon.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblBrandIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.lblBrandIcon.Location = new System.Drawing.Point(0, 0);
            this.lblBrandIcon.Name = "lblBrandIcon";
            this.lblBrandIcon.Size = new System.Drawing.Size(30, 30);
            this.lblBrandIcon.TabIndex = 0;
            this.lblBrandIcon.Text = "$";
            this.lblBrandIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblBrandName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.lblBrandName.Location = new System.Drawing.Point(54, 18);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(104, 18);
            this.lblBrandName.TabIndex = 1;
            this.lblBrandName.Text = "Bank System";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.lblAdminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAdminName.Location = new System.Drawing.Point(810, 22);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(41, 14);
            this.lblAdminName.TabIndex = 2;
            this.lblAdminName.Text = "Admin";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.pnlContent.Controls.Add(this.lblManageSection);
            this.pnlContent.Controls.Add(this.pnlManageCard);
            this.pnlContent.Controls.Add(this.lblTxSection);
            this.pnlContent.Controls.Add(this.pnlDepositCard);
            this.pnlContent.Controls.Add(this.pnlWithdrawCard);
            this.pnlContent.Controls.Add(this.pnlTransferCard);
            this.pnlContent.Controls.Add(this.pnlHistoryCard);
            this.pnlContent.Location = new System.Drawing.Point(0, 56);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(700, 504);
            this.pnlContent.TabIndex = 0;
            // 
            // lblManageSection
            // 
            this.lblManageSection.AutoSize = true;
            this.lblManageSection.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblManageSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblManageSection.Location = new System.Drawing.Point(28, 24);
            this.lblManageSection.Name = "lblManageSection";
            this.lblManageSection.Size = new System.Drawing.Size(79, 12);
            this.lblManageSection.TabIndex = 0;
            this.lblManageSection.Text = "MANAGEMENT";
            // 
            // pnlManageCard
            // 
            this.pnlManageCard.BackColor = System.Drawing.Color.White;
            this.pnlManageCard.Controls.Add(this.pnlManageIcon);
            this.pnlManageCard.Controls.Add(this.lblManageTitle);
            this.pnlManageCard.Controls.Add(this.lblManageSub);
            this.pnlManageCard.Controls.Add(this.btnManageAccount);
            this.pnlManageCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlManageCard.Location = new System.Drawing.Point(28, 44);
            this.pnlManageCard.Name = "pnlManageCard";
            this.pnlManageCard.Size = new System.Drawing.Size(260, 64);
            this.pnlManageCard.TabIndex = 1;
            // 
            // pnlManageIcon
            // 
            this.pnlManageIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.pnlManageIcon.Controls.Add(this.lblManageIcon);
            this.pnlManageIcon.Location = new System.Drawing.Point(12, 12);
            this.pnlManageIcon.Name = "pnlManageIcon";
            this.pnlManageIcon.Size = new System.Drawing.Size(40, 40);
            this.pnlManageIcon.TabIndex = 0;
            // 
            // lblManageIcon
            // 
            this.lblManageIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblManageIcon.Location = new System.Drawing.Point(0, 0);
            this.lblManageIcon.Name = "lblManageIcon";
            this.lblManageIcon.Size = new System.Drawing.Size(40, 40);
            this.lblManageIcon.TabIndex = 0;
            this.lblManageIcon.Text = "👥";
            this.lblManageIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManageTitle
            // 
            this.lblManageTitle.AutoSize = true;
            this.lblManageTitle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblManageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.lblManageTitle.Location = new System.Drawing.Point(62, 12);
            this.lblManageTitle.Name = "lblManageTitle";
            this.lblManageTitle.Size = new System.Drawing.Size(123, 16);
            this.lblManageTitle.TabIndex = 1;
            this.lblManageTitle.Text = "Manage Accounts";
            // 
            // lblManageSub
            // 
            this.lblManageSub.AutoSize = true;
            this.lblManageSub.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.lblManageSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblManageSub.Location = new System.Drawing.Point(62, 32);
            this.lblManageSub.Name = "lblManageSub";
            this.lblManageSub.Size = new System.Drawing.Size(108, 12);
            this.lblManageSub.TabIndex = 2;
            this.lblManageSub.Text = "View / Edit all accounts";
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnManageAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAccount.FlatAppearance.BorderSize = 0;
            this.btnManageAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccount.Location = new System.Drawing.Point(0, 0);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(260, 64);
            this.btnManageAccount.TabIndex = 3;
            this.btnManageAccount.UseVisualStyleBackColor = false;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // lblTxSection
            // 
            this.lblTxSection.AutoSize = true;
            this.lblTxSection.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblTxSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTxSection.Location = new System.Drawing.Point(28, 130);
            this.lblTxSection.Name = "lblTxSection";
            this.lblTxSection.Size = new System.Drawing.Size(88, 12);
            this.lblTxSection.TabIndex = 2;
            this.lblTxSection.Text = "TRANSACTIONS";
            // 
            // pnlDepositCard
            // 
            this.pnlDepositCard.BackColor = System.Drawing.Color.White;
            this.pnlDepositCard.Controls.Add(this.pnlDepositIcon);
            this.pnlDepositCard.Controls.Add(this.btnDeposit);
            this.pnlDepositCard.Location = new System.Drawing.Point(28, 154);
            this.pnlDepositCard.Name = "pnlDepositCard";
            this.pnlDepositCard.Size = new System.Drawing.Size(140, 110);
            this.pnlDepositCard.TabIndex = 3;
            // 
            // pnlDepositIcon
            // 
            this.pnlDepositIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.pnlDepositIcon.Controls.Add(this.lblDepositIcon);
            this.pnlDepositIcon.Location = new System.Drawing.Point(48, 16);
            this.pnlDepositIcon.Name = "pnlDepositIcon";
            this.pnlDepositIcon.Size = new System.Drawing.Size(44, 44);
            this.pnlDepositIcon.TabIndex = 0;
            // 
            // lblDepositIcon
            // 
            this.lblDepositIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblDepositIcon.Location = new System.Drawing.Point(0, 0);
            this.lblDepositIcon.Name = "lblDepositIcon";
            this.lblDepositIcon.Size = new System.Drawing.Size(44, 44);
            this.lblDepositIcon.TabIndex = 0;
            this.lblDepositIcon.Text = "⬇";
            this.lblDepositIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Transparent;
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnDeposit.Location = new System.Drawing.Point(0, 0);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnDeposit.Size = new System.Drawing.Size(140, 110);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // pnlWithdrawCard
            // 
            this.pnlWithdrawCard.BackColor = System.Drawing.Color.White;
            this.pnlWithdrawCard.Controls.Add(this.pnlWithdrawIcon);
            this.pnlWithdrawCard.Controls.Add(this.btnWithdraw);
            this.pnlWithdrawCard.Location = new System.Drawing.Point(182, 154);
            this.pnlWithdrawCard.Name = "pnlWithdrawCard";
            this.pnlWithdrawCard.Size = new System.Drawing.Size(140, 110);
            this.pnlWithdrawCard.TabIndex = 4;
            // 
            // pnlWithdrawIcon
            // 
            this.pnlWithdrawIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.pnlWithdrawIcon.Controls.Add(this.lblWithdrawIcon);
            this.pnlWithdrawIcon.Location = new System.Drawing.Point(48, 16);
            this.pnlWithdrawIcon.Name = "pnlWithdrawIcon";
            this.pnlWithdrawIcon.Size = new System.Drawing.Size(44, 44);
            this.pnlWithdrawIcon.TabIndex = 0;
            // 
            // lblWithdrawIcon
            // 
            this.lblWithdrawIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblWithdrawIcon.Location = new System.Drawing.Point(0, 0);
            this.lblWithdrawIcon.Name = "lblWithdrawIcon";
            this.lblWithdrawIcon.Size = new System.Drawing.Size(44, 44);
            this.lblWithdrawIcon.TabIndex = 0;
            this.lblWithdrawIcon.Text = "⬆";
            this.lblWithdrawIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnWithdraw.Location = new System.Drawing.Point(0, 0);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnWithdraw.Size = new System.Drawing.Size(140, 110);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // pnlTransferCard
            // 
            this.pnlTransferCard.BackColor = System.Drawing.Color.White;
            this.pnlTransferCard.Controls.Add(this.pnlTransferIcon);
            this.pnlTransferCard.Controls.Add(this.btnTransfer);
            this.pnlTransferCard.Location = new System.Drawing.Point(336, 154);
            this.pnlTransferCard.Name = "pnlTransferCard";
            this.pnlTransferCard.Size = new System.Drawing.Size(140, 110);
            this.pnlTransferCard.TabIndex = 5;
            // 
            // pnlTransferIcon
            // 
            this.pnlTransferIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.pnlTransferIcon.Controls.Add(this.lblTransferIcon);
            this.pnlTransferIcon.Location = new System.Drawing.Point(48, 16);
            this.pnlTransferIcon.Name = "pnlTransferIcon";
            this.pnlTransferIcon.Size = new System.Drawing.Size(44, 44);
            this.pnlTransferIcon.TabIndex = 0;
            // 
            // lblTransferIcon
            // 
            this.lblTransferIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblTransferIcon.Location = new System.Drawing.Point(0, 0);
            this.lblTransferIcon.Name = "lblTransferIcon";
            this.lblTransferIcon.Size = new System.Drawing.Size(44, 44);
            this.lblTransferIcon.TabIndex = 0;
            this.lblTransferIcon.Text = "⇄";
            this.lblTransferIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnTransfer.Location = new System.Drawing.Point(0, 0);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnTransfer.Size = new System.Drawing.Size(140, 110);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // pnlHistoryCard
            // 
            this.pnlHistoryCard.BackColor = System.Drawing.Color.White;
            this.pnlHistoryCard.Controls.Add(this.pnlHistoryIcon);
            this.pnlHistoryCard.Controls.Add(this.btnTransaction);
            this.pnlHistoryCard.Location = new System.Drawing.Point(490, 154);
            this.pnlHistoryCard.Name = "pnlHistoryCard";
            this.pnlHistoryCard.Size = new System.Drawing.Size(140, 110);
            this.pnlHistoryCard.TabIndex = 6;
            // 
            // pnlHistoryIcon
            // 
            this.pnlHistoryIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.pnlHistoryIcon.Controls.Add(this.lblHistoryIcon);
            this.pnlHistoryIcon.Location = new System.Drawing.Point(48, 16);
            this.pnlHistoryIcon.Name = "pnlHistoryIcon";
            this.pnlHistoryIcon.Size = new System.Drawing.Size(44, 44);
            this.pnlHistoryIcon.TabIndex = 0;
            // 
            // lblHistoryIcon
            // 
            this.lblHistoryIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblHistoryIcon.Location = new System.Drawing.Point(0, 0);
            this.lblHistoryIcon.Name = "lblHistoryIcon";
            this.lblHistoryIcon.Size = new System.Drawing.Size(44, 44);
            this.lblHistoryIcon.TabIndex = 0;
            this.lblHistoryIcon.Text = "🕐";
            this.lblHistoryIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnTransaction.Location = new System.Drawing.Point(0, 0);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnTransaction.Size = new System.Drawing.Size(140, 110);
            this.btnTransaction.TabIndex = 1;
            this.btnTransaction.Text = "History";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransaction.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnEditAdmin);
            this.panel1.Controls.Add(this.btnAddAdmin);
            this.panel1.Controls.Add(this.pnlAvatarTop);
            this.panel1.Controls.Add(this.pnlPanelInfo);
            this.panel1.Controls.Add(this.pnlPanelBtns);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(706, 56);
            this.panel1.MaximumSize = new System.Drawing.Size(200, 504);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 504);
            this.panel1.TabIndex = 1;
            // 
            // btnEditAdmin
            // 
            this.btnEditAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnEditAdmin.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images;
            this.btnEditAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAdmin.FlatAppearance.BorderSize = 0;
            this.btnEditAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.btnEditAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAdmin.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnEditAdmin.Location = new System.Drawing.Point(107, 421);
            this.btnEditAdmin.Name = "btnEditAdmin";
            this.btnEditAdmin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnEditAdmin.Size = new System.Drawing.Size(87, 83);
            this.btnEditAdmin.TabIndex = 3;
            this.btnEditAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditAdmin.UseVisualStyleBackColor = false;
            this.btnEditAdmin.Click += new System.EventHandler(this.btnEditAdmin_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAdmin.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Add_Admins_Account;
            this.btnAddAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAdmin.FlatAppearance.BorderSize = 0;
            this.btnAddAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdmin.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAddAdmin.Location = new System.Drawing.Point(3, 346);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnAddAdmin.Size = new System.Drawing.Size(94, 75);
            this.btnAddAdmin.TabIndex = 2;
            this.btnAddAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmins_Click);
            // 
            // pnlAvatarTop
            // 
            this.pnlAvatarTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.pnlAvatarTop.Controls.Add(this.btnEditPicture);
            this.pnlAvatarTop.Controls.Add(this.lblPanelName);
            this.pnlAvatarTop.Controls.Add(this.pictureBox1);
            this.pnlAvatarTop.Controls.Add(this.lblPanelRole);
            this.pnlAvatarTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAvatarTop.Location = new System.Drawing.Point(0, 0);
            this.pnlAvatarTop.Name = "pnlAvatarTop";
            this.pnlAvatarTop.Size = new System.Drawing.Size(194, 100);
            this.pnlAvatarTop.TabIndex = 0;
            // 
            // btnEditPicture
            // 
            this.btnEditPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(86)))));
            this.btnEditPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.btnEditPicture.Location = new System.Drawing.Point(8, 71);
            this.btnEditPicture.Name = "btnEditPicture";
            this.btnEditPicture.Size = new System.Drawing.Size(52, 25);
            this.btnEditPicture.TabIndex = 4;
            this.btnEditPicture.Text = "upload";
            this.btnEditPicture.UseVisualStyleBackColor = false;
            this.btnEditPicture.Visible = false;
            this.btnEditPicture.Click += new System.EventHandler(this.btnEditPicture_Click);
            // 
            // lblPanelName
            // 
            this.lblPanelName.AutoSize = true;
            this.lblPanelName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPanelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblPanelName.Location = new System.Drawing.Point(66, 20);
            this.lblPanelName.Name = "lblPanelName";
            this.lblPanelName.Size = new System.Drawing.Size(52, 17);
            this.lblPanelName.TabIndex = 1;
            this.lblPanelName.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.account_icon_sign_symbol_logo_design_free_vector;
            this.pictureBox1.Location = new System.Drawing.Point(8, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblPanelRole
            // 
            this.lblPanelRole.AutoSize = true;
            this.lblPanelRole.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.lblPanelRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPanelRole.Location = new System.Drawing.Point(66, 42);
            this.lblPanelRole.Name = "lblPanelRole";
            this.lblPanelRole.Size = new System.Drawing.Size(65, 12);
            this.lblPanelRole.TabIndex = 2;
            this.lblPanelRole.Text = "Administrator";
            // 
            // pnlPanelInfo
            // 
            this.pnlPanelInfo.Controls.Add(this.txtUNameVal);
            this.pnlPanelInfo.Controls.Add(this.lblUNameLbl);
            this.pnlPanelInfo.Controls.Add(this.lblFullNameLbl);
            this.pnlPanelInfo.Controls.Add(this.lblFullNameVal);
            this.pnlPanelInfo.Controls.Add(this.lblLastLoginLbl);
            this.pnlPanelInfo.Controls.Add(this.lblLastLoginVal);
            this.pnlPanelInfo.Location = new System.Drawing.Point(0, 100);
            this.pnlPanelInfo.Name = "pnlPanelInfo";
            this.pnlPanelInfo.Padding = new System.Windows.Forms.Padding(14);
            this.pnlPanelInfo.Size = new System.Drawing.Size(200, 160);
            this.pnlPanelInfo.TabIndex = 1;
            // 
            // txtUNameVal
            // 
            this.txtUNameVal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtUNameVal.Location = new System.Drawing.Point(16, 30);
            this.txtUNameVal.Name = "txtUNameVal";
            this.txtUNameVal.ReadOnly = true;
            this.txtUNameVal.Size = new System.Drawing.Size(81, 22);
            this.txtUNameVal.TabIndex = 7;
            // 
            // lblUNameLbl
            // 
            this.lblUNameLbl.AutoSize = true;
            this.lblUNameLbl.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.lblUNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblUNameLbl.Location = new System.Drawing.Point(14, 14);
            this.lblUNameLbl.Name = "lblUNameLbl";
            this.lblUNameLbl.Size = new System.Drawing.Size(49, 12);
            this.lblUNameLbl.TabIndex = 0;
            this.lblUNameLbl.Text = "Username";
            // 
            // lblFullNameLbl
            // 
            this.lblFullNameLbl.AutoSize = true;
            this.lblFullNameLbl.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.lblFullNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFullNameLbl.Location = new System.Drawing.Point(14, 60);
            this.lblFullNameLbl.Name = "lblFullNameLbl";
            this.lblFullNameLbl.Size = new System.Drawing.Size(49, 12);
            this.lblFullNameLbl.TabIndex = 2;
            this.lblFullNameLbl.Text = "Full Name";
            // 
            // lblFullNameVal
            // 
            this.lblFullNameVal.AutoSize = true;
            this.lblFullNameVal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblFullNameVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.lblFullNameVal.Location = new System.Drawing.Point(14, 76);
            this.lblFullNameVal.Name = "lblFullNameVal";
            this.lblFullNameVal.Size = new System.Drawing.Size(64, 14);
            this.lblFullNameVal.TabIndex = 3;
            this.lblFullNameVal.Text = "Full Name";
            // 
            // lblLastLoginLbl
            // 
            this.lblLastLoginLbl.AutoSize = true;
            this.lblLastLoginLbl.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.lblLastLoginLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblLastLoginLbl.Location = new System.Drawing.Point(14, 106);
            this.lblLastLoginLbl.Name = "lblLastLoginLbl";
            this.lblLastLoginLbl.Size = new System.Drawing.Size(50, 12);
            this.lblLastLoginLbl.TabIndex = 4;
            this.lblLastLoginLbl.Text = "Last Login";
            // 
            // lblLastLoginVal
            // 
            this.lblLastLoginVal.AutoSize = true;
            this.lblLastLoginVal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblLastLoginVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.lblLastLoginVal.Location = new System.Drawing.Point(14, 122);
            this.lblLastLoginVal.Name = "lblLastLoginVal";
            this.lblLastLoginVal.Size = new System.Drawing.Size(104, 14);
            this.lblLastLoginVal.TabIndex = 5;
            this.lblLastLoginVal.Text = "Today, 9:42 AM";
            // 
            // pnlPanelBtns
            // 
            this.pnlPanelBtns.Controls.Add(this.btnCancelChanges);
            this.pnlPanelBtns.Controls.Add(this.btnSaveChanges);
            this.pnlPanelBtns.Controls.Add(this.btnEditProfile);
            this.pnlPanelBtns.Controls.Add(this.btnLogout);
            this.pnlPanelBtns.Location = new System.Drawing.Point(0, 260);
            this.pnlPanelBtns.Name = "pnlPanelBtns";
            this.pnlPanelBtns.Size = new System.Drawing.Size(200, 80);
            this.pnlPanelBtns.TabIndex = 2;
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.btnCancelChanges.Location = new System.Drawing.Point(144, 0);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.Size = new System.Drawing.Size(47, 31);
            this.btnCancelChanges.TabIndex = 6;
            this.btnCancelChanges.Text = "Cancel";
            this.btnCancelChanges.UseVisualStyleBackColor = false;
            this.btnCancelChanges.Visible = false;
            this.btnCancelChanges.Click += new System.EventHandler(this.btnCancelChanges_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(86)))));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.btnSaveChanges.Location = new System.Drawing.Point(93, 0);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(45, 31);
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnEditProfile.Location = new System.Drawing.Point(0, 0);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnEditProfile.Size = new System.Drawing.Size(200, 36);
            this.btnEditProfile.TabIndex = 0;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 36);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 36);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopBar);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlBrandIcon.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlManageCard.ResumeLayout(false);
            this.pnlManageCard.PerformLayout();
            this.pnlManageIcon.ResumeLayout(false);
            this.pnlDepositCard.ResumeLayout(false);
            this.pnlDepositIcon.ResumeLayout(false);
            this.pnlWithdrawCard.ResumeLayout(false);
            this.pnlWithdrawIcon.ResumeLayout(false);
            this.pnlTransferCard.ResumeLayout(false);
            this.pnlTransferIcon.ResumeLayout(false);
            this.pnlHistoryCard.ResumeLayout(false);
            this.pnlHistoryIcon.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlAvatarTop.ResumeLayout(false);
            this.pnlAvatarTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPanelInfo.ResumeLayout(false);
            this.pnlPanelInfo.PerformLayout();
            this.pnlPanelBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlBrandIcon;
        private System.Windows.Forms.Label lblBrandIcon;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblManageSection;
        private System.Windows.Forms.Panel pnlManageCard;
        private System.Windows.Forms.Panel pnlManageIcon;
        private System.Windows.Forms.Label lblManageIcon;
        private System.Windows.Forms.Label lblManageTitle;
        private System.Windows.Forms.Label lblManageSub;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Label lblTxSection;
        private System.Windows.Forms.Panel pnlDepositCard;
        private System.Windows.Forms.Panel pnlDepositIcon;
        private System.Windows.Forms.Label lblDepositIcon;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Panel pnlWithdrawCard;
        private System.Windows.Forms.Panel pnlWithdrawIcon;
        private System.Windows.Forms.Label lblWithdrawIcon;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Panel pnlTransferCard;
        private System.Windows.Forms.Panel pnlTransferIcon;
        private System.Windows.Forms.Label lblTransferIcon;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Panel pnlHistoryCard;
        private System.Windows.Forms.Panel pnlHistoryIcon;
        private System.Windows.Forms.Label lblHistoryIcon;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAvatarTop;
        private System.Windows.Forms.Label lblPanelName;
        private System.Windows.Forms.Label lblPanelRole;
        private System.Windows.Forms.Panel pnlPanelInfo;
        private System.Windows.Forms.Label lblUNameLbl;
        private System.Windows.Forms.Label lblFullNameLbl;
        private System.Windows.Forms.Label lblFullNameVal;
        private System.Windows.Forms.Label lblLastLoginLbl;
        private System.Windows.Forms.Label lblLastLoginVal;
        private System.Windows.Forms.Panel pnlPanelBtns;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnEditAdmin;
        private System.Windows.Forms.TextBox txtUNameVal;
        private System.Windows.Forms.Button btnEditPicture;
        private System.Windows.Forms.Button btnCancelChanges;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}