using System;
namespace WhileLoop;
class Program{
    public static void Main(string[] args)
    {
        int number=0;
        while(number<25){
            if(number%2==0){
                Console.WriteLine($"The even numbers are: {number}");
            }
            number++;
        }
        Console.Write("Enter a valid number: ");
        int validNumber=0;
        bool condition=int.TryParse(Console.ReadLine(),out validNumber);
        while(true){
            
            if(condition){
                Console.WriteLine($"The entered numbers is: {validNumber}");
                break;
            }
            else{
                Console.Write("Invalid input format. Please enter the input in number format.  ");
                condition=int.TryParse(Console.ReadLine(),out validNumber);
            }
        }
    }
}