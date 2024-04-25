using System;


namespace Phase_2_College_Application
{
    /// <summary>
    /// DataType Gender is used to select an instance of <see cref="StudentDetails"/> which contains the Gender options
    /// of [Male, Female, Trans].
    /// </summary>
    public enum Gender{Select, Male, Female, Trans}
    /// <summary>
    /// Class StudentDetails used to create instance for student <see cref="StudentDetails"/>
    /// Refer Documentation on <see href="www.syncfusion.com"/>
    /// </summary>
    public class StudentDetails
    {
        /// <summary>
        /// A unique ID details assigned and incremented when each Student registers <see cref="StudentDetails"
        /// </summary> 
        private static int s_studentID=3000;
        /// <summary>
        /// Holds the ID value of the respective Student which is unique for each students. Used to hold the Student's ID of instance class <see cref="StudentDetails"/>
        /// </summary>
        public string StudentID{get;set;}
        /// <summary>
        /// Stores the First name of each Student of instance class <see cref="StudentDetails"/>
        /// </summary>
        public string StudentName{get;set;}
        /// <summary>
        /// Stores the Father name of each Student of instance class <see cref="StudentDetails"/>
        /// </summary>
        public string FatherName{get;set;}
        /// <summary>
        /// Stores the Date of birth of each of the Student of instance class <see cref="StudentDetails"/>
        /// </summary>
        public DateTime DOB{get;set;}
        /// <summary>
        /// Stores the Gender of each Student of instance class <see cref="StudentDetails"
        /// </summary> 
        public Gender Gender{get;set;}
        /// <summary>
        /// Stores the Physics mark of the Student of instance class <see cref="StudentDetails"/>
        /// </summary>
        /// <value></value>
        public double Physics{get;set;}
        /// <summary>
        /// Stores the Chemistry mark of the Student of instance class <see cref="StudentDetails"/>
        /// </summary>
        /// <value></value>
        public double Chemistry{get;set;}
        /// <summary>
        /// Stores the Maths mark of the Student of instance class <see cref="StudentDetails"/>
        /// </summary>
        /// <value></value>
        public double Maths{get;set;}
        /// <summary>
        /// Default Constructor used to initialize its default values to its properties. 
        /// </summary> <summary>
        /// 
        /// </summary>
        public StudentDetails(){
            StudentName="Enter Student Name";
            FatherName="Enter Father Name";
            Gender=Gender.Select;
        }
        /// <summary>
        /// Paramterized Construtor used to initialize the parameter values to its properties.
        /// </summary>
        /// <param name="studentID">studentID parameter used to assign its value to associated property that is StudentID</param>
        /// <param name="studentName">studentName parameter used to assign its value to associated property that is StudentName</param>
        /// <param name="fatherName">FatherName parameter used to assign its value to associated property that is FatherName</param>
        /// <param name="dob">dob parameter used to assign its value to associated property that is DOB</param>
        /// <param name="gender">gender parameter used to assign its value to associated property that is Gender</param>
        /// <param name="physics">physics parameter used to assign its value to associated property that is Physics</param>
        /// <param name="chemistry">chemistry parameter used to assign its value to associated property that is Chemistry</param>
        /// <param name="maths">maths parameter used to assign its value to associated property that is Maths</param> <summary>
        /// 
        /// </summary>
        
        public StudentDetails(string studentID,string studentName,string fatherName,DateTime dob,Gender gender,double physics,double chemistry,double maths)
        {
            ++s_studentID;
            StudentID="SF"+s_studentID.ToString();
            StudentName=studentName;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        /// <summary>
        /// CheckEligibility is used to check whether the instance of <see cref="StudentDetails"/>
        /// is eligible for admission based on the cutoff
        /// </summary>
        /// <param name="physics">Mark of the Student in Physics</param>
        /// <param name="chemistry">Mark of the Student in Chemistry</param>
        /// <param name="maths">Mark of the Student in Maths</param>
        /// <returns>Returns true if eligible and also print "Student is Eligible" 
        /// else false if not eligible and also prints "Student is not Eligible"</returns> 
        public bool CheckEligibility(double physics, double chemistry, double maths)
        {
            double average=(physics+chemistry+maths)/3;
            if(average>=75.0){
                System.Console.WriteLine("Student is eligible");
                return true;
            }
            else{
                System.Console.WriteLine("Student is not eligible");
                return false;
            }
            
        }
    }
    
}
