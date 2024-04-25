using System;
using System.Net.NetworkInformation;

namespace Mathslib
{
    public class Maths
    {
        protected internal double PI = 3.14;
        internal double g = 9.8;
        public double Weight { get; set; }

        public Maths(double weight)
        {
            Weight = weight;
        }
        public double CalculateWeight()
        {
            return Weight*g;
        }

    }
}
