using System;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the start limit: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter the end limit: ");
        int end = int.Parse(Console.ReadLine());
        int sum=0;
        for (int i=start;i<=end;i++){
            sum+=(i*i);
        }
        Console.WriteLine($"The sum of the squares present between {start} and {end} is {sum}");

    }
}