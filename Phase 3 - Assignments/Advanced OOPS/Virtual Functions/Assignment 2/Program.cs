using System;
using System.Buffers;
using System.Runtime.InteropServices;
using Assignment_2;
namespace Assignment2;
class Program{
    public static void Main(string[] args)
    {
        Dimension dimension=new Dimension(5,6);
        Rectangle rectangle=new Rectangle(3,4);
        Sphere sphere=new Sphere(7);
        dimension.Calculate();
        System.Console.WriteLine($"Dimension value is: {dimension.DisplayArea()}");
        rectangle.Calculate();
        System.Console.WriteLine($"Dimension value is: {rectangle.DisplayArea()}");
        sphere.Calculate();
        System.Console.WriteLine($"Dimension value is: {sphere.DisplayArea()}");
    }
}