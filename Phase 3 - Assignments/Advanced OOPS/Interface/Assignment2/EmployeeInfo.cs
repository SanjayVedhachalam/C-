using System;

namespace Assignment2
{
    public class EmployeeInfo : IDisplayInfo
    {
        private static int s_employeeID=100;
        public string EmployeeID{get;}
        public string EmployeeName{get;set;}
        public string EmployeeFatherName { get; set; }
        public EmployeeInfo(string employeeName,string employeeFatherName){
            ++s_employeeID;
            EmployeeID="EID"+s_employeeID;
            EmployeeName=employeeName;
            EmployeeFatherName=employeeFatherName;
        }
        public void Display()
        {
            System.Console.WriteLine("Displaying Employee Details");
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine($"Employee ID: {EmployeeID}");
            System.Console.WriteLine($"Name: {EmployeeName}");
            System.Console.WriteLine($"Father Name: {EmployeeFatherName}");
            System.Console.WriteLine("----------------------------------------------");   
        }
    }
}
