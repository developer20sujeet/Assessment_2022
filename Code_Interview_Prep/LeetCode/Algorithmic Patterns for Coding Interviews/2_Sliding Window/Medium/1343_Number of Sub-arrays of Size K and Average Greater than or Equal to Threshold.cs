using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-sub-arrays-of-size-k-and-average-greater-than-or-equal-to-threshold/description/
    /// </summary>
    public class _1343_Number_of_Sub_arrays_of_Size_K_and_Average_Greater_than_or_Equal_to_Threshold
    {

        public static int NumOfSubarrays_slidingWindow(int[] arr, int k, int threshold)
        {
            double Average = 0;
            double currentRunningSum = 0;
            int startWindow = 0;
            int count = 0;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {

                currentRunningSum += arr[windowEnd];

                // Step 1 - when array index count is equla to sliding window count or array index count is greater to sliding window countthen check further condition or 
                if (windowEnd >= k - 1)
                {
                    Average = currentRunningSum / k;

                    if (Average >= threshold)
                    {
                        count++;

                    }

                    // remove previous one item value from sum
                    currentRunningSum -= arr[startWindow];

                    // slide forward by 1 
                    startWindow++;

                }

            }

            return count;

        }
    }
}
