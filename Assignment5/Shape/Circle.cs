using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Shape
{
    public class Circle : Shape
    {
        Circle(double area, double perimeter, double radius)
            : base(area, perimeter)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
}
