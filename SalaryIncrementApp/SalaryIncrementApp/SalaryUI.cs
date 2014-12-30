using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryIncrementApp
{
    public partial class SalaryUI : Form
    {
        private Employee aEmployee;
        private Salary aSalary;
        public SalaryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aEmployee = new Employee(idTextBox.Text, nameTextBox.Text, emailEntryTextBox.Text);
            double basic = Convert.ToDouble(basicSalaryEntryTextBox.Text);
            double medicalPercent = Convert.ToDouble(medicalEntryTextBox.Text);
            double convPercent = Convert.ToDouble(conveyanceTextBox.Text);
            Salary aSalary = new Salary(basic, medicalPercent, convPercent);
            aEmployee.EmployeeSalary = aSalary;
            MessageBox.Show("Saved");

            


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            incrementTextBox.Text = aEmployee.EmployeeSalary.NoOfIncrements.ToString();
            showBasicTextBox.Text = aEmployee.EmployeeSalary.BasicAmount.ToString();
            showMedicalTextBox.Text = aEmployee.EmployeeSalary.MedicalPercent.ToString();
            showConveyanceTextBox.Text = aEmployee.EmployeeSalary.ConvPercent.ToString();
            showTotalBalanceTextBox.Text = aEmployee.EmployeeSalary.TotalSalary().ToString();
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            double basicPercentToBeIncreased = Convert.ToDouble(incrementTextBox.Text);
            aEmployee.EmployeeSalary.Increase(basicPercentToBeIncreased);
            MessageBox.Show("Salary increased");
        }
    }
}
