using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class ClassTeacher:PersonalInfo
    {
        private static int s_teacherID=100;
        public string TeacherID { get; }
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public ClassTeacher(string name,string fatherName,DateTime dob,string phone,string gender,string mail,string department,string subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining){
            ++s_teacherID;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Phone=phone;
            Gender=gender;
            Mail=mail;
            TeacherID="TID"+s_teacherID;
            Department=department;
            SubjectTeaching=subjectTeaching;Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        public void ShowDetails(){
            System.Console.WriteLine($"Teacher Details");
            System.Console.WriteLine($"Teacher ID      : {TeacherID}");
            System.Console.WriteLine($"Teacher Name    : {Name}");
            System.Console.WriteLine($"Father Name     : {FatherName}");
            System.Console.WriteLine($"Date of Birth   : {DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Phone           : {Phone}");
            System.Console.WriteLine($"Gender          : {Gender}");
            System.Console.WriteLine($"Mail            : {Mail}");
            System.Console.WriteLine($"Departmnet      : {Department}");
            System.Console.WriteLine($"Subject Teaching: {SubjectTeaching}");
            System.Console.WriteLine($"Qualification   : {Qualification}");
            System.Console.WriteLine($"YearOfExperience: {YearOfExperience}");
            System.Console.WriteLine($"Date of Joining : {DateOfJoining.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine("________________________________________________");
        }
    }
}