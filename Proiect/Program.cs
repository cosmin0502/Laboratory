using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> values = new List<string>();
        values.Add("Patrat");
        values.Add("Triunghi");
        values.Add("Dreptunghi");

        List<string> formula = new List<string>();
        formula.Add("l*l");
        formula.Add("(B*h)/2");
        formula.Add("L*l");
              
        for (int i = 0; i < values.Count; i++)
        {            
            string value = values[i];
            string valuess = formula[i];
            Console.WriteLine($"Area of {value} is calculated using this formula: {valuess}");
        }
    }   
}