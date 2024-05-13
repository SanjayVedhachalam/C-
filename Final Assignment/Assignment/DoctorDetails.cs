using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public class DoctorDetails
    {
        private static int s_doctorID = 0;
        public int DoctorID { get; }
        public string DoctorName { get; set; }
        public string DepartmentName { get; set; }
        public DoctorDetails(string doctorName, string departmentName){
            ++s_doctorID;
            DoctorID = s_doctorID;
            DoctorName = doctorName;
            DepartmentName = departmentName;
        }
    }
}