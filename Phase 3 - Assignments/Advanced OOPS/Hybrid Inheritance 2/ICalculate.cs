using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid_Inheritance_2
{
    public interface ICalculate
    {
        double Deposit(double depositAmount);
        double Withdraw(double withdrawAmount);
        double BalanceCheck();
    }
}