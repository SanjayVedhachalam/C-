using System;
using System.Reflection.Emit;

namespace Phase_2_Class___3
{
    public class EBDetails
    {
        private static int s_ebID=1000;
        private static int s_billID=100;
        public string EBID{get;set;}
        public string BillID{get;set;}
        public string UserName{get;set;}
        public long PhoneNumber{get;set;}
        public string EmailID{get;set;}
        public int UnitsUsed=0;
        

        public EBDetails(string userName, long phoneNo, string mailID)
        {
            ++s_ebID;
            ++s_billID;
            EBID="EB"+s_ebID.ToString();
            BillID="BILL"+s_billID.ToString();
            UserName = userName;
            PhoneNumber=phoneNo;
            EmailID=mailID;

        }

        public double AmountCalculation(double unitsUsed){
            double amount=unitsUsed*5;
            return amount;
        }
    }
}
