namespace AccountsApp
{
    partial class FrmAccounts
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
            this.grpAccountDetails = new System.Windows.Forms.GroupBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtDailyWithdrawLimit = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.grpTypeOfAccount = new System.Windows.Forms.GroupBox();
            this.rbtnSavings = new System.Windows.Forms.RadioButton();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpAccountDetails.SuspendLayout();
            this.grpTypeOfAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccountDetails
            // 
            this.grpAccountDetails.Controls.Add(this.txtClientName);
            this.grpAccountDetails.Controls.Add(this.txtBalance);
            this.grpAccountDetails.Controls.Add(this.txtDailyWithdrawLimit);
            this.grpAccountDetails.Controls.Add(this.txtInterestRate);
            this.grpAccountDetails.Controls.Add(this.txtAccountNumber);
            this.grpAccountDetails.Controls.Add(this.grpTypeOfAccount);
            this.grpAccountDetails.Controls.Add(this.lblInterestRate);
            this.grpAccountDetails.Controls.Add(this.lblClientName);
            this.grpAccountDetails.Controls.Add(this.label2);
            this.grpAccountDetails.Controls.Add(this.label1);
            this.grpAccountDetails.Controls.Add(this.lblAccountNumber);
            this.grpAccountDetails.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccountDetails.Location = new System.Drawing.Point(27, 30);
            this.grpAccountDetails.Name = "grpAccountDetails";
            this.grpAccountDetails.Size = new System.Drawing.Size(867, 412);
            this.grpAccountDetails.TabIndex = 0;
            this.grpAccountDetails.TabStop = false;
            this.grpAccountDetails.Text = "Account Details";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(242, 117);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(255, 27);
            this.txtClientName.TabIndex = 11;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(242, 178);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 27);
            this.txtBalance.TabIndex = 10;
            // 
            // txtDailyWithdrawLimit
            // 
            this.txtDailyWithdrawLimit.Location = new System.Drawing.Point(242, 224);
            this.txtDailyWithdrawLimit.Name = "txtDailyWithdrawLimit";
            this.txtDailyWithdrawLimit.Size = new System.Drawing.Size(100, 27);
            this.txtDailyWithdrawLimit.TabIndex = 9;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(242, 272);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 27);
            this.txtInterestRate.TabIndex = 8;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(242, 69);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 27);
            this.txtAccountNumber.TabIndex = 7;
            // 
            // grpTypeOfAccount
            // 
            this.grpTypeOfAccount.Controls.Add(this.rbtnSavings);
            this.grpTypeOfAccount.Controls.Add(this.rbtnChecking);
            this.grpTypeOfAccount.Location = new System.Drawing.Point(585, 79);
            this.grpTypeOfAccount.Name = "grpTypeOfAccount";
            this.grpTypeOfAccount.Size = new System.Drawing.Size(240, 160);
            this.grpTypeOfAccount.TabIndex = 6;
            this.grpTypeOfAccount.TabStop = false;
            this.grpTypeOfAccount.Text = "Type of Account";
            // 
            // rbtnSavings
            // 
            this.rbtnSavings.AutoSize = true;
            this.rbtnSavings.Location = new System.Drawing.Point(24, 95);
            this.rbtnSavings.Name = "rbtnSavings";
            this.rbtnSavings.Size = new System.Drawing.Size(81, 26);
            this.rbtnSavings.TabIndex = 1;
            this.rbtnSavings.TabStop = true;
            this.rbtnSavings.Text = "Savings";
            this.rbtnSavings.UseVisualStyleBackColor = true;
            this.rbtnSavings.Click += new System.EventHandler(this.rbtnSavings_Click);
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.Location = new System.Drawing.Point(24, 38);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(90, 26);
            this.rbtnChecking.TabIndex = 0;
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.Text = "Checking";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.Click += new System.EventHandler(this.rbtnChecking_Click);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(84, 272);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(92, 22);
            this.lblInterestRate.TabIndex = 5;
            this.lblInterestRate.Text = "Interest Rate:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(96, 120);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(92, 22);
            this.lblClientName.TabIndex = 3;
            this.lblClientName.Text = "Client Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daily Withdraw Limit:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(67, 69);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(120, 22);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(598, 462);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(283, 77);
            this.btnCreateAccount.TabIndex = 1;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(67, 564);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(188, 16);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Type the index you want to find";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(69, 591);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(97, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(69, 628);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 745);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.grpAccountDetails);
            this.Name = "FrmAccounts";
            this.Text = "Accounts";
            this.grpAccountDetails.ResumeLayout(false);
            this.grpAccountDetails.PerformLayout();
            this.grpTypeOfAccount.ResumeLayout(false);
            this.grpTypeOfAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccountDetails;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtDailyWithdrawLimit;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.GroupBox grpTypeOfAccount;
        private System.Windows.Forms.RadioButton rbtnSavings;
        private System.Windows.Forms.RadioButton rbtnChecking;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

