using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction_3
{
    public class MaruthiSwift : Car
    {
        public override void GetEngineType(EngineType engineType)
        {
            EngineType=engineType;
        }

        public override void GetNoOfSeats(int noOfSeats)
        {
            NoOfSeats=noOfSeats;
        }

        public override void GetPrice(double price)
        {
            Price=price;
        }
        public override void GetCarType(CarType carType)
        {
            CarType=carType;
        }
        public override void DisplayCarDetails()
        {
            System.Console.WriteLine($"Car Name       : MaruthiSwift");
            System.Console.WriteLine($"Engine type    : {EngineType}");
            System.Console.WriteLine($"Number of Seats: {NoOfSeats}");
            System.Console.WriteLine($"Price          : {Price}");
            System.Console.WriteLine($"Car type       : {CarType}");
            ShowWheels();
            ShowDoors();
            System.Console.WriteLine("______________________________________________________");
            
        }
    }
}