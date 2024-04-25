using System;

namespace Assignment5
{
    public class SalaryInfo : EmployeeInfo
    {
        protected int noOfWorkingDays;
        public int NoOfWorkingDays 
        { get{
            return noOfWorkingDays;
        } set{
            noOfWorkingDays=value;
        } }
        public SalaryInfo(string name, string fatherName, long mobileNumber, string gender,int numberOfWorkingDays,string employeeID) : base(name, fatherName, mobileNumber, gender,employeeID)
        {
            NoOfWorkingDays=numberOfWorkingDays;
        }
        public override void Display()
        {
            base.Display();
            System.Console.WriteLine($"Salary Details for {noOfWorkingDays} days is: {NoOfWorkingDays*500}");
            System.Console.WriteLine("_________________________________________");
        }
    }
}
