using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_studentID=200;
        public string StudentID{get;}
        public string Department { get; set; }
        public string Degree { get; set; }
        public int Semester { get; set; }
        public StudentInfo(string name,string fatherName,DateTime dob,string phone,string gender,string mail,string department,string degree,int semester){
            ++s_studentID;
            StudentID="STID"+s_studentID;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Phone=phone;
            Gender=gender;
            Mail=mail;
            Degree=degree;
            Department=department;
            Semester=semester;
        }
        public void Showdetails(){
            System.Console.WriteLine("Student Details");
            System.Console.WriteLine($"Student ID       : {StudentID}");
            System.Console.WriteLine($"Student Name     : {Name}");
            System.Console.WriteLine($"Father Name      : {FatherName}");
            System.Console.WriteLine($"Date of Birth    : {DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Phone            : {Phone}");
            System.Console.WriteLine($"Gender           : {Gender}");
            System.Console.WriteLine($"Mail             : {Mail}");
            System.Console.WriteLine($"Department       : {Department}");
            System.Console.WriteLine($"Degree           : {Degree}");
            System.Console.WriteLine($"Semester         : {Semester}");
            System.Console.WriteLine("________________________________________________");
        }
    }
}