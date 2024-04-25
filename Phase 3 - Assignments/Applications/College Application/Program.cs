using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using College_Application;
namespace CollegeApplication;
class Program{
    public static void Main(string[] args)
    {
        //document file
        List<StudentDetails> studentList = new List<StudentDetails>();
        string option="";
        
        do{
            System.Console.WriteLine("Student Reegistration Form");
            //loop breaker

            // (since parameterized constructor is called ) StudentDetails student1=new StudentDetails(); //should be present inside the loop to create multiple objects for 
            //storing each object in the index position of the list. 
            //If it is given outside the loop it creates a single object and 
            //override the details previously filled details and creates a new memory space of the overriden data
            System.Console.WriteLine("Enter name:");
            string studentName=Console.ReadLine();
            System.Console.WriteLine("Enter father name:");
            string fatherName=Console.ReadLine();
            System.Console.WriteLine("Enter DOB:");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter Gender: 1.Male 2.Female 3.Trans");
            Gender gender =Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter phone no:");
            long phone=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Physics Mark");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Chemistry Mark");
            int chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Maths Mark");
            int maths=int.Parse(Console.ReadLine());

            StudentDetails student=new StudentDetails(studentName,fatherName,gender,dob,phone,physics,chemistry,maths);

            System.Console.WriteLine($"Your ID has been created successfully: ID No - {student.StudentID}");
            
            studentList.Add(student);
            foreach(StudentDetails students in studentList){
                System.Console.Write($"Student successfully added\nYour Name: {students.StudentName}\nYour Father Name: {students.FatherName}\nYour Gender: {students.Gender1} \nYour DOB: {students.DOB}\n");
                System.Console.WriteLine($"Your Phone number:{students.Phone}\nYour Physics Mark:{students.Physics}\nYour Chemistry Mark:{students.Chemistry}\nYour Maths Mark:{students.Maths}");
                System.Console.WriteLine();
            }
            option=Console.ReadLine();

        }while(option=="yes");
        
        System.Console.WriteLine("Enter your Login ID: ");
        string loginID=Console.ReadLine();
        bool flag=true;
        
        foreach(StudentDetails student in studentList){
            if(student.StudentID==loginID){
                flag = false;
                System.Console.Write($"Your Name: {student.StudentName}\nYour Father Name: {student.FatherName} \nYour DOB: {student.DOB}\n");
                System.Console.WriteLine($"Your Phone number:{student.Phone}\nYour Physics Mark:{student.Physics}\nYour Chemistry Mark:{student.Chemistry}\nYour Maths Mark:{student.Maths}");
                System.Console.WriteLine();
                if(student.CheckEligibility(75)){
                    System.Console.WriteLine("Your are eligible");
                }
                else{
                    System.Console.WriteLine("You are not eligible");
                }
            }
            }
            if(flag){
                System.Console.WriteLine("Invalid user ID");
            }


        GC.Collect();
        GC.WaitForPendingFinalizers();
        //student 1
        
    
        //student 2
    //     StudentDetails student2=new StudentDetails();
    //     System.Console.WriteLine("Enter name:");
    //     student2.StudentName=Console.ReadLine();
    //     System.Console.WriteLine("Enter father name:");
    //     student2.FatherName=Console.ReadLine();
    //     System.Console.WriteLine("Enter DOB:");
    //     student2.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
    //     System.Console.WriteLine("Enter phone no:");
    //     student2.Phone=long.Parse(Console.ReadLine());
    //     System.Console.WriteLine("Enter Physics Mark");
    //     student2.Physics=int.Parse(Console.ReadLine());
    //     System.Console.WriteLine("Enter Chemistry Mark");
    //     student2.Chemistry=int.Parse(Console.ReadLine());
    //     System.Console.WriteLine("Enter Maths Mark");
    //     student2.Maths=int.Parse(Console.ReadLine());

    //     studentList.Add(student2);
       
    //    //student 3
    //     StudentDetails student3=new StudentDetails();
    //     System.Console.WriteLine("Enter name:");
    //     student3.StudentName=Console.ReadLine();
    //     System.Console.WriteLine("Enter father name:");
    //     student3.FatherName=Console.ReadLine();
    //     System.Console.WriteLine("Enter DOB:");
    //     student3.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
    //     System.Console.WriteLine("Enter phone no:");
    //     student3.Phone=long.Parse(Console.ReadLine());
    //     System.Console.WriteLine("Enter Physics Mark");
    //     student3.Physics=int.Parse(Console.ReadLine());
    //     System.Console.WriteLine("Enter Chemistry Mark");
    //     student3.Chemistry=int.Parse(Console.ReadLine());
    //     System.Console.WriteLine("Enter Maths Mark");
    //     student3.Maths=int.Parse(Console.ReadLine());

        // studentList.Add(student3);
       
        

        // System.Console.Write($"Your Name: {student2.StudentName}\nYour Father Name: {student2.FatherName} \nYour DOB: {student2.DOB}\n");
        // System.Console.WriteLine($"Your Phone number:{student2.Phone}\nYour Physics Mark:{student2.Physics}\nYour Chemistry Mark:{student2.Chemistry}\nYour Maths Mark:{student1.Maths}");

        // System.Console.Write($"Your Name: {student3.StudentName}\nYour Father Name: {student3.FatherName} \nYour DOB: {student3.DOB}\n");
        // System.Console.WriteLine($"Your Phone number:{student3.Phone}\nYour Physics Mark:{student3.Physics}\nYour Chemistry Mark:{student3.Chemistry}\nYour Maths Mark:{student1.Maths}");
    }
}
