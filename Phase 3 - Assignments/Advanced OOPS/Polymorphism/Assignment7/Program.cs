using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
namespace Assignment7;
class Program{
    public static void Main(string[] args)
    {
        Calculator Sem1=new Calculator(82,87,90,80,92,97);
        Calculator Sem2=new Calculator(81,79,100,83,95,92);
        Calculator Sem3=new Calculator(89,84,99,87,92,94);
        Calculator Sem4=new Calculator(81,82,93,70,91,98);
        Sem1.Calculate();
        Sem2.Calculate();
        Sem3.Calculate();
        Sem4.Calculate();
        
    }
    
}
