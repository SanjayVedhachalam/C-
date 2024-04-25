using System;
using System.Transactions;
namespace TypeConversion;
class Program{
    public static void Main(string[] args)
    {
        // Input

        Console.Write("Enter your name: ");
        string name=Console.ReadLine();
        Console.Write("Enter age: ");
        int age=int.Parse(Console.ReadLine());
        Console.Write("Enter  mark of subject1: ");
        float sub1=float.Parse(Console.ReadLine());
        Console.Write("Enter  mark of subject2: ");
        float sub2=float.Parse(Console.ReadLine());
        Console.Write("Enter  mark of subject3: ");
        float sub3=float.Parse(Console.ReadLine());
        Console.Write("Enter Grade: ");
        char grade=char.Parse(Console.ReadLine());
        Console.Write("Enter mobile number: ");
        long mbnum=long.Parse(Console.ReadLine());
        Console.Write("Enter Mail id: ");
        string email=Console.ReadLine();
        double avg=(sub1+sub2+sub3)/3;


        // Output
        Console.WriteLine("Trainee Details Are:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Mobile: {mbnum}");
        Console.WriteLine($"Marks1: {sub1}");
        Console.WriteLine($"Marks2: {sub2}");
        Console.WriteLine($"Marks3: {sub3}");
        Console.WriteLine($"Total: {sub1+sub2+sub3}");
        Console.WriteLine($"Average: {double.Round(avg,1)}");
        Console.WriteLine($"Mail id: {email}");

    }
}