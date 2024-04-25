using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class PrincipalInfo:PersonalInfo
    {
        private static int s_principalID=100;
        public string PrincipalID { get; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        public PrincipalInfo(string name,string fatherName,DateTime dob,string phone,string gender,string mail,string qualification,int yearOfExperience,DateTime dateOfJoining){
            ++s_principalID;
            PrincipalID="PID"+s_principalID;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Phone=phone;
            Gender=gender;
            Mail=mail;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        public void ShowDetails(){
            System.Console.WriteLine("Principal Details");
            System.Console.WriteLine($"Principal ID     : {PrincipalID}");
            System.Console.WriteLine($"Principal Name   : {Name}");
            System.Console.WriteLine($"Father Name      : {FatherName}");
            System.Console.WriteLine($"Date of Birth    : {DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Phone            : {Phone}");
            System.Console.WriteLine($"Gender           : {Gender}");
            System.Console.WriteLine($"Mail             : {Mail}");
            System.Console.WriteLine($"Qualification    : {Qualification}");
            System.Console.WriteLine($"Year of Exprience: {YearOfExperience}");
            System.Console.WriteLine($"Date of Joining  : {DateOfJoining.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine("________________________________________________");
        }
    }
}