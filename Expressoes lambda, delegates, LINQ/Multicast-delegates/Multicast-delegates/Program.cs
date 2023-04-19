
using Multicast_delegates.Services;
using System;

delegate void BinaryNumerocOperation(double n1, double n2);

class Program
{
    static void Main(string[] args)
    {
        double a = 10;
        double b = 12;

        BinaryNumerocOperation op = CalculationService.ShowSum;
        op += CalculationService.ShowMax;

        //op.Invoke(a, b);
        op (a,b);
    }
}


