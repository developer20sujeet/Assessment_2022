using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-average-subarray-i/
    /// </summary>
    public class Maximum_Average_Subarray_I
    {
        /// <summary>
        /// https://www.youtube.com/watch?v=XfSgQvKfcys&list=PL7g1jYj15RUOjoeZAJsWjwV8XUo9r0hwc&index=2
        /// Algorithmic Patterns Sliding window algorithm   solving 
        /// Final and follow 
        /// Runtime: 300 ms, faster than 76.88% of C# online submissions for Maximum Average Subarray I.
        /// Memory Usage: 55.3 MB, less than 8.54% of C# online submissions for Maximum Average Subarray I.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double FindMaxAverage_SlidingWindowAlgo(int[] num, int k)
        {
            double windowSum = 0;
            int start = 0;
            // Assigned Value so that we can get negative max if exist 
            double max = int.MinValue;

            for (int end = 0; end < num.Length; end++)
            {
                windowSum += num[end];

                // Give current window size =end - start + 1
                if (end - start + 1 == k)
                {
                    // Find Max 
                    max = Math.Max(max, (double)windowSum / (double)k);

                    // Substract last one index value so that following next index can be added
                    // After below line is will be some of from index 1 to 3 
                    windowSum -= num[start];

                    // to get next slid window 
                    start++;
                }
            }
            return max;

        }

        #region Other way 
        /// <summary>
        /// Runtime: 303 ms, faster than 75.88% of C# online submissions for Maximum Average Subarray I.
        //  Memory Usage: 59.6 MB, less than 5.02% of C# online submissions for Maximum Average Subarray I.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double FindMaxAverage_FromLeetCodeSolved(int[] nums, int k)
        {

            int currSum = nums.Take(k).Sum();
            double max = currSum / (double)k;
            for (int i = k; i < nums.Length; i++)
            {
                currSum -= nums[i - k];
                currSum += nums[i];
                max = Math.Max(max, currSum / (double)k);
            }

            return max;
        }

        /// <summary>
        /// https://www.youtube.com/watch?v=XfSgQvKfcys&list=PL7g1jYj15RUOjoeZAJsWjwV8XUo9r0hwc&index=2
        /// Naive way of doing - it is not good as we have two reiterate same index many times 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static float FindMaxAverage_NaiveWay(int[] nums, int k)
        {
            if (nums.Length <= k)
                return nums[0];

            float max = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                float NonWindowSum = 0;

                for (int j = 0; j < k; j++)
                {
                    // this condition help to exceute array beyond array length
                    if (!((i + (k - 1)) > nums.Length - 1))
                    {
                        NonWindowSum += nums[i + j];
                    }
                    else
                    {
                        // Terminate the loop 
                        i = nums.Length;
                        j = k;
                    }

                }
                if (NonWindowSum != 0)
                {
                    max = Math.Max(max, NonWindowSum / k);
                }
            }

            if (max <= -1)
            {
                return max;
            }


            return max;
        } 
        #endregion

    }
}
