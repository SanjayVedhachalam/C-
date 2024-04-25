using System;
namespace Assignment3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("--------------------------------------------------");
        EEEdepartment eEE=new EEEdepartment("","","",0);
        CSEdepartment cSE=new CSEdepartment("","","",0);
        System.Console.WriteLine("Setting Book info for EEE Department");
        eEE.SetBookInfo();
        System.Console.WriteLine("Displaying Book info for EEE Department");
        eEE.DisplayInfo();
        System.Console.WriteLine("--------------------------------------------------");

        System.Console.WriteLine("Setting Book info for CSE Department");
        cSE.SetBookInfo();
        System.Console.WriteLine("Displaying Book info for CSE Department");
        cSE.DisplayInfo();
        System.Console.WriteLine("--------------------------------------------------");

    }
}