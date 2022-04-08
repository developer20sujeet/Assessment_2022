using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.factorial
{
    //https://practice.geeksforgeeks.org/problems/trailing-zeroes-in-factorial5134/1
    //For an integer N find the number of trailing zeroes in N!.
    public class factorial
    {
        public static void driver()
        {
            M2();
        }
        public static void M1()
        {
            //int i, f = 1, num = 4;

            //for (i = 1; i <= num; i++)
            //    f = f * i;

            int num = 5;
            for (int i = num - 1; i > 0; i--)
                num = num * i;

            //Console.Write("The Factorial of {0} is: {1}\n", num, num);
        }
        public static void M2()
        {
            int sum = 0, num = 4;

           
            for (int i = 1; i < num; i++)
            {
                sum = sum + (num * i);
              
            }

            Console.Write("The Factorial is -"+ sum );
        }
    }
}
