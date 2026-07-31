namespace WindowsFormsApp1
{
    partial class Clients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.pnlClientInfo = new System.Windows.Forms.Panel();
            this.lblAmountVal = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBankAccountVal = new System.Windows.Forms.Label();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.lblPhoneNumberVal = new System.Windows.Forms.Label();
            this.lblNationalIDVal = new System.Windows.Forms.Label();
            this.lblFullNameval = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnMainForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.pnlClientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClients.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.dgvClients.Location = new System.Drawing.Point(20, 230);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.RowTemplate.Height = 36;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(860, 310);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.SelectionChanged += new System.EventHandler(this.dgvClients_SelectionChanged);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(735, 135);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(145, 42);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "+ Add Client";
            this.btnAddClient.UseVisualStyleBackColor = false;
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnEditClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnEditClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnEditClient.Location = new System.Drawing.Point(595, 135);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(130, 42);
            this.btnEditClient.TabIndex = 3;
            this.btnEditClient.Text = "Edit Client";
            this.btnEditClient.UseVisualStyleBackColor = false;
            // 
            // pnlClientInfo
            // 
            this.pnlClientInfo.BackColor = System.Drawing.Color.White;
            this.pnlClientInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClientInfo.Controls.Add(this.lblAmountVal);
            this.pnlClientInfo.Controls.Add(this.lblAmount);
            this.pnlClientInfo.Controls.Add(this.lblBankAccountVal);
            this.pnlClientInfo.Controls.Add(this.lblBankAccount);
            this.pnlClientInfo.Controls.Add(this.lblPhoneNumberVal);
            this.pnlClientInfo.Controls.Add(this.lblNationalIDVal);
            this.pnlClientInfo.Controls.Add(this.lblFullNameval);
            this.pnlClientInfo.Controls.Add(this.lblPhoneNumber);
            this.pnlClientInfo.Controls.Add(this.lblNationalID);
            this.pnlClientInfo.Controls.Add(this.lblFullName);
            this.pnlClientInfo.Location = new System.Drawing.Point(20, 20);
            this.pnlClientInfo.Name = "pnlClientInfo";
            this.pnlClientInfo.Size = new System.Drawing.Size(460, 160);
            this.pnlClientInfo.TabIndex = 4;
            this.pnlClientInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClientInfo_Paint);
            // 
            // lblAmountVal
            // 
            this.lblAmountVal.AutoSize = true;
            this.lblAmountVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAmountVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblAmountVal.Location = new System.Drawing.Point(135, 123);
            this.lblAmountVal.Name = "lblAmountVal";
            this.lblAmountVal.Size = new System.Drawing.Size(86, 19);
            this.lblAmountVal.TabIndex = 9;
            this.lblAmountVal.Text = "Amount val";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblAmount.Location = new System.Drawing.Point(18, 124);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(62, 17);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount:";
            // 
            // lblBankAccountVal
            // 
            this.lblBankAccountVal.AutoSize = true;
            this.lblBankAccountVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBankAccountVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblBankAccountVal.Location = new System.Drawing.Point(135, 97);
            this.lblBankAccountVal.Name = "lblBankAccountVal";
            this.lblBankAccountVal.Size = new System.Drawing.Size(105, 17);
            this.lblBankAccountVal.TabIndex = 7;
            this.lblBankAccountVal.Text = "Bank Account val";
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBankAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblBankAccount.Location = new System.Drawing.Point(18, 97);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(96, 17);
            this.lblBankAccount.TabIndex = 6;
            this.lblBankAccount.Text = "Bank Account:";
            // 
            // lblPhoneNumberVal
            // 
            this.lblPhoneNumberVal.AutoSize = true;
            this.lblPhoneNumberVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhoneNumberVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblPhoneNumberVal.Location = new System.Drawing.Point(135, 70);
            this.lblPhoneNumberVal.Name = "lblPhoneNumberVal";
            this.lblPhoneNumberVal.Size = new System.Drawing.Size(116, 17);
            this.lblPhoneNumberVal.TabIndex = 5;
            this.lblPhoneNumberVal.Text = "Phone Number val";
            // 
            // lblNationalIDVal
            // 
            this.lblNationalIDVal.AutoSize = true;
            this.lblNationalIDVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNationalIDVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblNationalIDVal.Location = new System.Drawing.Point(135, 43);
            this.lblNationalIDVal.Name = "lblNationalIDVal";
            this.lblNationalIDVal.Size = new System.Drawing.Size(93, 17);
            this.lblNationalIDVal.TabIndex = 4;
            this.lblNationalIDVal.Text = "National ID val";
            // 
            // lblFullNameval
            // 
            this.lblFullNameval.AutoSize = true;
            this.lblFullNameval.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFullNameval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblFullNameval.Location = new System.Drawing.Point(135, 16);
            this.lblFullNameval.Name = "lblFullNameval";
            this.lblFullNameval.Size = new System.Drawing.Size(93, 17);
            this.lblFullNameval.TabIndex = 3;
            this.lblFullNameval.Text = "Full Name val";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(18, 70);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(106, 17);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblNationalID
            // 
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblNationalID.Location = new System.Drawing.Point(18, 43);
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size(83, 17);
            this.lblNationalID.TabIndex = 1;
            this.lblNationalID.Text = "National ID:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblFullName.Location = new System.Drawing.Point(18, 16);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(75, 17);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // tbsearch
            // 
            this.tbsearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.tbsearch.Location = new System.Drawing.Point(160, 194);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(280, 25);
            this.tbsearch.TabIndex = 5;
            this.tbsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblSearch.Location = new System.Drawing.Point(20, 198);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(134, 17);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search About Client:";
            // 
            // btnMainForm
            // 
            this.btnMainForm.BackColor = System.Drawing.Color.DimGray;
            this.btnMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.btnMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMainForm.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMainForm.Location = new System.Drawing.Point(762, 12);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(135, 34);
            this.btnMainForm.TabIndex = 11;
            this.btnMainForm.Text = "Back to Main";
            this.btnMainForm.UseVisualStyleBackColor = false;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.btnMainForm);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.pnlClientInfo);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.dgvClients);
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients Management";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.pnlClientInfo.ResumeLayout(false);
            this.pnlClientInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Panel pnlClientInfo;
        private System.Windows.Forms.Label lblNationalIDVal;
        private System.Windows.Forms.Label lblFullNameval;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAmountVal;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblBankAccountVal;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.Label lblPhoneNumberVal;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnMainForm;
    }
}