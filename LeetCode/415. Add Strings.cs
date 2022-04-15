using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/add-strings/
    /// Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.
    /// You must solve the problem without using any built-in library for handling large integers(such as BigInteger). 
    /// You must also not convert the inputs to integers directly.
    /// Input: num1 = "11", num2 = "123" | Output: "134"
    /// Charles swab
    /// </summary>
    public class Add_Strings
    {
        public static string AddStrings_v3_myself(string num1, string num2)
        {
            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else if (num2.Length > num1.Length)
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }

            String result = "";  int carry = 0;

            for (int i = num1.Length - 1; i >= 0;  i--)
            {
                int c1 = 0;
                int c2 = 0;

                c1 = num1[i] - '0';// '0' check ACII calnder 
                c2 = num2[i] - '0';

                int sum = c1 + c2 + carry;
                // Take first digit from last of number 
                int digit = sum % 10;
                // take all number from left except one number from right 
                carry = sum / 10;
                result = digit + result;
            }
            // if there is carry add it at first 
            if (carry != 0)
            {
                result = carry + result;
            }

            return result;

        }

        public static string AddStrings_v2(string num1, string num2)
        {
            char[] num11 = num1.ToCharArray();
            char[] num22 = num2.ToCharArray();

            // reversed because it can simply start adding from 0 postion - that is last digit 
            Array.Reverse(num11);
            Array.Reverse(num22);

            num1 = string.Join("", num11); ;
            num2 = string.Join("", num22); ;

            String result = "";
            int carry = 0;
            for (int i = 0; i < num1.Length || i < num2.Length; i++)
            {
                int c1 = 0;
                int c2 = 0;
                if (i < num1.Length)
                {
                    c1 = num1[i] - '0';
                }
                if (i < num2.Length)
                {
                    c2 = num2[i] - '0';
                }

                int sum = c1 + c2 + carry;
                // Take last first digit 
                int digit = sum % 10;

                // take all number from left except one number from right 
                carry = sum / 10;
                result = digit + result;
            }
            // if there is carry add it at first 
            if (carry != 0)
            {
                result = carry + result;
            }

            return result;

        }
        
        // Bad practice - just here to see where was my rank
        public static string AddStrings_v2_myself(string num1, string num2)
        {
            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else if (num2.Length > num1.Length)
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }

            string result = "";
            int previousVal = 0;

            if (num1.Length == num2.Length)
            {
                return (Convert.ToInt32(num1) + Convert.ToInt32(num2)).ToString();
            }
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int temp = (Convert.ToInt32(num1[i].ToString()) + Convert.ToInt32(num2[i].ToString()));

                if (temp.ToString().Length > 1)
                {
                    int t1 = temp % 10;

                    result = (previousVal + t1).ToString() + result;

                    previousVal = Convert.ToInt32(temp.ToString()[0].ToString());
                }
                else
                {
                    result = (temp + previousVal) + result;
                }

            }

            return result.ToString();


        }
    }
}
