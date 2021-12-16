using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Big_Factorial
{
    class FactorialCalculator
    {
        public FactorialCalculator(int n) // with constructor
        {
            N = n;
        }

        public int N { get; set; }

        public BigInteger Calculate()
        {
            BigInteger factorial = 1;
            for (int i = 2; i <= N; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
