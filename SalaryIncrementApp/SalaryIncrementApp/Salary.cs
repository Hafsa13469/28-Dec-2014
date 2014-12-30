using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryIncrementApp
{
    class Salary
    {
        public double BasicAmount { set; get; }
        public Salary(double basic, double medicalPercent, double convPercent)
        {
            BasicAmount = basic;
            MedicalPercent = medicalPercent;
            ConvPercent = convPercent;
        }

        public double ConvPercent { get; set; }

        public double MedicalPercent { get; set; }
        public int NoOfIncrements { get; private set; }


        public double GetMedicalAmount()
        {
            return (MedicalPercent*BasicAmount)/100;
        }

        public double GetConveyance()
        {
            return (ConvPercent*BasicAmount)/100;
        }

        public double TotalSalary()
        {
            return BasicAmount + GetMedicalAmount() + GetConveyance();
        }

        public void Increase(double basicPercentToBeIncreased)
        {
            double amountToBeIncreased = (basicPercentToBeIncreased * BasicAmount) / 100;
            BasicAmount += amountToBeIncreased;
            NoOfIncrements++;
        }

       
    }
}
