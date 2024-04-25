using System;

namespace Assignment_2
{
    public class Sphere:Dimension
    {
       public double Radius { get; set; }
       public Sphere(double radius) :base(radius,radius){
        Radius=radius;
       }
        public override void Calculate()
        {
            Area=Math.PI*Radius*Radius;          
        }
        public override double DisplayArea()
        {
            return Area;
        }
    }
}
