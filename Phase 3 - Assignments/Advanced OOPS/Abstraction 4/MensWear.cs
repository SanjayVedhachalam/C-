using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction_4
{
    public class MensWear:Dress
    {
        public override DressType DressType { get; set; }
        public override string DressName { get; set; }
        public override double Price { get; set; }
        public override double TotalPrice { get; set; }

        public override void DisplayInfo(){
            System.Console.WriteLine("Dress Details");
            System.Console.WriteLine($"Dress Type : {DressType}");
            System.Console.WriteLine($"Dress Name : {DressName}");
            System.Console.WriteLine($"Price      : {Price}");
            System.Console.WriteLine($"Total Price: {TotalPrice}");
            System.Console.WriteLine("----------------------------------------");
        }

        public override void GetDressInfo(DressType dressType,string dressName,double price)
        {
            DressType=dressType;
            DressName=dressName;
            Price=price;
            TotalPrice=Price-(Price*0.3);
        }
    }
}