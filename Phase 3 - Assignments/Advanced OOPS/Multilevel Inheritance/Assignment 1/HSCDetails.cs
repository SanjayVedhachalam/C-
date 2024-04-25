using System;

namespace Assignment_1
{
    public class HSCDetails:StudentInfo
    {
        private static int s_marksheetNumber=100;
        public string MarksheetNumber{get;}
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }

        public HSCDetails(string name,string fatherName,long phone,string mail,
        DateTime dob,string gender,int standard,string branch,
        int academicYear,int physics,int chemistry,int maths):base(name,fatherName,phone,mail,dob,gender,standard,branch,academicYear)
        {
            ++s_marksheetNumber;
            MarksheetNumber="HSC"+s_marksheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public void GetMarks(){
            System.Console.WriteLine("Enter your Marks ");
            System.Console.Write("Physics: ");
            Physics=int.Parse(Console.ReadLine());
            System.Console.Write("Chemistry: ");
            Chemistry=int.Parse(Console.ReadLine());
            System.Console.Write("Maths: ");
            Maths=int.Parse(Console.ReadLine());
        }
        public void Calculate(){
            Total=Physics+Chemistry+Maths;
            Percentage=double.Round(Total/3,2);
        }
        public void ShowMarkSheet(){
            System.Console.WriteLine("Marksheet Details");
            System.Console.WriteLine($"Name          : {Name}");
            System.Console.WriteLine($"Physics Mark  : {Physics}");
            System.Console.WriteLine($"Chemistry Mark: {Chemistry}");
            System.Console.WriteLine($"Maths Mark    : {Maths}");
            System.Console.WriteLine($"Total         : {Total}");
            System.Console.WriteLine($"Percentage    : {Percentage}");
        }
    }
}
