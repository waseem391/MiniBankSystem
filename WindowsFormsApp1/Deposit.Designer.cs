using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Deposit
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
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.lblClientTitle = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.lblAccountTitle = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.pnlDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAdminName.ForeColor = System.Drawing.Color.White;
            this.lblAdminName.Location = new System.Drawing.Point(780, 30);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(102, 21);
            this.lblAdminName.TabIndex = 1;
            this.lblAdminName.Text = "Admin Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏦 Deposit Money";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblAdminName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Location = new System.Drawing.Point(40, 110);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(900, 90);
            this.pnlSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(20, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(137, 21);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "🔎 Search Client";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(20, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(600, 29);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(650, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnlClient
            // 
            this.pnlClient.BackColor = System.Drawing.Color.White;
            this.pnlClient.Controls.Add(this.lblClientTitle);
            this.pnlClient.Controls.Add(this.lblClientName);
            this.pnlClient.Controls.Add(this.lblClientPhone);
            this.pnlClient.Controls.Add(this.lblClientID);
            this.pnlClient.Location = new System.Drawing.Point(40, 230);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(420, 200);
            this.pnlClient.TabIndex = 2;
            // 
            // lblClientTitle
            // 
            this.lblClientTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblClientTitle.Location = new System.Drawing.Point(20, 20);
            this.lblClientTitle.Name = "lblClientTitle";
            this.lblClientTitle.Size = new System.Drawing.Size(100, 23);
            this.lblClientTitle.TabIndex = 0;
            this.lblClientTitle.Text = "👤 Client Information";
            // 
            // lblClientName
            // 
            this.lblClientName.Location = new System.Drawing.Point(25, 70);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(100, 23);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Name:";
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.Location = new System.Drawing.Point(25, 110);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(100, 23);
            this.lblClientPhone.TabIndex = 2;
            this.lblClientPhone.Text = "Phone:";
            // 
            // lblClientID
            // 
            this.lblClientID.Location = new System.Drawing.Point(25, 150);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(100, 23);
            this.lblClientID.TabIndex = 3;
            this.lblClientID.Text = "National ID:";
            // 
            // pnlAccount
            // 
            this.pnlAccount.BackColor = System.Drawing.Color.White;
            this.pnlAccount.Controls.Add(this.lblAccountTitle);
            this.pnlAccount.Controls.Add(this.lblAccountNumber);
            this.pnlAccount.Controls.Add(this.lblBalance);
            this.pnlAccount.Location = new System.Drawing.Point(520, 230);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(420, 200);
            this.pnlAccount.TabIndex = 3;
            // 
            // lblAccountTitle
            // 
            this.lblAccountTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAccountTitle.Location = new System.Drawing.Point(20, 20);
            this.lblAccountTitle.Name = "lblAccountTitle";
            this.lblAccountTitle.Size = new System.Drawing.Size(100, 23);
            this.lblAccountTitle.TabIndex = 0;
            this.lblAccountTitle.Text = "💳 Account Details";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.Location = new System.Drawing.Point(25, 80);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(100, 23);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBalance.Location = new System.Drawing.Point(25, 130);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(100, 23);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance: 0 JD";
            // 
            // pnlDeposit
            // 
            this.pnlDeposit.BackColor = System.Drawing.Color.White;
            this.pnlDeposit.Controls.Add(this.lblAmount);
            this.pnlDeposit.Controls.Add(this.txtAmount);
            this.pnlDeposit.Controls.Add(this.btnDeposit);
            this.pnlDeposit.Location = new System.Drawing.Point(250, 470);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(500, 120);
            this.pnlDeposit.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAmount.Location = new System.Drawing.Point(170, 15);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 23);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Enter Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtAmount.Location = new System.Drawing.Point(100, 50);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(300, 34);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Green;
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(170, 90);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(160, 35);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "💰 Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            // 
            // Deposit
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.pnlAccount);
            this.Controls.Add(this.pnlDeposit);
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit Money";
            this.Load += new System.EventHandler(this.Deposit_Load_1);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlClient.ResumeLayout(false);
            this.pnlAccount.ResumeLayout(false);
            this.pnlDeposit.ResumeLayout(false);
            this.pnlDeposit.PerformLayout();
            this.ResumeLayout(false);

        }
        private Panel pnlHeader;
        private Panel pnlSearch;
        private Panel pnlClient;
        private Panel pnlAccount;
        private Panel pnlDeposit;

        private Label lblTitle;
        private Label lblSearch;
        private Label lblClientTitle;
        private Label lblClientName;
        private Label lblClientPhone;
        private Label lblClientID;

        private Label lblAccountTitle;
        private Label lblAccountNumber;
        private Label lblBalance;

        private Label lblAmount;

        private TextBox txtSearch;
        private TextBox txtAmount;

        private Button btnSearch;
        private Button btnDeposit;

        #endregion

        private System.Windows.Forms.Label lblAdminName;
    }
}