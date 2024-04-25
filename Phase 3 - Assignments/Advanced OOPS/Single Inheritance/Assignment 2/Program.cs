using System;
using Assignment_2;
namespace Assignment2;
class Program{
    public static void Main(string[] args)
    {
        AccountInfo account1=new AccountInfo("Sanjay","Vedhachalam",567483929,"sanjayvedha@gmail.com",new DateTime(2001,12,21),"Male","Kodambakkam","IFSC HDFC7001",1000);
        AccountInfo account2=new AccountInfo("Latha","Lal",587654433,"lathaa@gmail.com",new DateTime(2001,10,01),"Female","Alapakkam","IFSC HDFC7001",1500);
        AccountInfo account3=new AccountInfo("Vedha","Erukan",576543456,"vedha@gmail.com",new DateTime(2001,01,07),"Male","Valasaravakkam","IFSC HDFC7001",500);
        
        account1.ShowAccountInfo();
        account1.Deposit();
        account1.Withdraw();
        account1.ShowBalance();

        account2.ShowAccountInfo();
        account2.Deposit();
        account2.Withdraw();
        account2.ShowBalance();

        account3.ShowAccountInfo();
        account3.Deposit();
        account3.Withdraw();
        account3.ShowBalance();
    }
}