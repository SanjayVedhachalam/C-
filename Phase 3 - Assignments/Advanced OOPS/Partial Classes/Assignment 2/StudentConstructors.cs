using System;

namespace Assignment_2
{
    public partial class StudentInfo
    {
        public StudentInfo(string studentName,string gender,DateTime dob,long mobileNumber,double physics,double chemistry,double maths){
            ++s_studentID;
            StudentID="SF"+s_studentID;
            StudentName=studentName;
            StudentGender=gender;
            DOB=dob;
            MobileNumber=mobileNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        public StudentInfo(string studentID,string studentName,string gender,DateTime dob,long mobileNumber,double physics,double chemistry,double maths){
            
            StudentID=studentID;
            StudentName=studentName;
            StudentGender=gender;
            DOB=dob;
            MobileNumber=mobileNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
    }
}
