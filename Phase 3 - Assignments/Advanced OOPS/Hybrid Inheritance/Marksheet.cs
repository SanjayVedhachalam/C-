using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid_Inheritance
{
    public class Marksheet : TheoryExamMarks, ICalculate
    {
        private static int s_marksheetNumber=100;
        public string MarksheetNumber{get;}
        public DateTime DateOfIssue{get;set;}
        public double Total { get; set; }
        public double Percentage { get; set; }
        public double ProjectMark { get; set ; }
        public Marksheet(double[] sem1, double[] sem2, double[] sem3, double[] sem4, double projectMark,string name, string fatherName, string phone, DateTime dob, string gender) : base(sem1, sem2, sem3, sem4)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            Gender=gender;
            ++s_marksheetNumber;
            MarksheetNumber="MKSHN"+s_marksheetNumber;
            DateOfIssue=DateTime.Now;
            ProjectMark=projectMark;
            
        }
        public void CalculateUGPercentage()
        {
            Percentage=Total/28;
            System.Console.WriteLine("Overall Percentage is "+Percentage);
        }

        public void CalculateUGTotal()
        {
            double Sem1Total=ProjectMark;
            double Sem2Total=ProjectMark;
            double Sem3Total=ProjectMark;
            double Sem4Total=ProjectMark;
            foreach(double mark in Sem1){
                Sem1Total+=mark;
            }
            foreach(double mark in Sem2){
                Sem2Total+=mark;
            }
            foreach(double mark in Sem3){
                Sem3Total+=mark;
            }
            foreach(double mark in Sem4){
                Sem4Total+=mark;
            }
            Total=Sem1Total+Sem2Total+Sem3Total+Sem4Total;
            System.Console.WriteLine("_______________________________________");
            System.Console.WriteLine("Sem 1 Total   : "+Sem1Total);
            System.Console.WriteLine("Sem 2 Total   : "+Sem2Total);
            System.Console.WriteLine("Sem 3 Total   : "+Sem3Total);
            System.Console.WriteLine("Sem 4 Total   : "+Sem4Total);
            System.Console.WriteLine();
            System.Console.WriteLine($"Overall Total: {Total}");
            System.Console.WriteLine(); 
        }
        public void SHowUGMarkSHeet(){
            
            System.Console.WriteLine($"Marsheet Number       : {MarksheetNumber}");
            System.Console.WriteLine($"Name                  : {Name}");
            System.Console.WriteLine($"Registration Number   : {RegistrationNumber} ");
            System.Console.WriteLine($"Overall Semester Total: {Total}"); 
            System.Console.WriteLine($"Overall Percentage    : {Percentage}");
            System.Console.WriteLine($"Date of Issue         : {DateOfIssue}");
            System.Console.WriteLine($"Father Name           : {FatherName}");
            System.Console.WriteLine($"Phone                 : {Phone}");
            System.Console.WriteLine($"Date of Birth         : {DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Gender                : {Gender}");
            System.Console.WriteLine("----------------------------------------");
        }
    }
}