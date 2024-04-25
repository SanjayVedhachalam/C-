using System;
namespace Assignment5;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo employeeinfo=new EmployeeInfo("Sanjay","Vedha",9940538417,"Male");
        PersonalInfo salaryinfo=new SalaryInfo(employeeinfo.Name,employeeinfo.FatherName,employeeinfo.MobileNumber,employeeinfo.Gender,32,"");

        employeeinfo.Display();

        salaryinfo.Display();
    }
}