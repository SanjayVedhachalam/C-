using System;
using System.Linq;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        string[] names = new string[5]{"Mani", "Ganesh", "Venkat", "Suresh","Venkat"};
        
        int i;
        for(i=0;i<names.Length;i++){
            Console.WriteLine(names[i]);
        }
        Console.Write("Enter the name to be searched: ");
        string searchName = Console.ReadLine();
        bool condition = false;
        for(i=0;i<names.Length;i++){
            if(searchName==names[i]){
                Console.WriteLine($"The name: {searchName} is present in the array in the index position: {i}");
                condition=true;
                break;
            }
        }
        if(!condition){
            System.Console.WriteLine(("The name is not present in the array"));
        }
        foreach(string val in names){
            if(val == searchName){
                Console.WriteLine($"The name: {searchName} is present in the array");
                condition=true;
                break;
            }
        }
        if(!condition){
            System.Console.WriteLine(("The name is not present in the array"));
        }

    }
}