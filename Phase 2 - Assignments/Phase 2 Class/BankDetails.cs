using System;
using System.Dynamic;

namespace Phase_2_Class
{
    public enum Gender{Select, Male, Female, Trans}
    public class BankDetails
    {
        private static int s_custID=1000;
        public string CustomerID{get;set;}
        public string CustomerName{get;set;}
        public int Balance{get;set;}
        public Gender Gender{get;set;}
        public long PhoneNo{get;set;}
        public string MailID{get;set;}
        public DateTime DOB{get;set;}

        public BankDetails(string custName, int balance, Gender custGender, long phoneno,string custEmail, DateTime dob)
        {
            ++s_custID;
            CustomerID="HDFC"+s_custID.ToString();
            CustomerName=custName;
            Balance=balance;
            Gender=custGender;
            PhoneNo=phoneno;
            MailID=custEmail;
            DOB=dob;
           
        }

        public int Deposit(int amount)
        {
            int money=amount;
            Balance=Balance+amount;
            return Balance;
        }

        
        public int Withdrawn(int amount)
        {
            int money=amount;
            Balance=Balance-amount;
            return Balance;
        }

        public int BalanceAmount()
        {
            return Balance;
        }
    }
}
