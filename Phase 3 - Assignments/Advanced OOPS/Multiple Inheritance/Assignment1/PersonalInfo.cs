using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1
{
    public enum MartialDetails{Select, Married, Single}
    public class PersonalInfo : IShowData
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public MartialDetails MartialDetails { get; set; }
        public void ShowInfo()
        {
            
            System.Console.WriteLine("Displaying Personal Details");
            System.Console.WriteLine("________________________________________");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Gender: {Gender}");
            System.Console.WriteLine($"Date of birth: {DOB}");
            System.Console.WriteLine($"Phone: {Phone}");
            System.Console.WriteLine($"Martial Details: {MartialDetails}");
        }
    }
}