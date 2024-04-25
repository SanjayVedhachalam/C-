using System;
using Hybrid_Inheritance;
namespace HybridInheritance;
class Program
{
    public static void Main(string[] args)
    {
        double[] Sem1Marks1 = new double[]{80, 82, 89, 90, 78, 90};
        double[] Sem2Marks1 = new double[]{89, 82, 84, 79, 90, 91};
        double[] Sem3Marks1 = new double[]{83, 89, 76, 94, 92, 97};
        double[] Sem4Marks1 = new double[]{89, 86, 85, 92, 96, 99};
        Marksheet marksheet1 = new Marksheet(Sem1Marks1,Sem2Marks1 ,Sem3Marks1 ,Sem4Marks1 ,96, "Sanjay", "Vedha", "7654345",new DateTime(2001,12,21),"Male");
        marksheet1.CalculateUGTotal();
        marksheet1.CalculateUGPercentage();
        marksheet1.SHowUGMarkSHeet();

        double[] Sem1Marks2 = new double[]{77, 78, 79, 90, 88, 63};
        double[] Sem2Marks2 = new double[]{84, 90, 72, 77, 67, 93};
        double[] Sem3Marks2 = new double[]{81, 69, 90, 78, 98, 87};
        double[] Sem4Marks2 = new double[]{93, 70, 82, 90, 88, 89};
        Marksheet marksheet2 = new Marksheet(Sem1Marks2,Sem2Marks2 ,Sem3Marks2 ,Sem4Marks2 ,96, "Appi", "Vedha", "987433",new DateTime(2006,09,28),"Male");
        marksheet2.CalculateUGTotal();
        marksheet2.CalculateUGPercentage();
        marksheet2.SHowUGMarkSHeet();
    }
}