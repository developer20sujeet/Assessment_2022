using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Easy
{
    internal class _344_Reverse_String
    {

        public void ReverseString(char[] s)
        {
            int leftPointer = 0;

            int rightPointer = s.Length - 1;

            while (leftPointer < rightPointer)
            {
                char c = s[leftPointer];

                s[leftPointer] = s[rightPointer];
                s[rightPointer] = c;

                leftPointer++;
                rightPointer--;

            }

        }
    }
}
