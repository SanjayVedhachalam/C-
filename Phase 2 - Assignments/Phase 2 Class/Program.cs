using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Transactions;
using Phase_2_Class;
namespace Phase2;
class Program{
    public static void Main(string[] args)
    {
        List<BankDetails> details=new List<BankDetails>();
        System.Console.WriteLine("Welcome to HDFC");
        string option="";
        string custID;
        string custName;
        int balance;
        Gender custGender;
        long phoneno;
        string custEmail;
        DateTime dob;
       
        
        do{
            System.Console.WriteLine("Enter the required option: 1. Registration 2. Login 3. Exit");
            option=Console.ReadLine();
            
            switch(option){
                case "1":{
                System.Console.WriteLine("Registration Details");
                
                System.Console.Write("Enter your name: ");
                custName=Console.ReadLine();
                System.Console.Write("Enter balance: ");
                balance=int.Parse(Console.ReadLine());
                System.Console.Write("Enter your gender: ");
                custGender=Enum.Parse<Gender>(Console.ReadLine(),true);
                
                System.Console.Write("Enter Phone No: ");
                phoneno=long.Parse(Console.ReadLine());
                System.Console.Write("Enter your emailID: ");
                custEmail=Console.ReadLine();
                System.Console.Write("Enter your DOB: ");
                dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                
                BankDetails bank = new BankDetails(custName,balance,custGender,phoneno,custEmail,dob);
                details.Add(bank);
                System.Console.WriteLine("Registration Successful");
                System.Console.WriteLine($"Your Customer ID is {bank.CustomerID}");
                break;
            }
            case "2":{
                    System.Console.Write("Enter Customer ID: ");
                    custID=Console.ReadLine();
                    bool temp=false;
                    if(custID=="Exit"){
                        break;
                    }
                    foreach(BankDetails bank1 in details){
                        
                        if(bank1.CustomerID==custID){
                            temp=true;
                            System.Console.WriteLine("Enter the action to be performed: 1. Deposit 2. Withdraw 3. Balance Check 4. Exit");
                            string action=Console.ReadLine();
                            switch(action){
                                case "1":{
                                    System.Console.Write("Enter the amount to be deposited: ");
                                    int amount=int.Parse(Console.ReadLine());
                                    System.Console.WriteLine($"Current Balance after deposit: {bank1.Deposit(amount)}");
                                    break;
                                }
                                case "2":{
                                    System.Console.Write("Enter the amount to be withdrawn: ");
                                    int amount=int.Parse(Console.ReadLine());
                                    System.Console.WriteLine($"Current Balance after withdrawal: {bank1.Withdrawn(amount)}");
                                    break;
                                }
                                case "3":{
                                    System.Console.WriteLine($"Current Balance: {bank1.BalanceAmount()}");
                                    break;
                                }
                                case "4":{
                                    option="1";
                                    break;
                                }
                                default:{
                                    System.Console.WriteLine("Invalid case");
                                    break;
                                }
                            }
                            break;
                        }
                        else{
                            temp=false;
                        }
                        
                    }
                    if(temp==false){
                        System.Console.WriteLine("Invalid Input");
                    }
                    
                break;
            }
            case "3":{
                option="3";

                break;
            }
                    
                    
            }
        
        }while(option!="3");
    }
}