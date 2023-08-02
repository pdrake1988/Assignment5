using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Animal
{
    public class Animal
    {
        public Animal(string name, int age, string description)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
    }
}
