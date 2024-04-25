using System;
namespace Assignment2;
class Program{
    public static void Main(string[] args)
    {
        PermanentEmployee permanentEmployee1=new PermanentEmployee(EmployeeType.Permanent,21500,1);
        TemporaryEmployee temporaryEmployee1=new TemporaryEmployee(EmployeeType.Temporary,15000,1);

        permanentEmployee1.CalculateTotalSalary();
        permanentEmployee1.ShowSalary();

        temporaryEmployee1.CalculateTotalSalary();
        temporaryEmployee1.ShowSalary();
        
        PermanentEmployee permanentEmployee2=new PermanentEmployee(EmployeeType.Permanent,25500,4);
        TemporaryEmployee temporaryEmployee2=new TemporaryEmployee(EmployeeType.Temporary,17500,2);

        permanentEmployee2.CalculateTotalSalary();
        permanentEmployee2.ShowSalary();

        temporaryEmployee2.CalculateTotalSalary();
        temporaryEmployee2.ShowSalary();
    }
}