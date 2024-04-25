using System;

namespace Assignment2
{
    public class StudentInfo : IDisplayInfo
    {
        private static int s_studentID=100;
        public string StudentID{get;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }
        public StudentInfo(string name,string fatherName,long mobile){
            ++s_studentID;
            StudentID="SID"+s_studentID;
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
    
        }
        public void Display()
        {
            System.Console.WriteLine("Displaying Student Details");
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine($"Student ID: {StudentID}");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Father Name: {FatherName}");
            System.Console.WriteLine($"Mobile: {Mobile}");
            System.Console.WriteLine("----------------------------------------------");   
        }
    }
}
