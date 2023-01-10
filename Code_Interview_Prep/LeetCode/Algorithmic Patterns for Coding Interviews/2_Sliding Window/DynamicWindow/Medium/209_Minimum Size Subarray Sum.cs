using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.DynamicWindow.Medium
{
    //Input: target = 7, nums = [2,3,1,2,4,3]
    //Output: 2
    //Explanation: The subarray[4, 3] has the minimal length under the problem constraint.
    public class _209_Minimum_Size_Subarray_Sum
    {
        /*
         
         1. Question you need to ask is why while loop you need 
           -- The while loop with the condition sum >= s is used to decrease the size of the window 
               until the sum of the elements in the window is less than the target sum s.
           -- purpose of this loop is to find the minimum length subarray with a sum greater than or equal to the target sum.
           -- if loop is less than the target sum, the right side of the window is moved to the right by one element - important to understand 
           -- If the sum becomes greater than or equal to the target sum, the loop starts decreasing the size of the window by moving the left side of the window to the right by one element at a time, 
        
         */
        public int MinSubArrayLen(int s, int[] nums)
        {

            // Edge case: return 0 if the array is empty or if the target sum is 0
            if (nums.Length == 0 || s == 0)
            {
                return 0;
            }

            // Initialize variables
            int minLength = int.MaxValue;
            int sum = 0;
            int left = 0;

            // Slide the window through the array
            for (int right = 0; right < nums.Length; right++)
            {
                // Add the current element to the sum
                sum += nums[right];

                // If the sum is greater than or equal to the target, decrease the window size until the sum is less than the target
                // 
                while (sum >= s)
                {
                    // Update the minimum length if necessary
                    minLength = Math.Min(minLength, right - left + 1);

                    // Subtract the element at the left side of the window from the sum
                    sum -= nums[left];

                    // Move the left side of the window to the right by one element
                    left++;
                }
            }

            // If the minimum length is still the maximum possible value, it means that no subarray with a sum greater than or equal to the target was found, so return 0
            return minLength == int.MaxValue ? 0 : minLength;

        }

        public int MinSubArrayLen_DIfferent_way(int s, int[] nums)
        {
            // Edge case: return 0 if the array is empty or if the target sum is 0
            if (nums.Length == 0 || s == 0)
            {
                return 0;
            }

            // Initialize variables
            int minLength = int.MaxValue;
            int sum = 0;
            int left = 0;
            int right = 0;

            // Slide the window through the array
            while (right < nums.Length)
            {
                // Add the current element to the sum
                sum += nums[right];

                // If the sum is greater than or equal to the target, decrease the window size until the sum is less than the target
                while (sum >= s)
                {
                    // Update the minimum length if necessary
                    minLength = Math.Min(minLength, right - left + 1);

                    // Subtract the element at the left side of the window from the sum
                    sum -= nums[left];

                    // Move the left side of the window to the right by one element
                    left++;
                }

                // Move the right side of the window to the right by one element
                right++;
            }

            // If the minimum length is still the maximum possible value, it means that no subarray with a sum greater than or equal to the target was found, so return 0
            return minLength == int.MaxValue ? 0 : minLength;

        }
    }
}
