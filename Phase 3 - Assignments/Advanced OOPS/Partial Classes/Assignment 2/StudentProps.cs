using System;

namespace Assignment_2
{
    public partial class StudentInfo
    {
        private static int s_studentID = 1000;
        public string StudentID { get; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public DateTime DOB { get; set; }
        public long MobileNumber { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Maths { get; set; }
    }
}
