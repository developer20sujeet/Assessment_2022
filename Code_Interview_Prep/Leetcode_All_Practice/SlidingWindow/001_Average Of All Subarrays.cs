using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_All_Practice.SlidingWindow
{
    public class _001_Average_Of_All_Subarrays
    {

        //Input: nums = [1,12,-5,-6,50,3], k = 4
        public double[] FindAllAverage(int[] nums, int k)
        {
            List<double> lst = new();

            double average = double.NegativeInfinity;

            double currentRunningWindow = 0;

            int windowStart = 0;            
            
            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {

                currentRunningWindow += nums[windowEnd];

                if (windowEnd >= k - 1)
                {
                    average =currentRunningWindow/(double)k;

                    lst.Add(average);

                    currentRunningWindow -= nums[windowStart];

                    windowStart++;
                }
            }

           return lst.ToArray();
        }
    }
}
