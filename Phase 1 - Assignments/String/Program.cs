using System;
using System.Linq;
namespace String;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a string: ");
        string mainString = Console.ReadLine();
        System.Console.Write("Enter the string to be searched: ");
        string searchString = Console.ReadLine();
        int count=0;
        string[] array=mainString.Split(searchString);
        string str=string.Join(',',array);
        System.Console.WriteLine(str);
        foreach(string var in array){
            count+=1;
        }
        System.Console.WriteLine($"string searched count: {count-1}");
        
    }
}