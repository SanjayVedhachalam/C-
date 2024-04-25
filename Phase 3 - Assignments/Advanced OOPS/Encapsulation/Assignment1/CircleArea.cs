using System;
using Mathslib;

namespace CalculatorApp
{
    public class CircleArea : Maths
    {
        protected double radius;
        public double Radius { get{return radius;} set{radius = value;}}
        internal double area{get;set;}

        public CircleArea(double radius) : base(radius)
        {
          Radius=radius;  
        }
        public double CalculatorCircleArea(){
            area=PI*Radius*Radius;
            return area;
        }

    }
}
