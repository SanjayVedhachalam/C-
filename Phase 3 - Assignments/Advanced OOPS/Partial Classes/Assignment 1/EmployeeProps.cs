using System;

namespace Assignment_1
{
    public partial class EmployeeInfo
    {
        private static int s_employeeID = 1000;
        public string EmployeeID { get; }
        public string EmployeeName { get; set; }
        public string EmployeeGender { get; set; }
        public DateTime DOB { get; set; }
        public long MobileNumber { get; set; }
    }

}
