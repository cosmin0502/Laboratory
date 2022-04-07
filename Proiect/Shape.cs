using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect
{
    abstract class Shape
    {
        public string Name { get; set; }               
        public abstract double Area();

        public string Formula { get; set; }
    }
}