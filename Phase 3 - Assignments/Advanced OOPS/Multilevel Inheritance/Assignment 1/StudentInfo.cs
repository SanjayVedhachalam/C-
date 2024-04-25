using System;

namespace Assignment_1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_registerNumber=100;
        public string RegisterNumber{get;}
        public int Standard { get; set; }
        public string Branch { get; set; }
        public int AcademicYear { get; set;}

        public StudentInfo(string name,string fatherName,long phone,string mail,
        DateTime dob,string gender,int standard,string branch,
        int academicYear):base(name,fatherName,phone,mail,dob,gender){  //Inherited Properties from base class
            ++s_registerNumber;
            RegisterNumber="SF"+s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
        }

        public void GetStudentInfo(){
            System.Console.WriteLine("-------------------------------------------------------");
            System.Console.WriteLine("Student Registration");
            System.Console.Write("Enter Student Name: ");
            Name=Console.ReadLine();
            System.Console.Write("Enter Father Name: ");
            FatherName=Console.ReadLine();
            System.Console.Write("Enter Phone Number: ");
            Phone=long.Parse(Console.ReadLine());
            System.Console.Write("Enter Mail ID: ");
            Mail=Console.ReadLine();
            System.Console.Write("Enter Date of Birth[dd/MM/yyyy]: ");
            DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None);
            System.Console.Write("Enter Gender: ");
            Gender=Console.ReadLine();
            System.Console.Write("Enter Standard: ");
            Standard=int.Parse(Console.ReadLine());
            System.Console.Write("Enter branch: ");
            Branch=Console.ReadLine();
            System.Console.Write("Enter Academic Year: ");
            AcademicYear=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Details registered. Your Student Ragister Number is {0}",RegisterNumber);
            System.Console.WriteLine("-------------------------------------------------------");
        }
        public void ShowStudentInfo(){
            System.Console.WriteLine("-------------------------------------------------------");
            System.Console.WriteLine("Student Information");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Father Name: {FatherName}");
            System.Console.WriteLine($"Phone Number: {Phone}");
            System.Console.WriteLine($"Mail ID: {Mail}");
            System.Console.WriteLine($"Date of Birth: {DOB}");
            System.Console.WriteLine($"Gender: {Gender}");
            System.Console.WriteLine($"Register Number: {RegisterNumber}");
            System.Console.WriteLine($"Standard: {Standard}");
            System.Console.WriteLine($"Branch: {Branch}");
            System.Console.WriteLine($"Academic Year: {AcademicYear}");
            System.Console.WriteLine("-------------------------------------------------------");
        }
    }
}
