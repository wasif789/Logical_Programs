﻿using System;

namespace TempConv
{
    class Program
    {
        double celsius;
        double fahrenheit;
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;
            Console.WriteLine("Enter value for celsius:");
            celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for Fahrenheit:");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celToFah = (celsius * 9 / 5) + 32;
            double fahToCel = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("After celsius to fahrenheit conversion: {0}", celToFah);
            Console.WriteLine("After fahrenheit to celsius conversion: {0}", fahToCel);
        }
    }
}
