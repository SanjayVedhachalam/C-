using System;
using System.Collections.Generic;
using Phase_2_Payroll_Management;

namespace Phase2Payroll;
class Program{
    public static void Main(string[] args)
    {
        string employeeID;
        string employeeFullName;
        DateTime dob;
        long mobileNo;
        string gender;
        Branch branch;
        Team team;
        string option;

        List<EmployeeDetails> employees=new List<EmployeeDetails>();
        List<AttendanceDetaills> attendances=new List<AttendanceDetaills>();

        DateTime checkinTime;
        DateTime checkoutTime;
        DateTime employee1dob;
        bool dob1=DateTime.TryParse("11/11/1999",null,out employee1dob);
        Branch employee1branch;
        bool branch1=Enum.TryParse<Branch>("Eymard",true,out employee1branch);
        Team employee1team;
        bool team1=Enum.TryParse<Team>("Developer",true,out employee1team);
        
        EmployeeDetails employee1=new EmployeeDetails("","Ravi",employee1dob,9958858888,"Male",employee1branch,employee1team);
        employees.Add(employee1); 

        string attendanceID;
        DateTime date;
        
        DateTime employee1date;
        bool date1=DateTime.TryParse("15/05/2022",null,out employee1date);
        DateTime employee1cit;
        bool cit1=DateTime.TryParse("09:00 AM",null,out employee1cit);
        DateTime employee1cot;
        bool cot1=DateTime.TryParse("06:10 PM",null,out employee1cot);
        int employee1hoursWorked=8;

        AttendanceDetaills attendance1=new AttendanceDetaills("",employee1.EmployeeID,employee1date,employee1cit,employee1cot,employee1hoursWorked);
        attendances.Add(attendance1);

       
        DateTime date2;
        DateTime checkinTime1;
        DateTime checkoutTime1;
        DateTime employee2date;
        bool date3=DateTime.TryParse("16/05/2022",null,out employee2date);
        DateTime employee2cit;
        bool cit2=DateTime.TryParse("09:10 AM",null,out employee2cit);
        DateTime employee2cot;
        bool cot2=DateTime.TryParse("06:50 PM",null,out employee2cot);
        int employee2hoursWorked=8;

        AttendanceDetaills attendance2=new AttendanceDetaills("","SF3002",employee2date,employee2cit,employee2cot,employee2hoursWorked);
        attendances.Add(attendance2);
        int hoursWorked;
        do{
            System.Console.WriteLine("Welcome to Payroll Management System of Syncfusion Software Private Limited");
            System.Console.WriteLine("1. Employee Registration");
            System.Console.WriteLine("2. Employee Login");
            System.Console.WriteLine("3. Exit");
            System.Console.Write("Enter your option: ");
            option=Console.ReadLine();
            switch(option){
                case "1":{
                    System.Console.WriteLine("Employee Details");
                    System.Console.Write("Enter Employee Full Name: ");
                    employeeFullName=Console.ReadLine();
                    System.Console.Write("Enter Employee Date of Birth: ");
                    dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                    System.Console.Write("Enter Employee Mobile Number");
                    mobileNo=long.Parse(Console.ReadLine());
                    System.Console.Write("Enter Employee Gender: ");
                    gender=Console.ReadLine();
                    System.Console.Write("Enter Employee Branch");
                    bool condition=Enum.TryParse<Branch>(Console.ReadLine(),true,out branch);
                    System.Console.Write("Enter Employee Team: ");
                    bool condition1=Enum.TryParse<Team>(Console.ReadLine(),true,out team);

                    EmployeeDetails employee=new EmployeeDetails("",employeeFullName,dob,mobileNo,gender,branch,team);
                    employees.Add(employee);
                    System.Console.WriteLine($"Employee added successfully your is: {employee.EmployeeID}");
                    break;
                }
                case "2":{
                    System.Console.WriteLine("Login");
                    System.Console.Write("Enter employee ID: ");
                    string empID=Console.ReadLine();
                    bool temp=false;
                    foreach(EmployeeDetails employee in employees){
                        if(employee.EmployeeID==empID){
                            System.Console.WriteLine("Choose from the following option");
                            System.Console.WriteLine("i. Add Attendance");
                            System.Console.WriteLine("ii. Display Details");
                            System.Console.WriteLine("iii. Calculate Salary");
                            System.Console.Write("Select your option: ");
                            string action=Console.ReadLine();
                            switch(action){
                                case "i":{
                                    
                                    
                                    System.Console.WriteLine("Add Attendance");
                                    System.Console.Write("Do you want to Check-In?[Yes/no]: ");
                                    string checkin=Console.ReadLine().ToLower();
                                    if(checkin=="yes"){
                                        System.Console.Write("Enter the Check in Date and Check in time: ");
                                        DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy hh/mm ffff",null,System.Globalization.DateTimeStyles.None,out checkinTime); 
                                    }
                                    System.Console.Write("Do you want to Check-Out?[Yes/no]: ");
                                    string checkout=Console.ReadLine().ToLower();
                                    if(checkout=="yes"){
                                        System.Console.Write("Enter the Check out Date and Check out time: ");
                                        DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy hh/mm tt",null,System.Globalization.DateTimeStyles.None,out checkoutTime); 
                                    }
                                    TimeSpan time=checkoutTime-checkinTime;
                                    hoursWorked=time.Hours;
                                    if(hoursWorked>=8){
                                        AttendanceDetaills attendance=new AttendanceDetaills("",employee.EmployeeID,checkinTime,checkinTime,checkoutTime,hoursWorked);
                                        attendances.Add(attendance);
                                        System.Console.WriteLine("Check-in and Checkout Successful and today you have worked 8 Hours");
                                    }
                                    else{
                                        System.Console.WriteLine("You have not worked 8 hours so not accepted");
                                        break;
                                    }
                                    break;
                                }
                                case "ii":{
                                    System.Console.WriteLine("Display Details");
                                    System.Console.Write($"Employee ID: {employee.EmployeeID}");
                                    System.Console.Write($"Employee Name: {employee.EmployeeFullName}");
                                    System.Console.Write($"Employee Date of birth: {employee.DOB}");
                                    System.Console.Write($"Employee Mobile Number: {employee.MobileNumber}");
                                    System.Console.Write($"Employee Gender: {employee.Gender}");
                                    System.Console.Write($"Employee Branch: {employee.Branch}");
                                    System.Console.Write($"Employee Team: {employee.Team}");
                                    break;
                                }
                                case "iii":{
                                    System.Console.WriteLine("Calculate Salary");
                                    System.Console.WriteLine("Attendance ID              Employee ID            Date             Check-in Time            Check-out Time           Hours Worked");
                                    foreach(AttendanceDetaills attendance in attendances){
                                        if(attendance.EmployeeID==employee.EmployeeID){
                                        System.Console.WriteLine($"{attendance.AttendanceID}          {attendance.EmployeeID}        {attendance.Date.ToShortDateString()}        {attendance.CheckinTime}         {attendance.CheckoutTime}        {attendance.HoursWorked}");
                                        }
                                    } 
                                    string month=DateTime.Now.ToString("MM");
                                    int count=0;
                                    bool condi=false;
                                    foreach(AttendanceDetaills attendance in attendances){
                                        if(attendance.EmployeeID==employee.EmployeeID){
                                            condi=true;
                                            if(attendance.Date.ToString("MM")==month){
                                                count+=1;
                                            }
                                        }
                                    }
                                    if(condi==false){
                                        System.Console.WriteLine("You have no attendance in this month");
                                        break;
                                    }
                                    System.Console.WriteLine("Your Salary for the month of {0} is {1}",month,count*500);
                                    break;
                                }
                                case "iv":{
                                    break;
                                }
                            }
                        }
                    }
                    break;
                }
                case "3":{
                    option="3";
                    break;
                }

            }

        }while(option!="3");
    }
}