using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class FamilyInfo:PersonalInfo
    {
        public string MotherName { get; set; }
        //public string FatherName { get; set; }
        public string NativePlace { get; set; }
        public int NumberOfSiblings { get; set; }
        public sealed override void Update()
        {
            base.Update();
            System.Console.Write("Enter Mother Name: ");
            MotherName=Console.ReadLine();   
            System.Console.Write("Enter Number of Sibilings: ");
            NumberOfSiblings=int.Parse(Console.ReadLine());   
            System.Console.Write("Enter Native Place: ");
            NativePlace=Console.ReadLine();
        }
        public sealed override void DisplayInfo()
        {
            base.DisplayInfo();
            System.Console.WriteLine($"Mother Name      : {MotherName}");
            System.Console.WriteLine($"Number of Siblings       : {NumberOfSiblings}");
            System.Console.WriteLine($"Native Place     : {NativePlace}");
            System.Console.WriteLine("________________________________________________");
        }
    }
}