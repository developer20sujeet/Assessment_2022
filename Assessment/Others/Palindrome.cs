using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Others
{
    public class Palindrome
    {
        public static bool IsPalindrome_m1(int x)
        {
            // Special cases:
            // As discussed above, when x < 0, x is not a palindrome.
            // Also if the last digit of the number is 0, in order to be a palindrome,
            // the first digit of the number also needs to be 0.
            // Only 0 satisfy this property.
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
            // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
            // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.
            return x == revertedNumber || x == revertedNumber / 10;
        }

        public static bool IsPalindrome_m2(int num1)
        {
            string s1 = num1.ToString();

            char[] arr = num1.ToString().ToCharArray();
            System.Array.Reverse(arr);

            string s2 = string.Join("", arr);

            return s1 == s2;

        }

        // Top 1
        public static bool IsPalindrome_m3(int num1)
        {           
            int reminder = 0;
            int result = 0;
            int temmp = num1;

            while (num1 !=0)
            {
                reminder = num1 % 10;
                result = result * 10 + reminder;
                num1 = num1 / 10;
            }

            return temmp == result;

        }
    }
}
