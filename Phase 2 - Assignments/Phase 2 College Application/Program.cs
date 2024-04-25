using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using Phase_2_College_Application;
namespace Phase2CollegeApplication;
class Program{
    public static void Main(string[] args)
    {
        string studentID="";
        string studentName;
        string fatherName;
        DateTime dob;
        Gender gender;
        double physics;
        double chemistry;
        double maths;

        string departmentID;
        string departmentName;
        int numberOfSeats;
        string option="";
        string admissionID;
        DateTime admissionDate;
        AdmissionStatus admissionStatus;

        List<StudentDetails> students=new List<StudentDetails>();
        List<DepartmentDetails> departments=new List<DepartmentDetails>();
        List<AdmissionDetails> admissions=new List<AdmissionDetails>();

        DateTime dob1;
        bool dob11=DateTime.TryParse("11/11/1999",null,out dob1);
        Gender gender1;
        bool g1=Enum.TryParse<Gender>("Male",true,out gender1);
        StudentDetails student1=new StudentDetails("","Ravichandran E","Ettapparajan",dob1,gender1,95,95,95);
        students.Add(student1);

        DateTime dob2;
        bool dob12=DateTime.TryParse("11/11/1999",null,out dob2);
        Gender gender2;
        bool g2=Enum.TryParse<Gender>("Male",true,out gender2);
        StudentDetails student2=new StudentDetails("","Baskaran S","Sethurajan",dob2,gender2,95,95,95);
        students.Add(student2);

        DepartmentDetails department1=new DepartmentDetails("","EEE ",29);
        departments.Add(department1);
        DepartmentDetails department2=new DepartmentDetails("","CSE ",29);
        departments.Add(department2);
        DepartmentDetails department3=new DepartmentDetails("","MECH",30);
        departments.Add(department3);
        DepartmentDetails department4=new DepartmentDetails("","ECE ",30);
        departments.Add(department4);

        DateTime admisDate1;
        bool ad1=DateTime.TryParse("11/05/2022",null,out admisDate1);
        AdmissionStatus adminstat1;
        bool adminst1=Enum.TryParse<AdmissionStatus>("Booked",true,out adminstat1);

        AdmissionDetails admission1=new AdmissionDetails("",student1.StudentID,department1.DepartmentID,admisDate1,adminstat1);
        admissions.Add(admission1);
        DateTime admisDate2;
        bool ad2=DateTime.TryParse("12/05/2022",null,out admisDate2);
        AdmissionStatus adminstat2;
        bool adminst2=Enum.TryParse<AdmissionStatus>("Booked",true,out adminstat2);
        AdmissionDetails admission2=new AdmissionDetails("",student2.StudentID,department2.DepartmentID,admisDate2,adminstat2);
        admissions.Add(admission2);

        do{
            System.Console.WriteLine("Welcome to Syncfusion College of Engineering and Technology");
            System.Console.WriteLine();
            System.Console.WriteLine("Application Process");
            System.Console.WriteLine("1. Student Registration");
            System.Console.WriteLine("2. Student Login");
            System.Console.WriteLine("3. Department wise seat availability");
            System.Console.WriteLine("4. Exit");
            System.Console.Write("Select the option to be performed: ");
            option=Console.ReadLine();

            switch(option){
                case "1":{
                    System.Console.WriteLine("Enter the following details");
                    System.Console.Write("Student Name: ");
                    studentName=Console.ReadLine();
                    System.Console.Write("Father Name: ");
                    fatherName=Console.ReadLine();
                    System.Console.Write("Date of Birth: ");
                    bool validDOB=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out dob);
                    while(validDOB!=true){
                        System.Console.Write("Enter date of birth in the correct format[dd/MM/yyyy]: ");
                        validDOB=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out dob);
                    }
                    System.Console.Write("Gender: ");
                    bool validGender=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
                    while(validGender!=true){
                        System.Console.Write("Enter the correct gender[Male/Female/Trans]: ");
                        validGender=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
                    }
                    System.Console.Write("Physics Marks: ");
                    physics=double.Parse(Console.ReadLine());
                    System.Console.Write("Chemistry Marks: ");
                    chemistry=double.Parse(Console.ReadLine());
                    System.Console.Write("Maths Marks: ");
                    maths=double.Parse(Console.ReadLine());
                    
                    StudentDetails student=new StudentDetails(studentID,studentName,fatherName,dob,gender,physics,chemistry,maths);
                    students.Add(student);
                    studentID+=student.StudentID;
                    System.Console.WriteLine($"Student Registered Successfully and StudentID is {student.StudentID}");
                    break;
                }

                case "2":{
                    System.Console.WriteLine("Login Detais");
                    System.Console.Write("Enter your Student ID: ");
                    string studentIDNo=Console.ReadLine();
                    bool temp=false;
                    foreach(StudentDetails student in students){
                        if(student.StudentID==studentIDNo){
                            temp=true;
                            System.Console.WriteLine("Select the following action to be performed");
                            System.Console.WriteLine("a. Check Eligibility");
                            System.Console.WriteLine("b. Show Details");
                            System.Console.WriteLine("c. Take Admission");
                            System.Console.WriteLine("d. Cancel Admission");
                            System.Console.WriteLine("e. Show Admission details");
                            System.Console.WriteLine("f. Exit");
                            System.Console.Write("Enter an option: ");
                            string wish=Console.ReadLine();
                            
                            switch(wish){
                                case "a":{
                                    student.CheckEligibility(student.Physics,student.Chemistry,student.Maths);
                                    break;
                                }
                                case "b":{
                                    System.Console.WriteLine("Student Details");
                                    System.Console.WriteLine($"Student ID: {student.StudentID}");
                                    System.Console.WriteLine($"Student Name: {student.StudentName}");
                                    System.Console.WriteLine($"Father Name: {student.FatherName}");
                                    System.Console.WriteLine($"Date of Birth: {student.DOB}");
                                    System.Console.WriteLine($"Gender: {student.Gender}");
                                    System.Console.WriteLine($"Physics Mark: {student.Physics}");
                                    System.Console.WriteLine($"Chemistry Mark: {student.Chemistry}");
                                    System.Console.WriteLine($"Maths Mark: {student.Maths}");
                                    break;
                                }
                                case "c":{
                                    System.Console.WriteLine("You selected c. Take Admission");
                                    System.Console.WriteLine("Admission Procedure Details");
                                    System.Console.WriteLine("Select a Department ID from the list below:");
                                    foreach(DepartmentDetails department in departments){
                                        System.Console.WriteLine($"{department.DepartmentID}          {department.DepartmentName}");
                                    }
                                    bool admissionvar=false;
                                    while(admissionvar==false){
                                        System.Console.Write("Enter Department ID: ");
                                    string studentDepartmentID=Console.ReadLine();
                                    bool temp1=false;
                                    foreach(DepartmentDetails department in departments){
                                        if(studentDepartmentID==department.DepartmentID){
                                            temp1=true;
                                            bool eligibility=student.CheckEligibility(student.Physics,student.Chemistry,student.Maths);
                                            if(eligibility==true){
                                                if(department.NumberOfSeats<0){
                                                    System.Console.WriteLine("All seats have been filled in {0} department",department.DepartmentName);
                                                }
                                                else{
                                                    
                                                    foreach(AdmissionDetails admission in admissions){
                                                        if(admission.StudentID==student.StudentID){
                                                            admissionvar=true;
                                                            System.Console.WriteLine("You have already taken admission");
                                                        }
                                                    }
                                                    if(admissionvar==false){
                                                        AdmissionDetails admission=new AdmissionDetails("",student.StudentID,department.DepartmentID,DateTime.Now,AdmissionStatus.Booked);
                                                        admissions.Add(admission);
                                                        department.NumberOfSeats-=1;
                                                        System.Console.WriteLine($"Admission took successfully. Your Admission ID is: {admission.AdmissionID}");
                                                        admissionvar=true;
                                                        break;
                                                    }

                                                }
                                            }
                                            else{
                                                admissionvar=true;
                                                break;
                                            }
                                        }
                                    }
                                    if(temp1==false){
                                        System.Console.WriteLine("Department ID is Invalid. Please Try again.");
                                    }
                                    }
                                    break;
                                }
                                case "d":{
                                    bool checkAdmission=false;
                                    foreach(AdmissionDetails admission in admissions){
                                        if(admission.StudentID==student.StudentID){
                                            checkAdmission=true;
                                            if(admission.AdmissionStatus==AdmissionStatus.Booked){
                                                admission.AdmissionStatus=AdmissionStatus.Cancelled;
                                                System.Console.WriteLine("Admission Cancelled Successfully");
                                                foreach(DepartmentDetails department in departments){
                                                    if(admission.DepartmentID==department.DepartmentID){
                                                        department.NumberOfSeats+=1;
                                                    }
                                                }
                                                break;
                                            }
                                            else if(admission.AdmissionStatus==AdmissionStatus.Cancelled){
                                                System.Console.WriteLine("You have already cancelled");
                                                break;
                                            }
                                        }
                                    }
                                    if(checkAdmission==false){
                                        System.Console.WriteLine("You have not taken any application");
                                    }
                                    break;
                                }
                                case "e":{
                                    System.Console.WriteLine("You selected e. Show Admission Details");
                                    foreach(AdmissionDetails admission in admissions){
                                        if(student.StudentID==admission.StudentID){
                                            System.Console.WriteLine("Admission Details for Student {0}",student.StudentID);
                                            System.Console.WriteLine("Admission ID          Student ID        Department ID        Admission Date        Admission Status");
                                            System.Console.WriteLine($"{admission.AdmissionID}               {admission.StudentID}            {admission.DepartmentID}               {admission.AdmissionDate.ToString("dd/MM/yyyy")}            {admission.AdmissionStatus}");
                                            System.Console.WriteLine();
                                        }
                                    }
                                    
                                    break;
                                    }
                                case "f":{
                                    
                                    break;
                                }
                                
                            }
                        }
                    }
                    if(temp==false){
                        System.Console.WriteLine("Invalid Student ID");
                    }
                    break;
                }
                case "3":{
                    System.Console.WriteLine("Department wise seat availability"); 
                    System.Console.WriteLine("Department ID         Available Departments      Number of Seats Available");
                    foreach(DepartmentDetails department in departments){
                       System.Console.WriteLine($"{department.DepartmentID}                {department.DepartmentName}                        {department.NumberOfSeats}");
                    }
                    System.Console.WriteLine();
                    break;
                }

                case "4":{
                    option="f";
                    break;
                }
            }
            

        }while(option!="f");
    }
}