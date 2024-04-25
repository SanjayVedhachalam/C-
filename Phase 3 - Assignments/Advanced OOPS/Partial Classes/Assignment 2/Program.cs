using System;
using Assignment_2;
namespace Assignment2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Student Registration");
        System.Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();
        System.Console.Write("Enter Student Gender: ");
        string gender = Console.ReadLine();
        System.Console.Write("Enter Student Date of Birth: ");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        System.Console.Write("Enter Student mobile number: ");
        long mobileNumber = long.Parse(Console.ReadLine());
        System.Console.Write("Enter Physics mark: ");
        double physics=double.Parse(Console.ReadLine());
        System.Console.Write("Enter Chemistry mark: ");
        double chemistry=double.Parse(Console.ReadLine());
        System.Console.Write("Enter Maths mark: ");
        double maths=double.Parse(Console.ReadLine());
        
        StudentInfo info = new StudentInfo(studentName,gender,dob,mobileNumber,physics,chemistry,maths);
        
        System.Console.WriteLine("Regitered Succesfully. Your Employee ID is: {0}",info.StudentID);
        string wish;
        do{
        System.Console.WriteLine("What do you want?");
        System.Console.WriteLine("1. Calculate Total and Percentage\n2. Display Details");
        int option=int.Parse(Console.ReadLine());
        switch(option){
            case 1:{
                info.Total();
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