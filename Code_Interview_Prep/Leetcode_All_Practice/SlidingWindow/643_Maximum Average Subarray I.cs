using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_All_Practice.SlidingWindow
{
    /*
   
    You are given an integer array nums consisting of n elements, and an integer k.

    Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.

    Input: nums = [1,12,-5,-6,50,3], k = 4
    Output: 12.75000
    Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75

     */

    internal class _643_Maximum_Average_Subarray_I
    {

        public double FindMaxAverage(int[] nums, int k)
        {
            int windowSum = 0;
            int maxValue = int.MinValue;
            int windowStart = 0;

            // outer loop - act as right pointer 
            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {

                windowSum = windowSum + nums[windowEnd];

                // Slide widnow main operation 
                if (windowEnd - windowStart == k - 1)
                {

                    maxValue = Math.Max(windowSum, maxValue);

                    // 
                    windowSum -= nums[windowStart];
                    windowStart++;

                }


            }
            return maxValue / (double)k;

        }

    }
}
