using System;

namespace Assignment_1
{
    public partial class EmployeeInfo
    {
        public void Update(){
            
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("Updating Employee Details");
            System.Console.WriteLine("-----------------------------------------------");
            
            System.Console.Write("Enter Employee Name: ");
            EmployeeName=Console.ReadLine();
            System.Console.Write("Enter Employee Gender: ");
            EmployeeGender=Console.ReadLine();
            System.Console.Write("Enter Employee Date of Birth: ");
            DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.Write("Enter Employee mobile number: ");
            MobileNumber=long.Parse(Console.ReadLine());

            EmployeeInfo employee=new EmployeeInfo(EmployeeID,EmployeeName,EmployeeGender,DOB,MobileNumber);
            System.Console.WriteLine("Updated Succesfully. Your Employee ID is: {0}",EmployeeID);
            System.Console.WriteLine("-----------------------------------------------");
        }
        public void Display(){
            
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("Employee Details");
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("Employee ID: "+EmployeeID);
            System.Console.WriteLine("Employee Name: "+EmployeeName);
            System.Console.WriteLine("Employee Gender: "+EmployeeGender);
            System.Console.WriteLine("Employee Date of Birth: "+DOB.ToShortDateString());
            System.Console.WriteLine("Employee Mobile Number: "+MobileNumber);
        }
    }
}
