using System;
using Calculation;

namespace ApplicationCalculationDllTest
{
    class Program
    {
        static void Main(string[] args)
        {
            calculate c = new calculate();
            int sum = c.Add(10, 5);
            Console.WriteLine(sum);
            Console.WriteLine("Hello World!");
        }
    }
}
