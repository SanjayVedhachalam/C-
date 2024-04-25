using System;
using Abstraction_4;
namespace Assignment4;
class Program{
    public static void Main(string[] args)
    {
        LadiesWear ladiesWear=new LadiesWear();
        ladiesWear.GetDressInfo(DressType.Ladieswear,"Frock",1200);
        ladiesWear.DisplayInfo();

        MensWear mensWear=new MensWear();
        mensWear.GetDressInfo(DressType.Menswear,"Jeans",900);
        mensWear.DisplayInfo();
    }
}