using System;
using Assignment_1;
namespace Assignment1;
class Program
{
    public static void Main(string[] args)
    {
        //creating object for Child class alone
        StudentInfo student1=new StudentInfo("Sanjay","Vedhachalam",9940538417,"sanjayvedha@gmail.com",new DateTime(2001,12,21),"Male",12,"Computer Science",2023);
        StudentInfo student2=new StudentInfo("Latha","Ram",9467839394,"latha@gmail.com",new DateTime(2001,09,11),"Female",11,"Accounts",2023);
        student1.ShowStudentInfo();
        student2.ShowStudentInfo();
    }

}