using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Programming
{
    //time complexity is O(log(n))
    internal class PalindromeNumber
    {
        /// <summary>
        /// Way 1- First Choice 
        /// //  time complexity is O(log(n))
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            // Special cases:
            // - If the number is negative, it is not a palindrome.
            // - If the number is 0, it is a palindrome.
            // - special cases of negative numbers and numbers that end in 0 (except for 0 itself).
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int reversed = 0;
            while (x > reversed)
            {
                // x % 10 extracts the rightmost digit of x. For example, if x is 123, x % 10 is 3.
                // reversed * 10 shifts all the digits of reversed one place to the left, adding a new rightmost digit with a value of 0. For example, if reversed is 12, reversed * 10 is 120.
                reversed = reversed * 10 + x % 10;
                x /= 10;//used to take all number except last digit 

            }

            // If the original number has an odd number of digits, we can ignore the middle digit by comparing x to reversed / 10.
            // If the original number has an even number of digits, x will equal reversed.
            return x == reversed || x == reversed / 10;
        }

        /// <summary>
        /// Way 2 -  string way 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome_using_String(int x)
        {
            // Convert the integer to a string
            string str = x.ToString();

            // Check if the string is the same when read forwards and backwards
            for (int i = 0; i < str.Length / 2; i++)
            {

                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Way 3 -    # 2 pointer approach - constant space complexity
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome_Left_right_way(int x)
        {
            string xString = x.ToString();
            int left = 0;
            int right = xString.Length - 1;

            while (left < right)
            {
                if (xString[left] != xString[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }


    }
}
