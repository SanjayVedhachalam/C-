using System;
using Abstraction_3;
namespace Assignment3;
class Program{
    public static void Main(string[] args)
    {
        MaruthiSwift maruthiSwift=new MaruthiSwift();
        SuzukiCiaz suzukiCiaz=new SuzukiCiaz();

        maruthiSwift.GetEngineType(EngineType.Petrol);
        maruthiSwift.GetNoOfSeats(4);
        maruthiSwift.GetPrice(400000);
        maruthiSwift.GetCarType(CarType.Sedan);
        maruthiSwift.DisplayCarDetails();

        suzukiCiaz.GetEngineType(EngineType.Diesel);
        suzukiCiaz.GetNoOfSeats(6);
        suzukiCiaz.GetPrice(700000);
        suzukiCiaz.GetCarType(CarType.Hatchback);
        suzukiCiaz.DisplayCarDetails();
    }
}