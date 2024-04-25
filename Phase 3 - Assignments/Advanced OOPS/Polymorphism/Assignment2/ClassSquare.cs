using System;

namespace Assignment2
{
    public class ClassSquare
    {
        public void Square(int number){
            int Answer=number*number;
            System.Console.WriteLine($"Compute square of given integer {number} is {Answer}");
        }
        public void Square(float number){
            float Answer=number*number;
            System.Console.WriteLine($"Compute square of given float {number} is {Answer}");
        }
        public void Square(double number){
            double Answer=number*number;
            System.Console.WriteLine($"Compute square of given double {number} is {Answer}");
        }
        public void Square(long number){
            long Answer=number*number;
            System.Console.WriteLine($"Compute square of given long {number} is {Answer}");
        }
    }
}
