using System;

namespace Assignment_1
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public string Gender { get; set; }

        public PersonalInfo(string name, string fatherName, long phone, string mail, string gender)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Mail = mail;
            Gender = gender;
        }

        public void UpdateInfo(){
            System.Console.WriteLine("Updating Infomation");
            System.Console.Write("Enter Name: ");
            Name=Console.ReadLine();
            System.Console.Write("Enter Father Name: ");
            FatherName=Console.ReadLine();
            System.Console.Write("Enter Mobile: ");
            Phone=long.Parse(Console.ReadLine());
            System.Console.Write("Enter Mail: ");
            Mail=Console.ReadLine();
            System.Console.Write("Enter Gender: ");
            Gender=Console.ReadLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Updated Successfully");
        }
    }
}
