using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length,
            double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
            Formula = "L*l";
        }

        public override double Area()
        {
            return Length * Width;
        }
               
    }
}