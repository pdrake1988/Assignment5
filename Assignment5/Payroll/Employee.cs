using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Payroll
{
    public class Employee
    {
        public Employee(string title, float salary, string department, string description)
        {
            Title = title;
            Salary = salary;
            Department = department;
            Description = description;
        }

        public string Title { get; set; }
        public float Salary { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
    }
}
