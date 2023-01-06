using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.Template.Fixed_Sliding_Window
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-average-subarray-i/
    /// </summary>
    internal class Array_SlidingWindowTemplate
    {

        // Sliding Window Template - Array 
        public static double SlidingWindowTemplate(int[] nums, int k)
        {
            // Store running window sum
            double WindowSum = 0;

            // Keep max negative value - assigned negative value to stop 
            double MaxSum = double.NegativeInfinity;

            // It help to slid the window by one lagter in the programe
            int Windowstart = 0;

            // We need to navigate through all index of array 
            // It is outer loop of sliding window 

            // Step 1
            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {
                // Add value to current window from array  
                WindowSum += nums[windowEnd];


                // We need a condition to check if current winodw navigation is equal to K-1(window size) if so we need to slid window forward by one 
                // if k=4 then why K-1 - Array is 0 index based that's why k-1 as array -0,1,2,3 is total 4 element 
                // windowEnd > k-1 - this is because I need to navigate all element of array
                // windowEnd = k-1 - this is because Window size k equal to navigated array element index number then we need to find max/or apply required logic

                // Step 2
                if (windowEnd >= k - 1)
                {
                    // Need max so that we can store in variable to find max
                    MaxSum = Math.Max(MaxSum, WindowSum / (double)k);


                    // This is main feature of sliding window -
                    // Before sliding the window forward by one , we need to remove very last index value from total sum
                    // Slide one forward - remove one from backword
                    
                    // Step 3
                    WindowSum -= nums[Windowstart];


                    // Slide window  forward by one- this help to remove current window last index value from max sum in next iteration
                   
                    // Step 4
                    Windowstart++;
                }

            }

            return MaxSum;

        }

    }
}
