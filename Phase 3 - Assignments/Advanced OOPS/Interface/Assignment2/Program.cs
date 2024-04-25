using System;
namespace Assignment2;
class Program{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Sanjay","Vedha",9940538417);
        student.Display();

        EmployeeInfo employee=new EmployeeInfo(student.Name,student.FatherName);
        employee.Display();
    }
}