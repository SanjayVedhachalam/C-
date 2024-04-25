using System;
using System.Collections.Generic;
namespace Assignment1;
class Program{
    public static void Main(string[] args)
    {
        Dog dog1=new Dog("Biscuit","Dobberman","Pedigiree");
        Dog dog2=new Dog("Toby","Labrador","Pedigiree");
        Duck duck1=new Duck("Peach","Green Beak","Bread");
        Duck duck2=new Duck("Drops","Yellow Beak","Bread");
        System.Console.WriteLine("-----------------------------------");
        dog1.DisplayInfo();
        System.Console.WriteLine("-----------------------------------");
        dog2.DisplayInfo();
        System.Console.WriteLine("-----------------------------------");
        duck1.DisplayInfo();
        System.Console.WriteLine("-----------------------------------");
        duck2.DisplayInfo();
        System.Console.WriteLine("-----------------------------------");
        
        
    }
}