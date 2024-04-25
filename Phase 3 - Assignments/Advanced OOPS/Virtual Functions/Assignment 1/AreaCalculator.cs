using System;

namespace Assignment_1
{
    public class AreaCalculator
    {
        public double Radius { get; set; }
        public AreaCalculator(double radius){
            Radius=radius;
        }
        public virtual double Calculate(){
            double Result=Math.PI*Radius*Radius;
            return Result;
        } 
    }
}
