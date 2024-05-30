using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Npgsql;
using NpgsqlTypes;
using System.Web;

namespace Practice1;
public class Program{
    public static void Main(string[] args)
    {
        // int[] numbers = {1,2,3,4,5};
        // var toprint = (from number in  numbers where (number%2)==0 select number).ToString();
        // System.Console.WriteLine(toprint);
        // IEnumerable<int> ints = from number in  numbers where (number%2)==0 select number;
        // foreach(int i in ints){
        //     System.Console.WriteLine(i);
        // }

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
        
        IEnumerable<string> strings = from name in names where (name[0] == startCharacter && name[name.Length-1] == endCharacter) select name;
        
        System.Console.WriteLine("The city starting with A and ending with M is: ");
        string result="";
        foreach (string str in strings)
        {
            result+=str + ", ";
        } 
        for(int i=0;i<result.Length-2;i++){
            System.Console.Write(result[i]);
        }
    }
}
//public class 