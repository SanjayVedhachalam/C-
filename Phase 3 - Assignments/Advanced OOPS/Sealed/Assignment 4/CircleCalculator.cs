using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class CircleCalculator : Calculator
    {
        public sealed override void Area(double radius)
        {
            System.Console.WriteLine($"The Area of the Circle is {double.Round(Math.PI*radius*radius,2)}");
        }
    }
}