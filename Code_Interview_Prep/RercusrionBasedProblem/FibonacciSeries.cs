using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RercusrionBasedProblem
{
    internal class FibonacciSeries
    {
        public int FibonacciSeriesNumber(int n) {

            if (n <= 1)
            {
                return n;
            }

            // why n-1 and n-2 = because the Fibonacci sequence is defined in terms of the sum of the previous two numbers in the series.
            return FibonacciSeriesNumber(n - 1) + FibonacciSeriesNumber(n - 2);

        }
    }
}
