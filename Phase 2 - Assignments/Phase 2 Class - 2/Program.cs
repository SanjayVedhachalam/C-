using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using Phase_2_Class___2;
namespace Phase2;
class Program{
    public static void Main(string[] args)
    {
        List<EmployeeDetails> details=new List<EmployeeDetails>();

        string employeeID;
        string employeeName;    
        string employeeRole;
        WorkLocation workLocation;
        string teamName;
        DateTime dateOfJoining;
        int numberOfWorkingDays;
        int numberOfLeaveTaken;
        Gender gender;
        System.Console.WriteLine("Welcome to Employee Details Section");
        string option;
        do{
            
            System.Console.WriteLine("Enter the choice: 1.Registration 2.Login 3.Exit");
            option=Console.ReadLine();
            switch(option){
                case "1":{
                    System.Console.WriteLine("Registration Process");
                    
                    System.Console.Write("Enter Employee Name: ");
                    employeeName=Console.ReadLine();

                    
                    System.Console.Write("Enter Employee Role: ");
                    employeeRole=Console.ReadLine();

                    
                    System.Console.Write("Enter Employee WorkLocation[Kilpauk, AnnaNagar, Kismus, Texas]: ");
                    workLocation=Enum.Parse<WorkLocation>(Console.ReadLine(),true);

                    
                    System.Console.Write("Enter Employee Team Name: ");
                    teamName=Console.ReadLine();

                    
                    System.Console.Write("Enter Employee Date of Joining: ");
                    dateOfJoining=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

                    
                    System.Console.Write("Enter Employee Working Days: ");
                    numberOfWorkingDays=int.Parse(Console.ReadLine());

                    
                    System.Console.Write("Enter Number of days leave taken: ");
                    numberOfLeaveTaken=int.Parse(Console.ReadLine());

                    
                    System.Console.Write("Enter Employee gender: ");
                    gender=Enum.Parse<Gender>(Console.ReadLine(),true);

                    EmployeeDetails employeeDetails=new EmployeeDetails(employeeName,employeeRole,workLocation,teamName,dateOfJoining,numberOfWorkingDays,numberOfLeaveTaken,gender);
                    System.Console.WriteLine("Registered Successfully. Your Employee ID is {0}",employeeDetails.EmployeeID);
                    
                    details.Add(employeeDetails);
                    break;
                }
                case "2":{
                    System.Console.Write("Enter Employee ID: ");
                    employeeID=Console.ReadLine();
                    bool temp=false;
                    foreach(EmployeeDetails employeeDetails in details){
                        if(employeeDetails.EmployeeID==employeeID){
                            temp=true;
                            System.Console.WriteLine("Enter the action to be performed: 1.Calculate Salary 2.Display Employee Details 3.Exit:");
                            string action=Console.ReadLine();
                            switch(action){
                                case "1":{
                                    System.Console.WriteLine(employeeDetails.SalaryCalculation(employeeDetails.NumberOfLeaveTaken,employeeDetails.NumberOfWorkingDays));
                                    break;
                                }
                                case "2":{
                                    System.Console.WriteLine($"Employee ID: {employeeDetails.EmployeeID}");
                                    System.Console.WriteLine($"Employee Name: {employeeDetails.EmployeeName}");
                                    System.Console.WriteLine($"Employee Role: {employeeDetails.EmployeeRole}");
                                    System.Console.WriteLine($"Employee Work Location: {employeeDetails.WorkLocation}");
                                    System.Console.WriteLine($"Employee Team Name: {employeeDetails.TeamName}");
                                    System.Console.WriteLine($"Employee Date of Joining: {employeeDetails.DateOfJoining.ToString("dd/MM/yyyy")}");
                                    System.Console.WriteLine($"Number of working days: {employeeDetails.NumberOfWorkingDays}");
                                    System.Console.WriteLine($"Number of leave taken: {employeeDetails.NumberOfLeaveTaken}");
                                    System.Console.WriteLine($"Gender: {employeeDetails.Gender}");
                                    break;
                                }
                                case "3":{
                                    option="1";
                                    break;
                                }
                                default:{
                                    System.Console.WriteLine("Invalid option");
                                    break;
                                }
                            }
                            break;
                            
                        }else{
                            temp=false;
                        }
                    }
                    if(temp==false){
                        System.Console.WriteLine("User ID Invalid");
                    }
                    break;
                }
            }

        }while(option!="3");
    }

    
}