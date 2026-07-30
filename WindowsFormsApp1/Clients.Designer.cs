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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.Location = new System.Drawing.Point(20, 195);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.RowTemplate.Height = 30;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(860, 345);
            this.dgvClients.TabIndex = 0;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(740, 135);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(140, 45);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = false;
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnEditClient.FlatAppearance.BorderSize = 0;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.Location = new System.Drawing.Point(585, 135);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(140, 45);
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
            this.pnlClientInfo.Size = new System.Drawing.Size(420, 160);
            this.pnlClientInfo.TabIndex = 4;
            // 
            // lblAmountVal
            // 
            this.lblAmountVal.AutoSize = true;
            this.lblAmountVal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAmountVal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAmountVal.Location = new System.Drawing.Point(120, 123);
            this.lblAmountVal.Name = "lblAmountVal";
            this.lblAmountVal.Size = new System.Drawing.Size(80, 17);
            this.lblAmountVal.TabIndex = 9;
            this.lblAmountVal.Text = "Amount val";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAmount.Location = new System.Drawing.Point(15, 123);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(62, 17);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount:";
            // 
            // lblBankAccountVal
            // 
            this.lblBankAccountVal.AutoSize = true;
            this.lblBankAccountVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBankAccountVal.ForeColor = System.Drawing.Color.Black;
            this.lblBankAccountVal.Location = new System.Drawing.Point(120, 96);
            this.lblBankAccountVal.Name = "lblBankAccountVal";
            this.lblBankAccountVal.Size = new System.Drawing.Size(105, 17);
            this.lblBankAccountVal.TabIndex = 7;
            this.lblBankAccountVal.Text = "Bank Account val";
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBankAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBankAccount.Location = new System.Drawing.Point(15, 96);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(96, 17);
            this.lblBankAccount.TabIndex = 6;
            this.lblBankAccount.Text = "Bank Account:";
            // 
            // lblPhoneNumberVal
            // 
            this.lblPhoneNumberVal.AutoSize = true;
            this.lblPhoneNumberVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhoneNumberVal.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumberVal.Location = new System.Drawing.Point(120, 69);
            this.lblPhoneNumberVal.Name = "lblPhoneNumberVal";
            this.lblPhoneNumberVal.Size = new System.Drawing.Size(116, 17);
            this.lblPhoneNumberVal.TabIndex = 5;
            this.lblPhoneNumberVal.Text = "Phone Number val";
            // 
            // lblNationalIDVal
            // 
            this.lblNationalIDVal.AutoSize = true;
            this.lblNationalIDVal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNationalIDVal.ForeColor = System.Drawing.Color.Black;
            this.lblNationalIDVal.Location = new System.Drawing.Point(120, 42);
            this.lblNationalIDVal.Name = "lblNationalIDVal";
            this.lblNationalIDVal.Size = new System.Drawing.Size(93, 17);
            this.lblNationalIDVal.TabIndex = 4;
            this.lblNationalIDVal.Text = "National ID val";
            // 
            // lblFullNameval
            // 
            this.lblFullNameval.AutoSize = true;
            this.lblFullNameval.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFullNameval.ForeColor = System.Drawing.Color.Black;
            this.lblFullNameval.Location = new System.Drawing.Point(120, 15);
            this.lblFullNameval.Name = "lblFullNameval";
            this.lblFullNameval.Size = new System.Drawing.Size(86, 17);
            this.lblFullNameval.TabIndex = 3;
            this.lblFullNameval.Text = "Full Name val";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(15, 69);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(106, 17);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblNationalID
            // 
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNationalID.Location = new System.Drawing.Point(15, 42);
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size(83, 17);
            this.lblNationalID.TabIndex = 1;
            this.lblNationalID.Text = "National ID:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFullName.Location = new System.Drawing.Point(15, 15);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(75, 17);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.pnlClientInfo);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.dgvClients);
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.pnlClientInfo.ResumeLayout(false);
            this.pnlClientInfo.PerformLayout();
            this.ResumeLayout(false);

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
    }
}