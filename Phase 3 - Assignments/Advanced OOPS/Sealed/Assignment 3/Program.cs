using System;
using Assignment_3;
namespace Assignment3;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo(DateTime.Today);
        employee.Update();
        employee.DisplayInfo();
    }
}