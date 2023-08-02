using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Employee
{
    public class Employee
    {
        public Employee(string name, string address, string title, double salary)
        {
            this.Name = name;
            this.Address = address;
            this.Title = title;
            this.Salary = salary;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public double Salary { get; set; }
    }
}
