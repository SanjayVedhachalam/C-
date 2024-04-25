using System;

namespace Assignment4
{
    public class Syncfusion : FreeLancer
    {
        private static int s_employeeID=1000;
        public string EmployeeID{get;}
        public string Worklocation { get; set; }
        public Syncfusion(string name, string fatherName, string gender, string qualification, string role, int noOfWorkingDays,string worklocation) : base(name, fatherName, gender, qualification, role, noOfWorkingDays)
        {
            ++s_employeeID;
            EmployeeID="SF"+s_employeeID;
            Worklocation=worklocation;
        }
        public override void CalculateSalary(){
            SalaryAmount=NoOfWorkingDays*500;
            System.Console.WriteLine("The Salary of the Syncfusion Employee is {0}",SalaryAmount);
        }
        public override void DisplayEmployeeDetails(){
            System.Console.WriteLine("____________________________________________");
            System.Console.WriteLine("Displaying Syncfusion Employee Details");
            System.Console.WriteLine("____________________________________________");
            System.Console.WriteLine($"Employee ID: {EmployeeID}");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Father Name: {FatherName}");
            System.Console.WriteLine($"Gender: {Gender}");
            System.Console.WriteLine($"Qualification: {Qualification}");
            System.Console.WriteLine($"Role: {Role}");
            System.Console.WriteLine($"Salary Amount: {SalaryAmount}");
            System.Console.WriteLine($"Number of Working Days: {NoOfWorkingDays}");
            System.Console.WriteLine($"Employee WorkLocation: {Worklocation}");            
            System.Console.WriteLine("____________________________________________");
        }
    }
}
