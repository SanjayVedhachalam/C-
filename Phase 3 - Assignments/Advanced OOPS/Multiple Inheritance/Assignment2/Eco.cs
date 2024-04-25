using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Eco:Car,IBrand
    {
        private static int s_makingID=2000;
        public string MakingID { get; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }
        public string BrandName { get ; set ; }
        public string ModelName { get ; set ; }
        public Eco(string fuelType,int numberOfSeats,string color,double tankCapacity,double numberOfKmDriven,string brandName,string modelName,string engineNumber,string chasisNumber){
            ++s_makingID;
            MakingID="ECO-MID"+s_makingID;
            FuelType=fuelType;
            NumberOfSeats=numberOfSeats;
            Color=color;
            TankCapacity=tankCapacity;
            NumberOfKmDriven=numberOfKmDriven;
            BrandName=brandName;
            ModelName=modelName;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("Eco Details");
            System.Console.WriteLine($"Making ID          : {MakingID}");
            System.Console.WriteLine($"Fuel Type          : {FuelType}");
            System.Console.WriteLine($"Number of Seats    : {NumberOfSeats}");
            System.Console.WriteLine($"Color              : {Color}");
            System.Console.WriteLine($"Tank Capacity      : {TankCapacity}");
            System.Console.WriteLine($"Number of KM Driven: {NumberOfKmDriven}");
            System.Console.WriteLine($"Brand Name         : {BrandName}");
            System.Console.WriteLine($"Model Name         : {ModelName}");
            System.Console.WriteLine($"Engine Number      : {EngineNumber}");
            System.Console.WriteLine($"Chasis Number      : {ChasisNumber}");
        }
    }
}