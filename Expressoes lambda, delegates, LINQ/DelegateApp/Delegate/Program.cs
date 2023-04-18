using Delegate.Services;
using System;

delegate double BinaryNumerocOperation(double n1, double n2);

class Program
{
    static void Main(string[] args)
    {
        double a = 10;
        double b = 12;

        BinaryNumerocOperation op = CalculationService.Max;
        BinaryNumerocOperation op1 = new BinaryNumerocOperation(CalculationService.Max);
        //double result = CalculationService.Sum(a, b);

        double result = op.Invoke(a, b);
        Console.WriteLine(result);
    }
}

