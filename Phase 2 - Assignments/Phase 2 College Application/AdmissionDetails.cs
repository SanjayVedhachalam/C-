using System;

namespace Phase_2_College_Application
{
    public enum AdmissionStatus{Select, Admitted, Cancelled, Booked}
    public class AdmissionDetails
    {
        private static int s_admissionID=1000;
        
        

        public string AdmissionID{get;set;}
        public string StudentID{get;set;}
        public string DepartmentID{get;set;}
        public DateTime AdmissionDate{get;set;}
        public AdmissionStatus AdmissionStatus{get;set;}
        
        public AdmissionDetails(string admissionID,string studentID,string departmentID,DateTime admissionDate, AdmissionStatus admissionStatus)
        {
           ++s_admissionID;
           AdmissionID="AID"+s_admissionID.ToString();
           StudentID=studentID;
           DepartmentID=departmentID;
           AdmissionDate=admissionDate;
           AdmissionStatus=admissionStatus;
        }

    }
}
