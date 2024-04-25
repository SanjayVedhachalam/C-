using System;
using Assignment_7;
namespace Assignment7;
class Program{
    public static void Main(string[] args)
    {
        Attendance Month1=new Attendance(24,2,0);
        Attendance Month2=new Attendance(25,1,1);
        Attendance Month3=new Attendance(24,0,0);

        System.Console.WriteLine("_________________________________________________________");
        System.Console.WriteLine($"Salary for Month 1 is: {Month1.Calculate(Month1.TotalWorkingDaysInAMonth,Month1.NumberOfLeavesTaken)}");
        System.Console.WriteLine("_________________________________________________________");
        System.Console.WriteLine($"Salary for Month 2 is: {Month2.Calculate(Month2.TotalWorkingDaysInAMonth,Month2.NumberOfLeavesTaken)}");
        System.Console.WriteLine("_________________________________________________________");
        System.Console.WriteLine($"Salary for Month 3 is: {Month3.Calculate(Month3.TotalWorkingDaysInAMonth,Month3.NumberOfLeavesTaken)}");
        System.Console.WriteLine("_________________________________________________________");
        
    }
}