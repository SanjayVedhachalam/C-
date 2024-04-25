using System;
namespace SwitchCase;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter number 1: ");
        double number1=double.Parse(Console.ReadLine());
        Console.Write("enter number 2: ");
        double number2=double.Parse(Console.ReadLine());
        Console.Write("Enter the action top be performed: ");
        char user=char.Parse(Console.ReadLine());
        switch (user)
        {
            case '+':
            {
                Console.WriteLine($"Addition of the numbers is: {number1+number2}");
                break;

            }
            case '-':
            {
                Console.WriteLine($"Subtraction of the numbers is: {number1-number2}");
                break;
            }
            case '*':
            {
                Console.WriteLine($"The Multiplication of the numbers is: {number1*number2}");
                break;
            }
            case '/':
            {
                Console.WriteLine($"The Divison of the numbers are: {number1/number2}");
                break;
            }   
            case '%':
            {
                Console.WriteLine($"The Remainder of the numbers is: {number1%number2}");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Input");
                break;
            }
        }
    }
}
