using System;
using Abstraction;
namespace Assignment1;
class Program
{
    public static void Main(string[] args)
    {
        Cylinders cylinder = new Cylinders(7, 10);
        Cubes cube = new Cubes(10);

        System.Console.WriteLine($"The area of the Cyliner is {cylinder.CalculateArea()}");
        System.Console.WriteLine($"The volume of the Cyliner is {cylinder.CalculateVolume()}");
        System.Console.WriteLine("_________________________________________________");
        System.Console.WriteLine($"The area of the Cube is {cube.CalculateArea()}");
        System.Console.WriteLine($"The volume of the Cube is {cube.CalculateVolume()}");
    }
}