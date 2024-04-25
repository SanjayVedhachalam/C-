using System;
namespace Assignment2
{
    class Program{
        public static void Main(string[] args)
        {
            ClassSquare square=new ClassSquare();
            square.Square(5);
            square.Square(3.450f);
            square.Square(5.6666666);
            square.Square(45671L);
        }
    }
}