using System;

namespace Assignment_2
{
    public sealed class PatientInfo
    {
        private static int s_patientID=1000;
        public string PatientID{get;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int BedNo{ get; set; }
        public string NativePlace { get; set; }
        public string AdmittedFor { get; set; }
        public PatientInfo(string name,string fatherName,int bedNo,string nativePlace,string admittedFor){
            ++s_patientID;
            PatientID="PID"+s_patientID;
            Name=name;
            FatherName=fatherName;
            BedNo=bedNo;
            NativePlace=nativePlace;
            AdmittedFor=admittedFor;
        }
        public void DisplayInfo(){
            System.Console.WriteLine("__________________________________");
            System.Console.WriteLine("Displaying Patient Info");
            System.Console.WriteLine("__________________________________");
            System.Console.WriteLine($"Patient ID: {PatientID}");
            System.Console.WriteLine($"Patiient Name: {Name}");
            System.Console.WriteLine($"Father Name: {FatherName}");
            System.Console.WriteLine($"Bed Number: {BedNo}");
            System.Console.WriteLine($"Native Place: {NativePlace}");
            System.Console.WriteLine($"Admitted For: {AdmittedFor}");
            System.Console.WriteLine("__________________________________");

        }
    }
}
