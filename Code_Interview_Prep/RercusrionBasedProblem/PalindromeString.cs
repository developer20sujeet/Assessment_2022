using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RercusrionBasedProblem
{
    internal class PalindromeString
    {
        public bool IsPalindrome(string str, int start, int end)
        {
            // Base case: If start index is greater than or equal to end index, return true
            if (start >= end)
            {
                return true;
            }

            // If the characters at start and end indices are not the same, return false
            if (str[start] != str[end])
            {
                return false;
            }

            // Recursive call with updated indices
            return IsPalindrome(str, start + 1, end - 1);
        }

    }
}
