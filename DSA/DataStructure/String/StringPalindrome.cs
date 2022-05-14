using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.DataStructure.String
{
    public class StringPalindrome
    {
        #region string palindrome

        //https://www.interviewbit.com/c-sharp-interview-questions/#reverse-a-string-in-csharp
        public static void chkPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");

        }
        #endregion
    }
}
