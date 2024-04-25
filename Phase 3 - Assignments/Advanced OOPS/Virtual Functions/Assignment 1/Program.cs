using System;
using Assignment_1;
namespace Assignment1;
class Program{
    public static void Main(string[] args)
    {
        AreaCalculator area=new AreaCalculator(40);
        VolumeCalculator volume=new VolumeCalculator(area.Radius,12);

        System.Console.WriteLine($"Area of circle is {area.Calculate()}");
        System.Console.WriteLine($"Volume of circle is {volume.Calculate()}");
    }
}