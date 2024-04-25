using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public class RegisterPerson:PersonalInfo,IShowData,IFamilyInfo
    {
        private static int s_registrationNumber=1000;
        public string RegistrationNumber{ get; }
        public string FatherName { get ; set ; }
        public string MotherName { get ; set ; }
        public string HouseAddress { get ; set ; }
        public int NoOfSiblings { get ; set ; }
        public DateTime DateOfRegistration { get ; set ; }
        public RegisterPerson(string name,string fatherName,string motherName,DateTime dob,string phone,MartialDetails martialDetails,string houseAddress,int noOfSiblings,DateTime dateOfRegistration){
            ++s_registrationNumber;
            RegistrationNumber="RID"+s_registrationNumber;
            Name=name;
            FatherName=fatherName;
            MotherName=motherName;
            DOB=dob;
            Phone=phone;
            MartialDetails=martialDetails;
            HouseAddress=houseAddress;
            NoOfSiblings=noOfSiblings;
            DateOfRegistration=dateOfRegistration;
        }
        public void ShowInfo(){
            System.Console.WriteLine("Showing Registered User Details");
            System.Console.WriteLine($"User ID             : {RegistrationNumber}");
            System.Console.WriteLine($"Name                : {Name}");
            System.Console.WriteLine($"Father Name         : {FatherName}");
            System.Console.WriteLine($"Mother Name         : {MotherName}");
            System.Console.WriteLine($"Date of Birth       : {DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Phone               : {Phone}");
            System.Console.WriteLine($"Martial Details     : {MartialDetails}");
            System.Console.WriteLine($"House Address       : {HouseAddress}");
            System.Console.WriteLine($"Number of Siblings  : {NoOfSiblings}");
            System.Console.WriteLine($"Date of Registration: {DateOfRegistration.ToString("dd/MM/yyyy")}");
        }
    }
}