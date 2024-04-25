using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Car
    {
        public string FuelType { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public double TankCapacity { get; set; }
        public double NumberOfKmDriven{ get; set; }
        public void CalculateMileage(double tankCapacity,double numberOfKmDriven){
            double mileage=numberOfKmDriven/tankCapacity;
            System.Console.WriteLine("The Mileage of the car is "+double.Round(mileage,2));
        }
    }
}