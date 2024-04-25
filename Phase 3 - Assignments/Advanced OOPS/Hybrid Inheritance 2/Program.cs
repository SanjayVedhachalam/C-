using System;
using System.Runtime.InteropServices;
using Hybrid_Inheritance_2;
namespace HybridInheritance2;
class Program{
    public static void Main(string[] args)
    {
        SavingsAccount savingsAccount1=new SavingsAccount("Sanjay","987553434",new DateTime(2001,12,21),"Male","EF47wehs","780933722846","OBOTI0936L","HDFC","HDFC0075","WestMambalam",AccountType.Savings,12000);
        System.Console.WriteLine($"Balance : {savingsAccount1.BalanceCheck()}");
        System.Console.Write("Deposit or Withdraw: ");
        string wish=Console.ReadLine().ToLower();
        if(wish.Equals("deposit")){
            System.Console.WriteLine("Enter amount to be deposited");
            double depositAmount=double.Parse(Console.ReadLine());
            System.Console.WriteLine($"Amount Deposited. Available Balance : {savingsAccount1.Deposit(depositAmount)}");
        }
        else if(wish.Equals("withdraw")){
            System.Console.WriteLine("Enter amount to be withdrawn");
            double withAmount=double.Parse(Console.ReadLine());
            System.Console.WriteLine($"Amount Withdrawn. Available Balance : {savingsAccount1.Withdraw(withAmount)}");
        }

         SavingsAccount savingsAccount2=new SavingsAccount("Appi","757839322",new DateTime(2006,09,28),"Male","HOF3843P","47927743112","PSJ4728P","KVB","KVB1119","Kodambakkam",AccountType.Balance,17000);
        System.Console.WriteLine($"Balance : {savingsAccount2.BalanceCheck()}");
        System.Console.Write("Deposit or Withdraw: ");
        wish=Console.ReadLine().ToLower();
        if(wish.Equals("deposit")){
            
            System.Console.WriteLine("Enter amount to be deposited");
            double depositAmount=double.Parse(Console.ReadLine());
            System.Console.WriteLine($"Amount Deposited. Available Balance : {savingsAccount2.Deposit(depositAmount)}");
        }
        else if(wish.Equals("withdraw")){
            System.Console.WriteLine("Enter amount to be withdrawn");
            double withAmount=double.Parse(Console.ReadLine());
            System.Console.WriteLine($"Amount Withdrawn. Available Balance : {savingsAccount2.Withdraw(withAmount)}");
        }
    }
}