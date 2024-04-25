using System;

namespace Assignment7
{
    public class Calculator
    {
        public double Subject1 { get; set; }
        public double Subject2 { get; set; }
        public double Subject3 { get; set; }
        public double Subject4 { get; set; }
        public double Subject5 { get; set; }
        public double Subject6 { get; set; }
        public double Total { get; set; }
        public double Percentage { get; set; }
        public Calculator(double subject1,double subject2, double subject3, double subject4,double subject5,double subject6)
        {
            Subject1=subject1;
            Subject2=subject2;
            Subject3=subject3;
            Subject4=subject4;
            Subject5=subject5;
            Subject6=subject6;
        }
        public void Calculate(){
            Total=Subject1+Subject2+Subject3+Subject4+Subject5+Subject6;
            Percentage=Total/6;               
        }
    }
}
