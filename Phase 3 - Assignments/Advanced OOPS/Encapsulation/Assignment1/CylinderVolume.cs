using System;

namespace CalculatorApp
{
    public class CylinderVolume : CircleArea
    {
        private double _height;
        public double Height{
            get{
                return _height;
            }
        }
        internal double Volume{get;set;}
        
        public CylinderVolume(double height) : base(height)
        {
            _height=height;
        }
        public double CalculateVolume(){
            Volume=CalculatorCircleArea()*Height;
            return Volume;
        }

    }
}
