using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Integer
{
    public class ClsInteger
    {

        public void IsEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
           }
        }

        public static bool FindPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)System.Math.Floor(System.Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
