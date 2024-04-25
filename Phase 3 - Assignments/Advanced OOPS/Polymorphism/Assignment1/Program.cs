using System;
namespace Assignment1;
class Program{
    public static void Main(string[] args)
    {
        ClassMultiply multiply=new ClassMultiply();
        multiply.Multiply(10);
        multiply.Multiply(2,3);
        multiply.Multiply(4,5,6);
        multiply.Multiply(2,8.23);
        multiply.Multiply(3,4.3234,7.56f);
    }
}