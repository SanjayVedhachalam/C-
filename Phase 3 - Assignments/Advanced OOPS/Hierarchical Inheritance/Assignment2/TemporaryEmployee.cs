using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class TemporaryEmployee:SalaryInfo
    {
        private static int s_employeeID=200;
        private double DA=0.15;
        private double HRA=0.13;
        public string EmployeeID{get;}
        public EmployeeType EmployeeType{get;set;}
        public double TotalSalary { get; set; }
        public TemporaryEmployee(EmployeeType employeeType,double basicSalary,int month){
            ++s_employeeID;
            EmployeeID="T-EID"+s_employeeID;
            EmployeeType=employeeType;
            BasicSalary=basicSalary;
            Month=month;
        }
        public double CalculateTotalSalary(){
            TotalSalary=(BasicSalary*DA)+(BasicSalary*HRA)+BasicSalary;
            return TotalSalary;
        }
        public void ShowSalary(){
            System.Console.WriteLine("The Salary of the Temporary Employee is {0}",CalculateTotalSalary());
        }
    }
}