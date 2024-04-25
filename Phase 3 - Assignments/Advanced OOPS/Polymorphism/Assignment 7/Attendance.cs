using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Attendance
    {
        public int TotalWorkingDaysInAMonth { get; set; }
        public int NumberOfLeavesTaken { get; set; }
        public int NumberOfPermissionTaken{get;set;}
        public Attendance(int totalWorkingDaysInAMonth,int numberOfLeavesTaken,int numberOfPermissionTaken){
            TotalWorkingDaysInAMonth=totalWorkingDaysInAMonth;
            NumberOfLeavesTaken=numberOfLeavesTaken;
            NumberOfPermissionTaken=numberOfPermissionTaken;
        }
        public int Calculate(int totalWorkingDaysInAMonth,int numberOfLeavesTaken){
            int salary=(totalWorkingDaysInAMonth-numberOfLeavesTaken)*500;
            return salary;

        }
    }
}