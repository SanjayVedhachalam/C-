using System;

namespace Assignment_2
{
    public partial class StudentInfo
    {
        public void Total(){
            System.Console.WriteLine("-----------------------------------------------");
            double total = Physics+Chemistry+Maths;
            System.Console.WriteLine($"Student Total is {total}");
            double percentage=(Physics+Chemistry+Maths)/3;
            System.Console.WriteLine($"Student Percentage is {percentage}");
            System.Console.WriteLine("-----------------------------------------------");
        }
        public void Display(){
            
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("Student Details");
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("Student ID: "+StudentID);
            System.Console.WriteLine("Student Name: "+StudentName);
            System.Console.WriteLine("Student Gender: "+StudentGender);
            System.Console.WriteLine("Student Date of Birth: "+DOB.ToShortDateString());
            System.Console.WriteLine("Student Mobile Number: "+MobileNumber);
            System.Console.WriteLine("Marks Details");
            Total();
            System.Console.WriteLine("-----------------------------------------------");
        }
    }
}
