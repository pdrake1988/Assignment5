using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.School
{
    public class Student : Person
    {
        public Student(
            string name,
            int age,
            string gender,
            List<string> classes,
            string homeAddress,
            Tuple<string, string> parents,
            List<int> grades
        )
            : base(name, age, gender)
        {
            Classes = classes;
            HomeAddress = homeAddress;
            Parents = parents;
            Grades = grades;
        }

        public List<string> Classes { get; set; }
        public string HomeAddress { get; set; }
        public Tuple<string, string> Parents { get; set; }
        public List<int> Grades { get; set; }
    }
}
