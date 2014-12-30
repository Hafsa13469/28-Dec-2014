using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class BankAccountUI : Form
    {
        private Account anAccount;
        private Customer aCustomer;
        public BankAccountUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            anAccount = new Account();
            anAccount.Number = accountNumberEntryTextBox.Text;
            anAccount.OpeningDate = dateEntryTextBox.Text;

            aCustomer = new Customer();
            aCustomer.Name = customerNameEntryTextBox.Text;
            aCustomer.Email = emailEntryTextBox.Text;

            aCustomer.CustomerAccount = anAccount;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aCustomer.CustomerAccount.Deposit(amount);
                MessageBox.Show("Deposited");
            }
            else
            {
                MessageBox.Show("Create Account First");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                aCustomer.CustomerAccount.Withdraw(amount);
                MessageBox.Show("Withdrawed");
            }
            else
            {
                MessageBox.Show("Create Account First");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            customerNameShowTextBox.Text = aCustomer.Name;
            emailShowTextBox.Text = aCustomer.Email;
            accountNumberShowTextBox.Text = aCustomer.CustomerAccount.Number;
            openingDateShowTextBox.Text = aCustomer.CustomerAccount.OpeningDate;
            showBalanceTextBox.Text = aCustomer.CustomerAccount.Balance.ToString();
        }
    }
}
