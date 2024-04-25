using System;
using CalculatorApp;
using Mathslib;
namespace Assignment1;
class Program{
    public static void Main(string[] args)
    {
        Maths maths=new Maths(79.5);
        System.Console.WriteLine("-----------------------------------------------------");
        System.Console.WriteLine($"The weight of the person is {maths.CalculateWeight()}");

        CircleArea circle=new CircleArea(40);
        
        System.Console.WriteLine("-----------------------------------------------------");
        System.Console.WriteLine($"The Area of the Circle is {circle.CalculatorCircleArea()}");

        CylinderVolume cylinder=new CylinderVolume(7);
        System.Console.WriteLine("-----------------------------------------------------");
        System.Console.WriteLine($"The Volume of the Cylinder is {cylinder.CalculateVolume()}");
        System.Console.WriteLine("-----------------------------------------------------");
    }
}