using System;

namespace Assignment_2
{
    public class DoctorInfo:PatientInfo   //Cannot inherit since it is a sealed class  - cannot derive from sealed type 'PatientInfo'
    {
        private static int s_doctorID=200;
        public string DoctorID{get;}
        public string DoctorName { get; set; }
        public string DoctorFatherName { get; set; }
        public DoctorInfo(string name,string fatherName,int bedNo,string nativePlace,string admittedFor,string doctorName,string doctorFatherName):base(name,fatherName,bedNo,nativePlace,admittedFor){  //Cannot access the base class since base class is sealed
            ++s_doctorID;
            DoctorID="DID"+s_doctorID;
            DoctorName=doctorName;
            DoctorFatherName=doctorFatherName;
        }
        public void DisplayInfo(){
            System.Console.WriteLine("__________________________________");
            System.Console.WriteLine("Displaying Doctor Info");
            System.Console.WriteLine("__________________________________");
            System.Console.WriteLine($"Patient ID: {DoctorID}");
            System.Console.WriteLine($"Patiient Name: {DoctorName}");
            System.Console.WriteLine($"Father Name: {DoctorFatherName}");
            System.Console.WriteLine("__________________________________");
        }
    }
}
