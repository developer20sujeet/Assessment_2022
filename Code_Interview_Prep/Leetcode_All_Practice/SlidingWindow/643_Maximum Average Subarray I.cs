using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_All_Practice.SlidingWindow
{
    internal class _643_Maximum_Average_Subarray_I
    {
        //Input: nums = [1,12,-5,-6,50,3], k = 4
        public double FindMaxAverage(int[] nums, int k)
        {
            double CurrentWindowSum = 0;

            double MaxAverage = double.NegativeInfinity;

            int windowStart = 0;


            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {

                CurrentWindowSum+= nums[windowEnd];

                if(windowEnd >= k-1)
                {
                    // not diving CurrentWindowSum/k intentionally as it increase time complexity 
                    MaxAverage = Math.Max(MaxAverage, CurrentWindowSum);

                    CurrentWindowSum -= nums[windowStart];

                    windowStart++;

                }
            }

            //  diving CurrentWindowSum/k intentionally as it decrease time complexity at last
            return MaxAverage /k;

        }

    }
}
