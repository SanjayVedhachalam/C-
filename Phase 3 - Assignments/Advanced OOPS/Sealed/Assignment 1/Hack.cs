using System;

namespace Assignment_1
{
    public class Hack : EmployeeInfo //Since the EmployeeInfo is a sealed class we cannot inherit or access its members
    {
        public string StoreUserID{get;set;}
        public string StorePassword{get;set;}
        public Hack(string password):base(password)
        {
            StoreUserID=UserID;
            StorePassword=Password;
        }

        public void ShowKeyInfo(){
            System.Console.WriteLine($"User Key Info is {KeyInfo}");
        }
        public void GetUserInfo(){
           System.Console.WriteLine("Updating details");
           System.Console.Write("Enter password: ");
           Password=Console.ReadLine();
        }
        public void ShowUserInfo(){
            base.DisplayInfo();
        }
    }
}
