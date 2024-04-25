using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class PersonalInfo
    {
         public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Mail { get; set; }
        public virtual void Update(){
            System.Console.WriteLine("Updating Details");
            System.Console.Write("Enter Name: ");
            Name=Console.ReadLine();
            System.Console.Write("Enter Father Name: ");
            FatherName=Console.ReadLine();
            System.Console.Write("Enter Mobile: ");
            Phone=Console.ReadLine();
            System.Console.Write("Enter Mail: ");
            Mail=Console.ReadLine();
            System.Console.Write("Enter Gender: ");
            Gender=Console.ReadLine();
        } 
        public virtual void DisplayInfo(){
            System.Console.WriteLine("Family Details");
            System.Console.WriteLine($"Name     : {Name}");
            System.Console.WriteLine($"Father Name      : {FatherName}");
            System.Console.WriteLine($"Phone            : {Phone}");
            System.Console.WriteLine($"Gender           : {Gender}");
            System.Console.WriteLine($"Mail             : {Mail}");
        }
    }
}