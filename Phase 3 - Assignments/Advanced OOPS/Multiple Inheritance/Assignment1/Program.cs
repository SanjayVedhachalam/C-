using System;
namespace Assignment1;
class Program{
    public static void Main(string[] args)
    {
        RegisterPerson person1=new RegisterPerson("Sanjay","Vedha","Sharmila",new DateTime(2001,12,21),"765432345",MartialDetails.Single,"No:5/162A, Alapakkam",1,DateTime.Today);
        RegisterPerson person2=new RegisterPerson("Ram","Dhuriyo","Seetha",new DateTime(1999,01,17),"234567765",MartialDetails.Married,"No:3/10B, Kodambakkam",3,DateTime.Today);
        person1.ShowInfo();
        System.Console.WriteLine("----------------------------------------------------------------");
        person2.ShowInfo();
    }
}