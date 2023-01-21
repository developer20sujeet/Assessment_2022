using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.DynamicWindow.Medium
{
    public class _1004_Max_Consecutive_Ones_III
    {
        /*
         
        Given a binary array nums and an integer k, return the maximum number of consecutive 1's in the array if you can flip at most k 0's.
        
        Example 1:

        Input: nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
        Output: 6
        Explanation: [1,1,1,0,0,1,1,1,1,1,1]
        Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.
     
        Initialize two variables, left and right, to keep track of the current window of 1s.
        Initialize a variable, zeroCount, to keep track of the number of zeroes in the current window.
        Initialize a variable, maxLength, to store the maximum length of consecutive 1s that can be obtained with at most k flips.
        Iterate through the array, updating the left and right pointers as you go:
            If the current element is 1, move the right pointer to the right
            If the current element is 0:
                If the zeroCount is less than or equal to k, move the right pointer to the right and increment zeroCount
                If the zeroCount is greater than k, move the left pointer to the right until zeroCount is less than or equal to k.
        At each step, update maxLength with the maximum of the current window length and maxLength.
        Return maxLength.
        
         */
        public int longestOnes(int[] nums, int k)
        {
            if (k == nums.Length)
            {
                return k;
            }

            // Act as left pointer 
            int windowStart = 0;

            // Result to keep
            int longest = 0;

            //  to keep track of the number of zeroes in the current window - Max we can keep 2 
            int zeroes = 0;

            // Outer for Loop - Right pointer 
            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {
                // We need increase zeroes counter so that we can check total zeroes allowed 
                if (nums[windowEnd] == 0)
                {
                    zeroes++;
                }

                // Inner While loop help to slide left pointer 
                // If the zeroCount is greater than k, move the left pointer to the right until zeroCount is less than or equal to k.
                while (zeroes > k)
                {
                    if (nums[windowStart] == 0)
                    {
                        zeroes--;
                    }
                    windowStart++;
                }

                // Give max window of consecutive 1's  
                //windowEnd - windowStart + 1 >>  array is 0 indexed so even at index 0 we have count of 1 now think Left and right pointer pointing index 0 of array
                //so right - left +1 still give value of 1 
                longest = Math.Max(longest, windowEnd - windowStart + 1);
            }

            return longest;
        }


    }
}
