using System;

namespace Phase_2_Payroll_Management
{
    public enum Branch{Select, Eymard, Karuna, Madhura}
    public enum Team{Select, Network, Hardware, Developer, Facility}
    /// <summary>
    /// This class stores all the Employee Details.
    /// </summary> <summary>
    /// 
    /// </summary>
    public class EmployeeDetails
    {
        private static int s_empID=3000;
        public string EmployeeID;
        public string EmployeeFullName;
        public DateTime DOB;
        public long MobileNumber;
        public string Gender;
        public Branch Branch;
        public Team Team;
        public EmployeeDetails(string employeeID,string employeeFullName,DateTime dob,long mobileNo,string gender,Branch branch,Team team){
            ++s_empID;
            EmployeeID="SF"+s_empID.ToString();
            EmployeeFullName=employeeFullName;
            DOB=dob;
            MobileNumber=mobileNo;
            Gender=gender;
            Branch=branch;
            Team=team;
        }
    }
}
