using System;

namespace Phase_2_Payroll_Management
{
    public class AttendanceDetaills
    {
        private static int s_attendID=1000;
        public string EmployeeID;
        public string AttendanceID;
        public DateTime Date;
        public DateTime CheckinTime;
        
        public DateTime CheckoutTime;
        public int HoursWorked;
        public AttendanceDetaills(string attendanceID,string employeeID,DateTime date,DateTime checkinTime,DateTime checkoutTime,int hoursWorked){
            ++s_attendID;
            AttendanceID="AID"+s_attendID.ToString();
            EmployeeID=employeeID;
            Date=date;
            CheckinTime=checkinTime;
            CheckoutTime=checkoutTime;
            HoursWorked=hoursWorked;
        }    
        
    }
}
