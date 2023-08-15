using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Easy
{
    internal class _125_Valid_Palindrome
    {
        //"madam" (Reads the same forward and backward)
        public bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                // Ignore non-alphanumeric characters
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++; // tips and main advance left the pointer 
                    continue;
                }

                // Ignore non-alphanumeric characters
                if (!char.IsLetterOrDigit(s[right]))
                {
                    right--; // tips and main advance left the pointer 
                    continue;
                }


                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;

                left++;
                right--;
            }

            return true;

        }
    }
}
