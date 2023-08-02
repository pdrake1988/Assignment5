using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Animal
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string description, string furColor, string breed)
            : base(name, age, description)
        {
            this.FurColor = furColor;
            this.Breed = breed;
        }

        public string FurColor { get; set; }
        public string Breed { get; set; }
    }
}
