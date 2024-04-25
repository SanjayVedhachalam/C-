using System;

namespace Assignment_1
{
    public class VolumeCalculator:AreaCalculator
    {
        public double Height { get; set; }
        public VolumeCalculator(double radius,double height):base(radius){
            Height=height;
        }
        public override double Calculate()
        { 
            return Math.Round(base.Calculate()*Height,2);
        }
    }
}
