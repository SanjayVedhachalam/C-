using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public class AppointmentDetails
    {
        private static int s_appointmentID = 0;
        public int AppointmentID { get; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Problem { get; set; }
        public AppointmentDetails(int patientID, int doctorID, DateTime appointmentDate, string problem){
            ++s_appointmentID;
            AppointmentID = s_appointmentID;
            PatientID = patientID;
            DoctorID = doctorID;
            AppointmentDate = appointmentDate;
            Problem = problem;
        }

    }
}