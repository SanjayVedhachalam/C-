using System;

namespace Assignment4
{
    public class FreeLancer : PersonDetails
    {
        public string Role { get; set; }
        public double SalaryAmount { get; set; }
        public int NoOfWorkingDays { get; set; }
        public FreeLancer(string name,string fatherName,string gender,string qualification,string role,int noOfWorkingDays):base(name,fatherName,gender,qualification)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Qualification=qualification;
            Role=role;
            NoOfWorkingDays=noOfWorkingDays;
        }
        public virtual void CalculateSalary(){
            SalaryAmount=NoOfWorkingDays*500;
            System.Console.WriteLine("The Salary of the FreeLancer is {0}",SalaryAmount);
        }
        public virtual void DisplayEmployeeDetails(){
            System.Console.WriteLine("____________________________________________");
            System.Console.WriteLine("Displaying FreeLancer Details");
            System.Console.WriteLine("____________________________________________");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Father Name: {FatherName}");
            System.Console.WriteLine($"Gender: {Gender}");
            System.Console.WriteLine($"Qualification: {Qualification}");
            System.Console.WriteLine($"Role: {Role}");
            System.Console.WriteLine($"Salary Amount: {SalaryAmount}");
            System.Console.WriteLine($"Number of Working Days: {NoOfWorkingDays}");
            
            System.Console.WriteLine("____________________________________________");

        }
    }
}
