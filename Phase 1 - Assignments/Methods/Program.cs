using System;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
namespace Methods;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter number 1: ");
        int number1=int.Parse(Console.ReadLine());
        System.Console.Write("Enter number 2: ");
        int number2=int.Parse(Console.ReadLine());
        System.Console.Write("Switch for the option selection.\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n Enter here: ");
        int option=int.Parse(Console.ReadLine());
        while(option<0 || option>4){
            System.Console.Write("Invalid input. Type again: ");
            option=int.Parse(Console.ReadLine());
        }
        string str="";
        
        do{
            switch(option){
                case 1:{
                    System.Console.WriteLine($"The addition of {number1} and {number2} is {Add(number1,number2)}");
                    break;
                }
                case 2:{
                    System.Console.WriteLine($"The subtraction of {number1} and {number2} is {Subtract(number1,number2)}");
                    break;
                }
                case 3:{
                    System.Console.WriteLine($"The multiplication of {number1} and {number2} is {Multiply(number1,number2)}");
                    break;
                }
                case 4:{
                    System.Console.WriteLine($"The division of {number1} and {number2} is {Divide(number1,number2)}");
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid input");
                    break;
                }
            }
            System.Console.Write("Do you want to continue?[Yes/No]: ");
            str = Console.ReadLine();
            
            if(str=="Yes"){
                System.Console.Write("Enter number 1: ");
                number1=int.Parse(Console.ReadLine());
                System.Console.Write("Enter number 2: ");
                number2=int.Parse(Console.ReadLine());
                System.Console.Write("Switch for the option selection.\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n Enter here: ");
                option=int.Parse(Console.ReadLine());
                while(option<0 || option>4){
                System.Console.Write("Invalid input. Type again: ");
                option=int.Parse(Console.ReadLine());
        }
            }
            else if(str!="No"){
                System.Console.Write("Invalid option. Enter the right option:[Yes/No] ");
                str=Console.ReadLine();
                option=0;  
            }
        }while(str == "Yes" || str!="No");

        int Add(int number1,int number2){
            return number1+number2;
        }
        int Subtract(int number1,int number2){
            return number1-number2;
        }
        int Multiply(int number1,int number2){
            return number1*number2;
        }
        int Divide(int number1,int number2){
            return number1/number2;
        }
        
    }
}
