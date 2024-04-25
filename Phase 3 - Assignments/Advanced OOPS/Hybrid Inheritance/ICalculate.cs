using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid_Inheritance
{
    public interface ICalculate
    {
        double ProjectMark{get;set;}
        void CalculateUGTotal();
        void CalculateUGPercentage();
    }
}