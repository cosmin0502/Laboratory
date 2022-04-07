using System;

namespace Proiect
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {
                new Circle(1),
                new Rectangle(1,1),
                new Square(1)};
                        
            foreach (Shape s in shapes)
            {            
                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());
                Console.WriteLine(s.Formula);
            }                 
        }
    }
}
