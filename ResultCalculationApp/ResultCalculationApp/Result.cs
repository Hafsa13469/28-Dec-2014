using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultCalculationApp
{
    class Result
    {
        private double physicsMarks;
        private double chemistryMarks;
        private double mathMarks;
        private double average;
       
        private string gradeLetter;

        public Result(double physicsMarks, double chemistryMarks, double mathMarks)
        {
            PhysicsMarks = physicsMarks;
            ChemistryMarks = chemistryMarks;
            MathMarks = mathMarks;
        }


        public double PhysicsMarks
        {
            set { physicsMarks = value; }
        }

        public double ChemistryMarks
        {
            set { chemistryMarks = value; }

        }

        public double MathMarks
        {
            set { mathMarks = value; }
        }

        public double Average
        {
            get { return average; }
        }
        
        public void CalculateAverage()
        {
            average = (physicsMarks + chemistryMarks + mathMarks)/3;
        }

        public string Grade
        {
            get { return gradeLetter; }
        }

        public void CalculateGrade()
        {
            if (average>= 80)
            {
                gradeLetter = "A+";
            }
            else if (average >= 70)
            {
                gradeLetter = "B+";
            }
            else if (average >= 60)
            {
                gradeLetter = "C+";
            }
            else if (average >= 50)
            {
                gradeLetter = "D+";
            }
            else if (average <50)
            {
                gradeLetter = "F";
            }

            
        }

        public object A { get; set; }
    }
}
