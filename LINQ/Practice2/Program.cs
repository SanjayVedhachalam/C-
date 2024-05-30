using System;
using System.Collections.Generic;
using System.Linq;
namespace Practice2;
class Program{
    public static void Main(string[] args)
    {
        
        List<string> names = new List<string>();
        string wish = "yes";
        do{
            System.Console.WriteLine("Enter places name");
            string name = Console.ReadLine();
            names.Add(name);
            System.Console.Write("Do you want to continue: ");
            wish = Console.ReadLine().ToLower();
        }while(wish != "no");
        System.Console.WriteLine("Enter start character");
        char startCharacter = char.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter last character");
        char endCharacter = char.Parse(Console.ReadLine());
        
        IEnumerable<string> strings = names.OrderBy(name => name.Length);
        foreach (var name in strings)
        {
            System.Console.WriteLine(name);
        }
    }
}