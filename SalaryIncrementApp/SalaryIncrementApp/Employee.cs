using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryIncrementApp
{
    class Employee
    {
        public Employee(string id, string name, string email)
        {
            Id =id;
            Name = name;
            Email = email;
        }
        public string Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }

        public Salary EmployeeSalary { set; get; }
        

    }
}
