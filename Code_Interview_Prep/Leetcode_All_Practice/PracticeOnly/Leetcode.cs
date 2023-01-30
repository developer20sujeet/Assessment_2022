using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_All_Practice.PracticeOnly
{
    internal class Leetcode
    {

        public int LongestOnes(int[] nums, int k)
        {
            int MaxWindow = 0;
            int windowStart = 0;
            int ZeroAllowedCounter = 0;

            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {

                if (nums[windowEnd] == 0)
                {

                    ZeroAllowedCounter++;
                }

                //used to "contract" the window
                while (ZeroAllowedCounter > k)
                {

                    if (nums[windowStart] == 0)
                    {
                        ZeroAllowedCounter--;

                    }
                    windowStart++;

                }

                // if zero is within limit and allowed keep taking max window 
                MaxWindow = Math.Max(MaxWindow, windowEnd - windowStart + 1);


            }


            return MaxWindow;


        }


    }
}
