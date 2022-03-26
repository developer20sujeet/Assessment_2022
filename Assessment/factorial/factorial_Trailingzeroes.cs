using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.factorial
{
    //https://practice.geeksforgeeks.org/problems/trailing-zeroes-in-factorial5134/1
    //For an integer N find the number of trailing zeroes in N!.
    public class factorial_Trailingzeroes
    {
        public static void Main1()
        {
            int i, f = 1, num;

            Console.Write("\n\n");
            Console.Write("Calculate the factorial of a given number:\n");
            Console.Write("--------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;

            Console.Write("The Factorial of {0} is: {1}\n", num, f);
        }
    }
}
