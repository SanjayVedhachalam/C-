using System;
using Assignment_4;
namespace Assignment4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine();
        CircleCalculator circleCalculator=new CircleCalculator();
        circleCalculator.Area(7);
        System.Console.WriteLine();
        CylinderCalculator cylinderCalculator=new CylinderCalculator();
        cylinderCalculator.Height=12;
        cylinderCalculator.Area(7);
        cylinderCalculator.Volume(14);
        System.Console.WriteLine();
    }
}