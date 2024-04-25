using System;
using System.ComponentModel;
public enum Gender{Select, Male, Female, Trans}
namespace College_Application
{
    public class StudentDetails
    {
        // Field
        private static int s_studentID=1000;
        
        private string _studentName;
        // Properties 
        // public string StudentName
        // {
        //     get
        //     {                                // Used to set values or declare for a more detailed representation
        //         return _studentName;
        //         }
        //     set
        //     {
        //         _studentName=value;
        //         }
        // }

        //Autoproperty
        public string StudentID {get;}
        public string FatherName{get;set;}
        public string StudentName{get;set;}
        public Gender Gender1{get;set;}
        public DateTime DOB{get;set;}
        public long Phone{get;set;}
        public int Physics{get;set;}
        public int Chemistry{get;set;}
        public int Maths{get;set;}  
        // Events
        // Indexers
        // Constructors

            //Default Constructors
        public StudentDetails()
        {
            //used to initialize default values to the variables
            StudentName="Enter your name";
            FatherName="Enter your father name";
            Gender1=Gender.Select;

        }

            //Parameterized Constructors(should always follow Camel case convention for naming)
        public StudentDetails(string studentName, string fatherName, Gender gender, DateTime dob, long phone, int physics, int chemistry, int maths){
            s_studentID++;
            StudentID="SF"+s_studentID;
            StudentName=studentName;
            FatherName=fatherName;
            Gender1=gender;
            DOB=dob;
            Phone=phone;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        //Constructor over loading same name but different parameter
        public StudentDetails(string studentName, string fatherName, Gender gender, DateTime dob, long phone){
            StudentName=studentName;
            FatherName=fatherName;
            Gender1=gender;
            DOB=dob;
            Phone=phone;
        } 
        // Destructors
        ~StudentDetails(){
            System.Console.WriteLine("Destructor Called");
        }
        // Methods
        public bool CheckEligibility(double cutoff){
            double average=(Maths+Physics+Chemistry)/3;
            if(average>=cutoff){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
