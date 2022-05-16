using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Math
{
    public class prime_number
    {
        public static int isPrime(int n)
        {
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
                return 1;
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
                return -1;
            }
        }
    }
}