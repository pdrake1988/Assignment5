using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Payroll
{
    public class Manager : Employee
    {
        public Manager(
            string title,
            float salary,
            string department,
            string description,
            List<Employee> employees,
            string authorizaiton
        )
            : base(title, salary, department, description)
        {
            Employees = employees;
            Authorization = authorizaiton;
        }

        public List<Employee> Employees { get; set; }
        public string Authorization { get; set; }
    }
}
