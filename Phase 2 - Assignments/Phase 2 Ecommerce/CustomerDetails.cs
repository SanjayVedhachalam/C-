using System;

namespace Phase_2_Ecommerce
{
    public class CustomerDetails
    {
        private static int s_customerID=1000;
        public string CustomerID{get;}
        public string CustomerName{get;set;}
        public string CustomerCity{get;set;}
        public long CustomerMobileNumber{get;set;}
        public double CustomerWalletBalance { get; set; }
        public string CustomerEmailID { get; set; }

        public CustomerDetails(string customerName,string customerCity,long customerMobileNumber,double customerWalletBalance,string customerEmailID){
            ++s_customerID;
            CustomerID="CID"+s_customerID;
            CustomerName=customerName;
            CustomerCity=customerCity;
            CustomerMobileNumber=customerMobileNumber;
            CustomerWalletBalance=customerWalletBalance;
            CustomerEmailID=customerEmailID;
        }
        public double WalletRecharge(double rechargeAmount){
            CustomerWalletBalance+=rechargeAmount;
            System.Console.WriteLine("Recharge Done Successfully !!");
            return CustomerWalletBalance;
        }
        public double DeductBalance(double purchasingAmount){
            if(purchasingAmount>CustomerWalletBalance){
                System.Console.WriteLine("Insufficient Wallet Balance. Please recharge the wallet with amount {} to purchase it.");
                return CustomerWalletBalance;
            }
            else{
                System.Console.WriteLine("Purchase Successful !!");
                System.Console.Write("Remaining Balance: ");
                double walletDeductedBalance=CustomerWalletBalance-purchasingAmount;
                return walletDeductedBalance;
            }
        }
    }
}
