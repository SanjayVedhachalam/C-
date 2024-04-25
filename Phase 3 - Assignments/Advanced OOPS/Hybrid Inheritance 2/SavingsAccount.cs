using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid_Inheritance_2
{
    public enum AccountType{Select, Savings, Balance}
    public class SavingsAccount : IDInfo, ICalculate, IBankInfo
    {
        private static int s_accountNumber=1000;
        public string AccountNumber{get;}
        public AccountType AccountType{get;set;}
        public string BankName { get ;set; }
        public string IFSC { get; set; }
        public string Branch { get ; set; }
        public double Balance { get; set; }
        public SavingsAccount(string name,string phone, DateTime dob, string gender,string voterID,string aadharID,string panNumber,string bankName,string ifsc,string branch,AccountType accountType,double balance){
            ++s_accountNumber;
            AccountNumber="ACCNO"+s_accountNumber;
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            _voterID=voterID;
            _aadharID=aadharID;
            _panNumber=panNumber;
            BankName=bankName;
            IFSC=ifsc;
            Branch=branch;
            AccountType=accountType;
            Balance=balance;
        }
        public double BalanceCheck()
        {
            return Balance;
        }

        public double Deposit(double depositAmount)
        {
            Balance+=depositAmount;
            return Balance;
        }

        public double Withdraw(double withdrawAmount)
        {
            Balance-=withdrawAmount;
            return Balance;
        }
    }
}