using System;
using System.ComponentModel.DataAnnotations;
using Assignment_2;
namespace Assignment2;
class Program{
    public static void Main(string[] args)
    {
        PatientInfo patient=new PatientInfo("Ram","Prasad",3,"Chennai","Stomach Ache");
        patient.DisplayInfo();

        DoctorInfo doctor=new DoctorInfo(patient.Name,patient.FatherName,patient.BedNo,patient.NativePlace,patient.AdmittedFor,"Sanjay","Vedha");
        doctor.DisplayInfo();
    }
}