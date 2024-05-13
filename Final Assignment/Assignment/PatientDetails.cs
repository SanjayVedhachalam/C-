using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public enum Gender {Select, Male, Female, Others}
    public class PatientDetails
    {
        private static int s_patientID = 0;
        public int PatientID { get; }
        public string PatientPassword { get; set; }
        public string PatientName { get; set; }
        public int PatientAge { get; set; }
        public Gender PatientGender { get; set; }
        public PatientDetails(string patientPassword, string patientName, int patientAge, Gender patientGender){
            ++s_patientID;
            PatientID = s_patientID;
            PatientPassword = patientPassword;
            PatientName = patientName;
            PatientAge = patientAge;
            PatientGender = patientGender;
        }
    }
}