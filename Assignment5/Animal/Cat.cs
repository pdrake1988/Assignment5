using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Animal
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string description)
            : base(name, age, description) { }

        public string FurColor { get; set; }
        public string Breed { get; set; }
    }
}
