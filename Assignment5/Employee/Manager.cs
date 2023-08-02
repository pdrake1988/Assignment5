using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Employee
{
    public class Manager : Employee
    {
        public Manager(
            string name,
            string address,
            string title,
            double salary,
            List<Employee> employees
        )
            : base(name, address, title, salary)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees { get; set; }
        public string Description { get; set; }
    }
}
