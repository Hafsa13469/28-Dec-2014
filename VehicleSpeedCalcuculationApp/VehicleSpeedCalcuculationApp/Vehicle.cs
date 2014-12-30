using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSpeedCalcuculationApp
{
    class Vehicle
    {
        private string name;
        private string regNo;
        private double inputSpeed;
        private double minSpeed;
        private double maxSpeed;
        private double averageSpeed;
        private double totalSpeed;
        private int count;

        public string Name
        {
            set { name = value; }
        }

        public string RegNo
        {
            set { regNo = value; }
        }

        public double InputSpeed
        {
            set { inputSpeed = value; }
        }

        public double MinSpeed
        {
            get { return minSpeed; }
        }

        public double MaxSpeed
        {
            get { return maxSpeed; }
        }

        public double AverageSpeed
        {
            get { return averageSpeed; }
        }

        public Vehicle(string name, string regNo)
        {
            Name = name;
            RegNo = regNo;
        }

        public void GetMinSpeed()
        {
            if (inputSpeed<MinSpeed || MinSpeed == 0)
            {
                minSpeed = inputSpeed;
            }
        }

        public void GetMaxSpeed()
        {
            if (inputSpeed>MaxSpeed  || MaxSpeed == 0)
            {
                maxSpeed = inputSpeed;
            }
        }

        public void GetAverageSpeed()
        {
            count++;
            totalSpeed += inputSpeed;

            if (AverageSpeed == 0)
            {
                averageSpeed = inputSpeed;
            }
            else
            {
                averageSpeed = totalSpeed /count;
            }
        }


        
    }
}
