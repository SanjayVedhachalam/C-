using System;
namespace Assignment2;
class Program{
    public static void Main(string[] args)
    {
       ShiftDezire shiftDezire1=new ShiftDezire("Petrol",5,"Red",25,350,"Maruthi","Shift Desire - LXI","ENG849284","CHS099932");
       
       shiftDezire1.ShowDetails();
       shiftDezire1.CalculateMileage(shiftDezire1.TankCapacity,shiftDezire1.NumberOfKmDriven);
       System.Console.WriteLine();
       ShiftDezire shiftDezire2=new ShiftDezire("Diesel",6,"Blue",20,300,"Maruthi","Shift Desire - SUV","ENG467294","CHS049988");
       
       shiftDezire2.ShowDetails();
       shiftDezire2.CalculateMileage(shiftDezire2.TankCapacity,shiftDezire2.NumberOfKmDriven);
       System.Console.WriteLine("________________________________________________________________");

       Eco eco1=new Eco("Diesel",4,"Metallic Silver",30,400,"Tata","Indica - Eco","ENG384922","CHS349849");
      
       eco1.ShowDetails();
       eco1.CalculateMileage(eco1.TankCapacity,eco1.NumberOfKmDriven);
       System.Console.WriteLine();
       Eco eco2=new Eco("Petrol",7,"Black",35,600,"Tata","Innova - Eco","ENG438483","CHS922748");
       
       eco2.ShowDetails();
       eco2.CalculateMileage(eco2.TankCapacity,eco2.NumberOfKmDriven);
       System.Console.WriteLine("________________________________________________________________");
    }

}