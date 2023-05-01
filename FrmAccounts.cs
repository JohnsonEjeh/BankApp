using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AccountsApp
{
    public partial class FrmAccounts : Form
    {
        private List<Account> accounts = new List<Account>();

        public FrmAccounts()
        {
            InitializeComponent();
        }

        private void rbtnChecking_Click(object sender, EventArgs e)
        {
            txtDailyWithdrawLimit.Enabled = true;
            txtInterestRate.Enabled = false;
        }

        private void rbtnSavings_Click(object sender, EventArgs e)
        {
            txtDailyWithdrawLimit.Enabled = false;
            txtInterestRate.Enabled = true;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                int number = 0;
                if (!int.TryParse(txtAccountNumber.Text, out number))
                {
                    throw new ArgumentException("Account number must be an integer.");
                }

                string name = txtClientName.Text.Trim();
                if (!string.IsNullOrEmpty(name) && !name.All(char.IsLetter))
                {
                    throw new ArgumentException("Client name can only contain letters.");
                }

                double balance = 0.0;
                if (!double.TryParse(txtBalance.Text, out balance))
                {
                    throw new ArgumentException("Balance must be a valid number.");
                }

                double limit = 0.0;
                if (rbtnChecking.Checked && !double.TryParse(txtDailyWithdrawLimit.Text, out limit))
                {
                    throw new ArgumentException("Daily Withdraw Limit must be a valid number.");
                }

                double interest = 0.0;
                if (rbtnSavings.Checked && !double.TryParse(txtInterestRate.Text, out interest))
                {
                    throw new ArgumentException("Interest Rate must be a valid number.");
                }

                if (rbtnChecking.Checked)
                {
                    CheckingAccount user = new CheckingAccount(number, name, balance, limit);
                    accounts.Add(user);
                }
                else
                {
                    SavingsAccount user1 = new SavingsAccount(number, name, balance, interest);
                    accounts.Add(user1);
                }

                txtAccountNumber.Text = "";
                txtBalance.Text = "";
                txtClientName.Text = "";
                txtDailyWithdrawLimit.Text = "";
                txtInterestRate.Text = "";

                rbtnChecking.Checked = true;
                txtDailyWithdrawLimit.Enabled = true;
                txtInterestRate.Enabled = false;

                MessageBox.Show($"Total Number of Accounts: {accounts.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int accountNumber = int.Parse(txtSearch.Text);

                Account foundAccount = null;

                foreach (Account account in accounts)
                {
                    if (account.Number == accountNumber)
                    {
                        foundAccount = account;
                        break; // exit the loop once the account is found
                    }
                }
                if (foundAccount != null)
                {
                    // Populate the GUI with the found account information
                    txtAccountNumber.Text = foundAccount.Number.ToString();
                    txtClientName.Text = foundAccount.Name;
                    txtBalance.Text = foundAccount.Balance.ToString();

                    // Check if the found account is a SavingsAccount or a CheckingAccount and update the GUI accordingly
                    if (foundAccount is SavingsAccount savingsAccount)
                    {
                        txtInterestRate.Text = savingsAccount.Interest.ToString();
                    }
                    else if (foundAccount is CheckingAccount checkingAccount)
                    {
                        txtDailyWithdrawLimit.Text = checkingAccount.Limit.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Account not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }






        }
    }
}
