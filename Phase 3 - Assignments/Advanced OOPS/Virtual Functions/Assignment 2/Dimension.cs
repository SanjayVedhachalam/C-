using System;

namespace Assignment_2
{
    public class Dimension
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Area { get; set; }
        public Dimension(double value1,double value2){
            Value1=value1;
            Value2=value2;
        
        }
        public virtual void Calculate(){
            Area=Value1*Value2;
        }
        public virtual double DisplayArea(){
            return Area;
        }
    }
}
