namespace WindowsFormsApp1
{
    partial class Transfer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.pnlFrom = new System.Windows.Forms.Panel();
            this.lblFromTitle = new System.Windows.Forms.Label();
            this.lblFromSearchHint = new System.Windows.Forms.Label();
            this.txtFromSearch = new System.Windows.Forms.TextBox();
            this.btnFromSearch = new System.Windows.Forms.Button();
            this.lblFromName = new System.Windows.Forms.Label();
            this.lblFromAccount = new System.Windows.Forms.Label();
            this.lblFromStatus = new System.Windows.Forms.Label();
            this.lblFromBalanceTitle = new System.Windows.Forms.Label();
            this.lblFromBalance = new System.Windows.Forms.Label();
            this.pnlTo = new System.Windows.Forms.Panel();
            this.lblToTitle = new System.Windows.Forms.Label();
            this.lblToSearchHint = new System.Windows.Forms.Label();
            this.txtToSearch = new System.Windows.Forms.TextBox();
            this.btnToSearch = new System.Windows.Forms.Button();
            this.lblToName = new System.Windows.Forms.Label();
            this.lblToAccount = new System.Windows.Forms.Label();
            this.lblToStatus = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.lblAmountTitle = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlFrom.SuspendLayout();
            this.pnlTo.SuspendLayout();
            this.pnlAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(28)))), ((int)(((byte)(52)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblAdminName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Transfer Money";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(220)))));
            this.lblSubtitle.Location = new System.Drawing.Point(44, 66);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(249, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Move funds securely between accounts";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAdminName.ForeColor = System.Drawing.Color.White;
            this.lblAdminName.Location = new System.Drawing.Point(930, 40);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(97, 20);
            this.lblAdminName.TabIndex = 2;
            this.lblAdminName.Text = "Admin Name";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.lblFrom.Location = new System.Drawing.Point(55, 125);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(49, 19);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "FROM";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.lblTo.Location = new System.Drawing.Point(585, 125);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 19);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "TO";
            // 
            // pnlFrom
            // 
            this.pnlFrom.BackColor = System.Drawing.Color.White;
            this.pnlFrom.Controls.Add(this.lblFromTitle);
            this.pnlFrom.Controls.Add(this.lblFromSearchHint);
            this.pnlFrom.Controls.Add(this.txtFromSearch);
            this.pnlFrom.Controls.Add(this.btnFromSearch);
            this.pnlFrom.Controls.Add(this.lblFromName);
            this.pnlFrom.Controls.Add(this.lblFromAccount);
            this.pnlFrom.Controls.Add(this.lblFromStatus);
            this.pnlFrom.Controls.Add(this.lblFromBalanceTitle);
            this.pnlFrom.Controls.Add(this.lblFromBalance);
            this.pnlFrom.Location = new System.Drawing.Point(50, 150);
            this.pnlFrom.Name = "pnlFrom";
            this.pnlFrom.Size = new System.Drawing.Size(470, 250);
            this.pnlFrom.TabIndex = 3;
            // 
            // lblFromTitle
            // 
            this.lblFromTitle.AutoSize = true;
            this.lblFromTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblFromTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(28)))), ((int)(((byte)(52)))));
            this.lblFromTitle.Location = new System.Drawing.Point(22, 18);
            this.lblFromTitle.Name = "lblFromTitle";
            this.lblFromTitle.Size = new System.Drawing.Size(161, 28);
            this.lblFromTitle.TabIndex = 0;
            this.lblFromTitle.Text = "Sender Account";
            // 
            // lblFromSearchHint
            // 
            this.lblFromSearchHint.AutoSize = true;
            this.lblFromSearchHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFromSearchHint.ForeColor = System.Drawing.Color.Gray;
            this.lblFromSearchHint.Location = new System.Drawing.Point(24, 55);
            this.lblFromSearchHint.Name = "lblFromSearchHint";
            this.lblFromSearchHint.Size = new System.Drawing.Size(175, 15);
            this.lblFromSearchHint.TabIndex = 1;
            this.lblFromSearchHint.Text = "National ID or Account Number";
            // 
            // txtFromSearch
            // 
            this.txtFromSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFromSearch.Location = new System.Drawing.Point(22, 78);
            this.txtFromSearch.Name = "txtFromSearch";
            this.txtFromSearch.Size = new System.Drawing.Size(330, 27);
            this.txtFromSearch.TabIndex = 2;
            // 
            // btnFromSearch
            // 
            this.btnFromSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(28)))), ((int)(((byte)(52)))));
            this.btnFromSearch.FlatAppearance.BorderSize = 0;
            this.btnFromSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFromSearch.ForeColor = System.Drawing.Color.White;
            this.btnFromSearch.Location = new System.Drawing.Point(365, 77);
            this.btnFromSearch.Name = "btnFromSearch";
            this.btnFromSearch.Size = new System.Drawing.Size(80, 30);
            this.btnFromSearch.TabIndex = 3;
            this.btnFromSearch.Text = "Search";
            this.btnFromSearch.UseVisualStyleBackColor = false;
            this.btnFromSearch.Click += new System.EventHandler(this.btnFromSearch_Click);
            // 
            // lblFromName
            // 
            this.lblFromName.AutoSize = true;
            this.lblFromName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFromName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.lblFromName.Location = new System.Drawing.Point(24, 120);
            this.lblFromName.Name = "lblFromName";
            this.lblFromName.Size = new System.Drawing.Size(53, 19);
            this.lblFromName.TabIndex = 4;
            this.lblFromName.Text = "Name:";
            // 
            // lblFromAccount
            // 
            this.lblFromAccount.AutoSize = true;
            this.lblFromAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFromAccount.ForeColor = System.Drawing.Color.Gray;
            this.lblFromAccount.Location = new System.Drawing.Point(24, 145);
            this.lblFromAccount.Name = "lblFromAccount";
            this.lblFromAccount.Size = new System.Drawing.Size(101, 17);
            this.lblFromAccount.TabIndex = 5;
            this.lblFromAccount.Text = "Account: --------";
            // 
            // lblFromStatus
            // 
            this.lblFromStatus.AutoSize = true;
            this.lblFromStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFromStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(75)))));
            this.lblFromStatus.Location = new System.Drawing.Point(24, 170);
            this.lblFromStatus.Name = "lblFromStatus";
            this.lblFromStatus.Size = new System.Drawing.Size(102, 15);
            this.lblFromStatus.TabIndex = 6;
            this.lblFromStatus.Text = "● Account Active";
            // 
            // lblFromBalanceTitle
            // 
            this.lblFromBalanceTitle.AutoSize = true;
            this.lblFromBalanceTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFromBalanceTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblFromBalanceTitle.Location = new System.Drawing.Point(24, 195);
            this.lblFromBalanceTitle.Name = "lblFromBalanceTitle";
            this.lblFromBalanceTitle.Size = new System.Drawing.Size(99, 15);
            this.lblFromBalanceTitle.TabIndex = 6;
            this.lblFromBalanceTitle.Text = "Available Balance";
            // 
            // lblFromBalance
            // 
            this.lblFromBalance.AutoSize = true;
            this.lblFromBalance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblFromBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(28)))), ((int)(((byte)(52)))));
            this.lblFromBalance.Location = new System.Drawing.Point(22, 210);
            this.lblFromBalance.Name = "lblFromBalance";
            this.lblFromBalance.Size = new System.Drawing.Size(90, 30);
            this.lblFromBalance.TabIndex = 7;
            this.lblFromBalance.Text = "0.00 JD";
            // 
            // pnlTo
            // 
            this.pnlTo.BackColor = System.Drawing.Color.White;
            this.pnlTo.Controls.Add(this.lblToTitle);
            this.pnlTo.Controls.Add(this.lblToSearchHint);
            this.pnlTo.Controls.Add(this.txtToSearch);
            this.pnlTo.Controls.Add(this.btnToSearch);
            this.pnlTo.Controls.Add(this.lblToName);
            this.pnlTo.Controls.Add(this.lblToAccount);
            this.pnlTo.Controls.Add(this.lblToStatus);
            this.pnlTo.Location = new System.Drawing.Point(580, 150);
            this.pnlTo.Name = "pnlTo";
            this.pnlTo.Size = new System.Drawing.Size(470, 250);
            this.pnlTo.TabIndex = 4;
            // 
            // lblToTitle
            // 
            this.lblToTitle.AutoSize = true;
            this.lblToTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblToTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(28)))), ((int)(((byte)(52)))));
            this.lblToTitle.Location = new System.Drawing.Point(22, 18);
            this.lblToTitle.Name = "lblToTitle";
            this.lblToTitle.Size = new System.Drawing.Size(177, 28);
            this.lblToTitle.TabIndex = 0;
            this.lblToTitle.Text = "Receiver Account";
            // 
            // lblToSearchHint
            // 
            this.lblToSearchHint.AutoSize = true;
            this.lblToSearchHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblToSearchHint.ForeColor = System.Drawing.Color.Gray;
            this.lblToSearchHint.Location = new System.Drawing.Point(24, 55);
            this.lblToSearchHint.Name = "lblToSearchHint";
            this.lblToSearchHint.Size = new System.Drawing.Size(175, 15);
            this.lblToSearchHint.TabIndex = 1;
            this.lblToSearchHint.Text = "National ID or Account Number";
            // 
            // txtToSearch
            // 
            this.txtToSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtToSearch.Location = new System.Drawing.Point(22, 78);
            this.txtToSearch.Name = "txtToSearch";
            this.txtToSearch.Size = new System.Drawing.Size(330, 27);
            this.txtToSearch.TabIndex = 2;
            // 
            // btnToSearch
            // 
            this.btnToSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(28)))), ((int)(((byte)(52)))));
            this.btnToSearch.FlatAppearance.BorderSize = 0;
            this.btnToSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnToSearch.ForeColor = System.Drawing.Color.White;
            this.btnToSearch.Location = new System.Drawing.Point(365, 77);
            this.btnToSearch.Name = "btnToSearch";
            this.btnToSearch.Size = new System.Drawing.Size(80, 30);
            this.btnToSearch.TabIndex = 3;
            this.btnToSearch.Text = "Search";
            this.btnToSearch.UseVisualStyleBackColor = false;
            this.btnToSearch.Click += new System.EventHandler(this.btnToSearch_Click);
            // 
            // lblToName
            // 
            this.lblToName.AutoSize = true;
            this.lblToName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblToName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.lblToName.Location = new System.Drawing.Point(24, 125);
            this.lblToName.Name = "lblToName";
            this.lblToName.Size = new System.Drawing.Size(53, 19);
            this.lblToName.TabIndex = 4;
            this.lblToName.Text = "Name:";
            // 
            // lblToAccount
            // 
            this.lblToAccount.AutoSize = true;
            this.lblToAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblToAccount.ForeColor = System.Drawing.Color.Gray;
            this.lblToAccount.Location = new System.Drawing.Point(24, 153);
            this.lblToAccount.Name = "lblToAccount";
            this.lblToAccount.Size = new System.Drawing.Size(101, 17);
            this.lblToAccount.TabIndex = 5;
            this.lblToAccount.Text = "Account: --------";
            // 
            // lblToStatus
            // 
            this.lblToStatus.AutoSize = true;
            this.lblToStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(75)))));
            this.lblToStatus.Location = new System.Drawing.Point(24, 190);
            this.lblToStatus.Name = "lblToStatus";
            this.lblToStatus.Size = new System.Drawing.Size(102, 15);
            this.lblToStatus.TabIndex = 6;
            this.lblToStatus.Text = "● Account Active";
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblArrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            this.lblArrow.Location = new System.Drawing.Point(530, 245);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(44, 41);
            this.lblArrow.TabIndex = 5;
            this.lblArrow.Text = "→";
            // 
            // pnlAmount
            // 
            this.pnlAmount.BackColor = System.Drawing.Color.White;
            this.pnlAmount.Controls.Add(this.lblAmountTitle);
            this.pnlAmount.Controls.Add(this.txtAmount);
            this.pnlAmount.Controls.Add(this.lblCurrency);
            this.pnlAmount.Controls.Add(this.btnTransfer);
            this.pnlAmount.Location = new System.Drawing.Point(300, 435);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(500, 190);
            this.pnlAmount.TabIndex = 6;
            // 
            // lblAmountTitle
            // 
            this.lblAmountTitle.AutoSize = true;
            this.lblAmountTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAmountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(105)))));
            this.lblAmountTitle.Location = new System.Drawing.Point(185, 18);
            this.lblAmountTitle.Name = "lblAmountTitle";
            this.lblAmountTitle.Size = new System.Drawing.Size(137, 21);
            this.lblAmountTitle.TabIndex = 0;
            this.lblAmountTitle.Text = "Transfer Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.txtAmount.Location = new System.Drawing.Point(70, 52);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(330, 47);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCurrency.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrency.Location = new System.Drawing.Point(195, 102);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(89, 15);
            this.lblCurrency.TabIndex = 2;
            this.lblCurrency.Text = "Jordanian Dinar";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(115, 131);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(250, 42);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "TRANSFER MONEY";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.pnlFrom);
            this.Controls.Add(this.pnlTo);
            this.Controls.Add(this.lblArrow);
            this.Controls.Add(this.pnlAmount);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Money";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFrom.ResumeLayout(false);
            this.pnlFrom.PerformLayout();
            this.pnlTo.ResumeLayout(false);
            this.pnlTo.PerformLayout();
            this.pnlAmount.ResumeLayout(false);
            this.pnlAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Panel pnlFrom;
        private System.Windows.Forms.Label lblFromTitle;
        private System.Windows.Forms.Label lblFromSearchHint;
        private System.Windows.Forms.TextBox txtFromSearch;
        private System.Windows.Forms.Button btnFromSearch;
        private System.Windows.Forms.Label lblFromName;
        private System.Windows.Forms.Label lblFromAccount;
        private System.Windows.Forms.Label lblFromStatus;
        private System.Windows.Forms.Label lblFromBalanceTitle;
        private System.Windows.Forms.Label lblFromBalance;
        private System.Windows.Forms.Panel pnlTo;
        private System.Windows.Forms.Label lblToTitle;
        private System.Windows.Forms.Label lblToSearchHint;
        private System.Windows.Forms.TextBox txtToSearch;
        private System.Windows.Forms.Button btnToSearch;
        private System.Windows.Forms.Label lblToName;
        private System.Windows.Forms.Label lblToAccount;
        private System.Windows.Forms.Label lblToStatus;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.Panel pnlAmount;
        private System.Windows.Forms.Label lblAmountTitle;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Button btnTransfer;
    }
}