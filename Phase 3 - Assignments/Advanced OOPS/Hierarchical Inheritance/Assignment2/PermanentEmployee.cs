using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public enum EmployeeType{Select, Permanent, Temporary}
    public class PermanentEmployee:SalaryInfo
    {
        private static int s_employeeID=100;
        private double DA=0.2;
        private double HRA=0.18;
        private double PF=0.1;
        public string EmployeeID{get;}
        public EmployeeType EmployeeType{get;set;}
        public double TotalSalary { get; set; }
        public PermanentEmployee(EmployeeType employeeType,double basicSalary,int month){
            ++s_employeeID;
            EmployeeID="P-EID"+s_employeeID;
            EmployeeType=employeeType;
            BasicSalary=basicSalary;
            Month=month;
        }
        public double CalculateTotalSalary(){
            TotalSalary=(BasicSalary*DA)+(BasicSalary*HRA)+BasicSalary-(BasicSalary*PF);
            return TotalSalary;
        }
        public void ShowSalary(){
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("The Salary of the Permanent Employee is {0}",CalculateTotalSalary());
            System.Console.WriteLine("_______________________________________");
        }
    }
}