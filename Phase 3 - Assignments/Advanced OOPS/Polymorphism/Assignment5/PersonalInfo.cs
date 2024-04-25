using System;

namespace Assignment5
{
    public abstract class PersonalInfo
    {
        

        public string Name { get; set; }
        public string FatherName { get; set; }
        public long MobileNumber { get; set; }
        public string Gender { get; set; }
        public abstract void Display();

        public PersonalInfo(string name,string fatherName,long mobileNumber,string gender)
        {
            Name=name;
            FatherName=fatherName;
            MobileNumber=mobileNumber;
            Gender=gender;        
        }
    }
}
