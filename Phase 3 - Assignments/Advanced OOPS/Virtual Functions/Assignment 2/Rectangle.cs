using System;

namespace Assignment_2
{
    public class Rectangle:Dimension
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public Rectangle(double length,double height):base(length,height){
            Length=length;
            Height=height;
        }
        public override void Calculate()
        {
            base.Calculate();
        }
        public override double DisplayArea()
        {
            return Area;
        }
    }
}
