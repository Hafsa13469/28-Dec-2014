using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultCalculationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double physicsMarks = Convert.ToDouble(physicsInputTextBox.Text);
            double chemistryMarks = Convert.ToDouble(chemistryInputTextBox.Text);
            double mathMarks = Convert.ToDouble(mathInputTextBox.Text);

            Result aResult = new Result(physicsMarks, chemistryMarks, mathMarks);
            aResult.CalculateAverage();
            aResult.CalculateGrade();

            showAverageTextBox.Text = Convert.ToString(aResult.Average);
            showGradeLetterTextBox.Text = aResult.Grade.ToString();
        }
    }
}
