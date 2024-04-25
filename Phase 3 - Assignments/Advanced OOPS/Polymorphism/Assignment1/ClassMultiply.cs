using System;

namespace Assignment1
{
    public class ClassMultiply
    {
        public void Multiply(int number1){
            int Answer=number1*number1;
            System.Console.WriteLine($"The Square value of the number Method with one argument {number1} is {Answer}");
            System.Console.WriteLine();
        }
        public void Multiply(int number1,int number2){
            int Answer=number1*number2;
            System.Console.WriteLine($"The Multiplication of Method with 2 arguments with same argument type {number1} and {number2} is {Answer}");
            System.Console.WriteLine();
        }
        
        public void Multiply(int number1,int number2,int number3){
            int Answer=number1*number2*number3;
            System.Console.WriteLine($"The Multiplication Method with 3 arguments with same argument type of {number1}, {number2} and {number3} is {Answer}");
            System.Console.WriteLine();
        }
        
        public void Multiply(int number1,double number2){
            double Answer=number1*number2;
            System.Console.WriteLine($"The Multiplication of Method with 2 arguments with different argument type {number1} and {number2} is {Answer}");
            System.Console.WriteLine();
        }
        
        public void Multiply(int number1,double number2,float number3){
            double Answer=number1*number2*number3;
            System.Console.WriteLine($"The Multiplication of Method with 3 arguments with different argument type {number1}, {number2} and {number3} is {Answer}");
            System.Console.WriteLine();
        }
    }
}
