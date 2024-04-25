using System;
using System.Threading;
using Assignment_1;
namespace Assignment1;
class Program{
    public static void Main(string[] args)
    {
        int count=0;
        do{
        StudentInfo student1=new StudentInfo("","",0,"",new DateTime(0001,01,01),"",0,"",0);
        System.Console.WriteLine("Getting Student Details");
        student1.GetStudentInfo();
        HSCDetails hSCStudent1=new HSCDetails(student1.Name,student1.FatherName,student1.Phone,student1.Mail,student1.DOB,student1.Gender,student1.Standard,student1.Branch,student1.AcademicYear,0,0,0);
        System.Console.WriteLine("Getting Student Marks");
        hSCStudent1.GetMarks();
        hSCStudent1.Calculate();
        System.Console.Write("Do you want to display Marksheet and Student Details?[yes/no]: ");
        string wish=Console.ReadLine().ToLower();
        if(wish.Equals("yes")){
            hSCStudent1.ShowStudentInfo();
            hSCStudent1.ShowMarkSheet();
        }
        else{
            System.Console.WriteLine("Thank you for details");
        }
        count++;
        }while(count<2);
    }
}