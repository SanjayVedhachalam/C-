using System;

namespace Assignment_1
{
    public sealed class EmployeeInfo
    {
        private static int s_userID=1000;
        public string UserID{get;}
        public string Password{get;set;}
        protected int KeyInfo = 100;

        public EmployeeInfo(string password){
            ++s_userID;
            UserID="UID"+s_userID;
            Password=password;
        }
        public void UpdateInfo(){
           System.Console.WriteLine("Updating details");
           System.Console.Write("Enter password: ");
           Password=Console.ReadLine();
           
        }
        public void DisplayInfo(){
            System.Console.WriteLine("Display info");
            System.Console.WriteLine("UserID: "+UserID);
            System.Console.WriteLine($"Password: "+Password);
            System.Console.WriteLine($"Keyinfo: "+KeyInfo);
        }
    }
}
