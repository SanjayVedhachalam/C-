using System;
using System.Collections.Generic;
using Phase_2_Class___3;
namespace Phase2Class3;
class Program{
    public static void Main(string[] args)
    {
        string meterID;
        string userName;
        long phoneNo;
        string mailID;
        double unitsUsed=0;
        List<EBDetails> eBDetails=new List<EBDetails>();

        string option;

        do{
            System.Console.WriteLine("Welcome to EB");
            System.Console.WriteLine("Enter the option: 1.Registration 2.Login 3.Exit");
            option=Console.ReadLine();
            
            switch(option){
                case "1":{
                    System.Console.WriteLine("Registration Details");
                
                    System.Console.Write("Enter User Name: ");
                    userName=Console.ReadLine();
                    System.Console.Write("Enter Phone number: ");
                    phoneNo=int.Parse(Console.ReadLine());
                    System.Console.Write("Enter email id: ");
                    mailID=Console.ReadLine();
                    
                    EBDetails eB=new EBDetails(userName,phoneNo,mailID);
                    System.Console.WriteLine("Succesfully Registered. Your EB ID is {0}",eB.EBID);

                    eBDetails.Add(eB);
                    break;
                }
                case "2":{
                    System.Console.Write("Enter Meter ID: ");
                    meterID=Console.ReadLine();
                    bool temp=true;
                    foreach(EBDetails eB in eBDetails){
                        if(eB.EBID==meterID){
                            System.Console.WriteLine("Enter the action to be performed: 1.Calculate amount 2.Display Details 3.Exit");
                            string action=Console.ReadLine();
                            temp=true;
                            switch(action){
                                case "1":{
                                    System.Console.Write("Enter the consumption of units used: ");
                                    unitsUsed=double.Parse(Console.ReadLine());
                                    System.Console.WriteLine($"EB bill generated \nBill ID: {eB.BillID} \nUnits Used: {unitsUsed} \nBill Amount: {eB.AmountCalculation(unitsUsed)}");
                                    System.Console.WriteLine();
                                    break;
                                }
                                case "2":{
                                    System.Console.WriteLine("User Details");
                                    System.Console.WriteLine($"Meter ID: {eB.EBID}");
                                    System.Console.WriteLine($"User Name: {eB.UserName}");
                                    System.Console.WriteLine($"Phone number: {eB.PhoneNumber}");
                                    System.Console.WriteLine($"Mail ID: {eB.EmailID}");
                                    System.Console.WriteLine();
                                    break;
                                }
                                case "3":{
                                    option="1";
                                    break;
                                }
                                default:{
                                    System.Console.WriteLine("Invalid Case");
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
                        System.Console.WriteLine("Invalid Meter ID");
                        System.Console.WriteLine();
                    }
                    break;
                }
            }
        }while(option!="3");
    }
}
