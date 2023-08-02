using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Shape
{
    public class Square : Shape
    {
        public Square(double width, double height, double area, double perimeter)
            : base(area, perimeter)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
    }
}
