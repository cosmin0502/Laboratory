using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect
{
    class Square : Shape
    {
        public double Length { get; set; }        
        public Square(double length)
        {
            Name = "Square";
            Length = length;
            Formula = "l*l";
        }
        public override double Area()
        {
            return Length * Length;
        }
        
    }
}