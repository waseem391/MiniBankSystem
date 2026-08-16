namespace WindowsFormsApp1
{
    partial class Withdraw
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchClient = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNationalIDTitle = new System.Windows.Forms.Label();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblAccountNumberTitle = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.grpAmount = new System.Windows.Forms.GroupBox();
            this.lblEnterAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpClient.SuspendLayout();
            this.grpAccount.SuspendLayout();
            this.grpAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblAdminName);
            this.pnlHeader.Location = new System.Drawing.Point(3, 26);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(864, 69);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "💸 Withdraw Money";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAdminName.ForeColor = System.Drawing.Color.White;
            this.lblAdminName.Location = new System.Drawing.Point(615, 27);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(97, 20);
            this.lblAdminName.TabIndex = 1;
            this.lblAdminName.Text = "Admin Name";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblSearchClient);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Location = new System.Drawing.Point(42, 122);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(771, 78);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            // 
            // lblSearchClient
            // 
            this.lblSearchClient.AutoSize = true;
            this.lblSearchClient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearchClient.Location = new System.Drawing.Point(22, 16);
            this.lblSearchClient.Name = "lblSearchClient";
            this.lblSearchClient.Size = new System.Drawing.Size(125, 20);
            this.lblSearchClient.TabIndex = 0;
            this.lblSearchClient.Text = "🔑 Search Client";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(17, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(515, 27);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(32)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(557, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.lblClient);
            this.grpClient.Controls.Add(this.lblNameTitle);
            this.grpClient.Controls.Add(this.lblName);
            this.grpClient.Controls.Add(this.lblPhoneTitle);
            this.grpClient.Controls.Add(this.lblPhone);
            this.grpClient.Controls.Add(this.lblNationalIDTitle);
            this.grpClient.Controls.Add(this.lblNationalID);
            this.grpClient.Location = new System.Drawing.Point(42, 227);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(360, 173);
            this.grpClient.TabIndex = 2;
            this.grpClient.TabStop = false;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblClient.Location = new System.Drawing.Point(23, 22);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(82, 21);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "👤 Client";
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNameTitle.Location = new System.Drawing.Point(23, 63);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(42, 15);
            this.lblNameTitle.TabIndex = 1;
            this.lblNameTitle.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName.Location = new System.Drawing.Point(94, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 15);
            this.lblName.TabIndex = 2;
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhoneTitle.Location = new System.Drawing.Point(23, 98);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(44, 15);
            this.lblPhoneTitle.TabIndex = 3;
            this.lblPhoneTitle.Text = "Phone:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.Location = new System.Drawing.Point(94, 98);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 15);
            this.lblPhone.TabIndex = 4;
            // 
            // lblNationalIDTitle
            // 
            this.lblNationalIDTitle.AutoSize = true;
            this.lblNationalIDTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNationalIDTitle.Location = new System.Drawing.Point(23, 133);
            this.lblNationalIDTitle.Name = "lblNationalIDTitle";
            this.lblNationalIDTitle.Size = new System.Drawing.Size(69, 15);
            this.lblNationalIDTitle.TabIndex = 5;
            this.lblNationalIDTitle.Text = "National ID:";
            // 
            // lblNationalID
            // 
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNationalID.Location = new System.Drawing.Point(94, 133);
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size(0, 15);
            this.lblNationalID.TabIndex = 6;
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(this.lblAccount);
            this.grpAccount.Controls.Add(this.lblAccountNumberTitle);
            this.grpAccount.Controls.Add(this.lblAccountNumber);
            this.grpAccount.Controls.Add(this.lblBalance);
            this.grpAccount.Location = new System.Drawing.Point(453, 227);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(360, 173);
            this.grpAccount.TabIndex = 3;
            this.grpAccount.TabStop = false;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAccount.Location = new System.Drawing.Point(23, 22);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(92, 21);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "▣ Account";
            // 
            // lblAccountNumberTitle
            // 
            this.lblAccountNumberTitle.AutoSize = true;
            this.lblAccountNumberTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAccountNumberTitle.Location = new System.Drawing.Point(23, 63);
            this.lblAccountNumberTitle.Name = "lblAccountNumberTitle";
            this.lblAccountNumberTitle.Size = new System.Drawing.Size(102, 15);
            this.lblAccountNumberTitle.TabIndex = 1;
            this.lblAccountNumberTitle.Text = "Account Number:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAccountNumber.Location = new System.Drawing.Point(129, 63);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(0, 15);
            this.lblAccountNumber.TabIndex = 2;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(23, 113);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(110, 21);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Balance: 0 JD";
            // 
            // grpAmount
            // 
            this.grpAmount.Controls.Add(this.lblEnterAmount);
            this.grpAmount.Controls.Add(this.txtAmount);
            this.grpAmount.Controls.Add(this.btnWithdraw);
            this.grpAmount.Location = new System.Drawing.Point(222, 434);
            this.grpAmount.Name = "grpAmount";
            this.grpAmount.Size = new System.Drawing.Size(429, 118);
            this.grpAmount.TabIndex = 4;
            this.grpAmount.TabStop = false;
            // 
            // lblEnterAmount
            // 
            this.lblEnterAmount.AutoSize = true;
            this.lblEnterAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEnterAmount.Location = new System.Drawing.Point(149, 17);
            this.lblEnterAmount.Name = "lblEnterAmount";
            this.lblEnterAmount.Size = new System.Drawing.Size(116, 21);
            this.lblEnterAmount.TabIndex = 0;
            this.lblEnterAmount.Text = "Enter Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAmount.Location = new System.Drawing.Point(86, 43);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(258, 27);
            this.txtAmount.TabIndex = 1;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Firebrick;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(144, 80);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(141, 28);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "💸 Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(870, 598);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpClient);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.grpAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw Money";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.grpAmount.ResumeLayout(false);
            this.grpAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAdminName;

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearchClient;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblNationalIDTitle;
        private System.Windows.Forms.Label lblNationalID;

        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblAccountNumberTitle;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblBalance;

        private System.Windows.Forms.GroupBox grpAmount;
        private System.Windows.Forms.Label lblEnterAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnWithdraw;
    }
}