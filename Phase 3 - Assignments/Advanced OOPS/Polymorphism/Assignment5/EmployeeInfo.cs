using System;

namespace Assignment5
{
    public class EmployeeInfo : PersonalInfo
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get; }

        public EmployeeInfo(string name,string fatherName,long mobileNumber,string gender):base(name,fatherName,mobileNumber,gender)
        {
            ++s_employeeID;
            EmployeeID="SF"+s_employeeID;
            
        }

        public EmployeeInfo(string name,string fatherName,long mobileNumber,string gender,string employeeID):base(name,fatherName,mobileNumber,gender)
        {
            EmployeeID="SF"+s_employeeID;
        }
        public override void Display()
        {
            System.Console.WriteLine("_________________________________________");
            System.Console.WriteLine("Displaying Employee Info");
            System.Console.WriteLine("_________________________________________");
            System.Console.WriteLine($"Employee ID: {EmployeeID}");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Father Name: {FatherName}");
            System.Console.WriteLine($"Mobile Number: {MobileNumber}");
            System.Console.WriteLine($"Gender: {Gender}");
            
            
        }
    }
}
