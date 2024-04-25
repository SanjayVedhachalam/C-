using System;
using System.Net.Mail;
namespace DateTimeClass;
class Program{
    public static void Main(string[] args)
    {
        DateTime dateTime = new DateTime(2021,8,10,10,40,32);
        string temp = dateTime.ToString("yyyy/MM/dd hh:mm:ss tt");
        System.Console.WriteLine(temp);
        string[] str = temp.Split('/',':',' ');
        int length = str.Length;
        for(int i=length-1;i>=0;i--){
            Console.Write(str[i]+" ");
        }
        System.Console.WriteLine();
        System.Console.Write("Enter a date in the proper format(yyyy/mm/dd): ");
        DateTime date;
        bool value = DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd",null,System.Globalization.DateTimeStyles.None, out date);
        while(!value){
            Console.Write("Invalid Data. Try again:(yyyy/MM/dd) - ");
            value = DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd",null,System.Globalization.DateTimeStyles.None,out date);
        }

        System.Console.WriteLine(date.ToString("yyyy/MM/dd"));

    }
}