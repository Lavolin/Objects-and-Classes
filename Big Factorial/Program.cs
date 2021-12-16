using System;
using System.Numerics;

namespace Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FactorialCalculator calculator = new FactorialCalculator(n);

            Console.WriteLine(calculator.Calculate());
        }
    }


}
