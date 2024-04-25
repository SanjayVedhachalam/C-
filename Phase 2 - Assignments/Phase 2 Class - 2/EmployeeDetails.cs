using System;
using System.Diagnostics.Contracts;

namespace Phase_2_Class___2
{
    public enum WorkLocation{Select, Kilpauk, AnnaNagar, Kismus, Texas}
    public enum Gender{Select, Male, Female, Trans}
    public class EmployeeDetails
    {
        private static int s_empID=1000;
        public string EmployeeID{get;set;}
        public string EmployeeName{get;set;}    
        public string EmployeeRole{get;set;}
        public WorkLocation WorkLocation{get;set;}
        public string TeamName{get;set;}
        public DateTime DateOfJoining{get;set;}
        public int NumberOfWorkingDays{get;set;}
        public int NumberOfLeaveTaken{get;set;}
        public Gender Gender{get;set;}

        public EmployeeDetails(string employeeName, string employeeRole, WorkLocation workLocation, string teamName, DateTime dateOfJoining, int numberOfWorkingDays, int numberOfLeaveTaken, Gender gender)
        {
            ++s_empID;
            EmployeeID = "SF"+s_empID.ToString();
           
            EmployeeName = employeeName;
            EmployeeRole = employeeRole;
            WorkLocation = workLocation;
            TeamName = teamName;
            DateOfJoining = dateOfJoining;
            NumberOfWorkingDays = numberOfWorkingDays;
            NumberOfLeaveTaken = numberOfLeaveTaken;
            Gender = gender;
        }
        public int SalaryCalculation(int numberOfLeaveTaken, int numberOfWorkingDays)
        {
            int totalDaysWorked=numberOfWorkingDays-numberOfLeaveTaken;
            int Salary=totalDaysWorked*500;
            return Salary;
        }
    }   
}
