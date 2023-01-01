using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Programming
{
    internal class FibonacciNumber
    {
        public int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            //In the Fibonacci sequence, each number is the sum of the previous two numbers. Therefore, to calculate the n-th Fibonacci number, we need to know the values of the n - 1-th and n - 2-th Fibonacci numbers.
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
