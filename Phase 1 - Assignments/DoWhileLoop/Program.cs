using System;
namespace DoWhileLoop;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number=int.Parse(Console.ReadLine());
        bool value=true;
        if(number%2==0){
                Console.WriteLine("The entered number is even");
                
        }
        else{
                Console.WriteLine("The entered number is odd");
                
        }
        Console.Write("Enter your opinion for repeating the process:[Yes/No] - ");
        string opinion = Console.ReadLine();
        do{
            if(opinion=="Yes"){
                Console.Write("Enter a another number: ");
                number=int.Parse(Console.ReadLine());
                if(number%2==0){
                Console.WriteLine("The entered number is even");
                Console.Write("Enter your opinion for repeating the process:[Yes/No] - ");
                opinion = Console.ReadLine();
            }
            else{
                Console.WriteLine("The entered number is odd");
                Console.Write("Enter your opinion for repeating the process:[Yes/No] - ");
                opinion = Console.ReadLine();
            }
            }
            else if(opinion=="No"){
                break;
            }
            else{
                Console.Write("Invalid input. Enter a valid input:[Yes/No] - ");
                opinion=Console.ReadLine();
            }
        }while(value);
    }
} 