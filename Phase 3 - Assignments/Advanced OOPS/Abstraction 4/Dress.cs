using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction_4
{
    public enum DressType{Select,Ladieswear,Menswear,Childrenswear}
    public abstract class Dress
    {
        public abstract DressType DressType { get; set; }
        public abstract string DressName { get; set; }
        public abstract double Price { get; set; }
        public abstract double TotalPrice { get; set; }
        public abstract void GetDressInfo(DressType dressType,string dressName,double price);
        public abstract void DisplayInfo();
    }
}