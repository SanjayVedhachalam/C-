using System;
using System.Runtime.InteropServices;
using Assignment_1;
namespace Assignment1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Employee Registration");
        System.Console.Write("Enter Employee Name: ");
        string employeeName = Console.ReadLine();
        System.Console.Write("Enter Employee Gender: ");
        string employeeGender = Console.ReadLine();
        System.Console.Write("Enter Employee Date of Birth: ");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        System.Console.Write("Enter Employee mobile number: ");
        long mobileNumber = long.Parse(Console.ReadLine());
        
        EmployeeInfo info = new EmployeeInfo(employeeName,employeeGender,dob,mobileNumber);
        
        System.Console.WriteLine("Regitered Succesfully. Your Employee ID is: {0}",info.EmployeeID);
        string wish;
        do{
        System.Console.WriteLine("What do you want?");
        System.Console.WriteLine("1. Update Details\n2. Display Details");
        int option=int.Parse(Console.ReadLine());
        switch(option){
            case 1:{
                info.Update();
                break;
            }
            case 2:{
                info.Display();
                break;
            }
            default:{
                System.Console.WriteLine("Invalid Option");
                break;
            }
        }
        System.Console.Write("Do you want to continue?[yes/no]: ");
        wish=Console.ReadLine().ToLower();
        }while(wish.Equals("yes"));


    }
}