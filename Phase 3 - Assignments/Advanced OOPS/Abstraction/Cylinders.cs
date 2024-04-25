using System;

namespace Abstraction
{
    public class Cylinders:Shape
    {
        

        public override double Area { get ; set; }
        public override double Volume { get ; set; }
        public Cylinders(double radius, double height) : base(radius, height)
        {

        }
        public override double CalculateArea(){
            Area=2*Math.PI*Radius*(Radius+Height);
            return Area;
        }
        public override double CalculateVolume(){ 
            Volume=Math.PI*Radius*Radius*Height;
            return Volume;
        }
    }
}
