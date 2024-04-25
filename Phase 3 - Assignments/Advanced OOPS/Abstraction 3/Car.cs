using System;
using System.Reflection;

namespace Abstraction_3
{
    public enum EngineType{Select, Petrol,Diesel,CNG}
    public enum CarType{Select,Sedan,Hatchback,SUV}
    public abstract class Car
    {
        protected int NoOfWheels=4;
        public int noOfWheels{
            get{
                return NoOfWheels;
            }
        }
        protected int NoOfDoors=4;
        public int noOfDoors{
            get{
                return NoOfDoors;
            }
        }
        public EngineType EngineType{get;set;}
        public CarType CarType { get; set; }
        public int NoOfSeats{get;set;}
        public double Price { get; set; }
        public void ShowWheels(){
            System.Console.WriteLine("Number of Wheels: "+noOfWheels);
        }
        public void ShowDoors(){
            System.Console.WriteLine("Number of Doors : {0}",noOfDoors);
        }
        public abstract void GetEngineType(EngineType engineType);
        public abstract void GetNoOfSeats(int noOfSeats);
        public abstract void GetPrice(double price);
        public abstract void GetCarType(CarType carType);
        public abstract void DisplayCarDetails();

    }
}
