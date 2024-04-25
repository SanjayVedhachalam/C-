using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class CylinderCalculator : Calculator
    {
        public double Height { get; set; }
        public override void Area(double radius)
        {
            double area=2*Math.PI*radius*(radius+Height);
            System.Console.WriteLine("The Area of the Cylinder is "+double.Round(area,2));
        }
        public void Volume(double radius){
            double volume=Math.PI*radius*radius*Height;
            System.Console.WriteLine("The Volume of the Cylinder is "+double.Round(volume,2));
        }
    }
}