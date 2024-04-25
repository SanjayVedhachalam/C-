using System;
namespace Assignment6;
class Program{
    public static void Main(string[] args)
    {
        Bank sbiBank=new SBI();
        Bank iciciBank=new ICICI();
        Bank hdfcBank=new HDFC();
        Bank idbiBank=new IDBI();

        System.Console.WriteLine("The interest rate in SBI Bank is: "+sbiBank.GetIntresetInfo()+"%");
        System.Console.WriteLine("The interest rate in ICICI Bank is: "+iciciBank.GetIntresetInfo()+"%");
        System.Console.WriteLine($"The interest rate in HDFC Bank is: {hdfcBank.GetIntresetInfo()}%");
        System.Console.WriteLine($"The interest rate in IDBI Bank is: {idbiBank.GetIntresetInfo()}%");


    }
}