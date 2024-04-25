using System;

namespace Assignment4
{
    public class PersonDetails
    {
        

        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }
        public PersonDetails(string name,string fatherName,string gender,string qualification)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Qualification=qualification;
        }
    }
}
