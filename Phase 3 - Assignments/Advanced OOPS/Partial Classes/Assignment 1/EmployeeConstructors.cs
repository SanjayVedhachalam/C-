using System;

namespace Assignment_1
{
    public partial class EmployeeInfo
    {
        public EmployeeInfo(string employeeName, string employeeGender, DateTime dob, long mobileNumber)
        {
            ++s_employeeID;
            EmployeeID="EID"+s_employeeID;
            EmployeeName=employeeName;
            EmployeeGender=employeeGender;
            DOB=dob;
            MobileNumber=mobileNumber;
        }

        public EmployeeInfo(string employeeID,string employeeName, string employeeGender, DateTime dob, long mobileNumber)
        {
            EmployeeID=employeeID;
            EmployeeName=employeeName;
            EmployeeGender=employeeGender;
            DOB=dob;
            MobileNumber=mobileNumber;
        }
    }

}
