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
        
        public static double FindMaxAverage_Educative(int[] nums , int k)
        {
            // Store running window sum
            double  WindowSum = 0;  

            // Keep MAx value - assigned negative value to stop any negative add/sum 
            double MaxSum = double.NegativeInfinity;

            // It help to slid the window by one 
            int Windowstart = 0;

            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {
                // Add next element 
                WindowSum+= nums[windowEnd];

                // K1-1 - Array is 0 index based that's why k-1 as array -0,1,2,3 is total 4 element 
                // windowEnd > k-1 - this is because I need to take all element of array
                // windowEnd = k-1 - this is because Window size k equal to array element index number then we need to find max 
                // Step 1
                if (windowEnd >=k-1)
                {
                    // Need max so that we can store in variable to find max
                    // WindowSum/(double)k - this operation increase time complexity 
                        //MaxSum = Math.Max(MaxSum, WindowSum/(double)k);

                    // just take max and find average at last 
                    MaxSum = Math.Max(MaxSum, WindowSum);

                    // This is main feature of sliding window - in total sum we will slide by 1 forward and add and remove last 1 element value 
                    // Slide one forward - remove one from backword
                    // Step 2
                    WindowSum -= nums[Windowstart];

                    // help to slid and remove from backword in next iteration
                    // Step 3
                    Windowstart++;
                }

            }

            // dividing by k at last so that decrease time complexity 
            return MaxSum/k;

        }


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
                // Think of very first index and window size of 0
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


