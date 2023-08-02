using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Shape
{
    public class Shape
    {
        public Shape(double area, double perimeter)
        {
            this.Area = area;
            this.Perimeter = perimeter;
        }

        public double Area { get; set; }
        public double Perimeter { get; set; }
    }
}
