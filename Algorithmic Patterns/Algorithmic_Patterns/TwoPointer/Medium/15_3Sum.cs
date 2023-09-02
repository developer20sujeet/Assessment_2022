﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Medium
{
    internal class _15_3Sum
    {
        /// <summary>
        /// Time complexity: O(n^2)
        /// Space complexity: O(n) for the output list
        /// Algorithm used: Two Pointer with a fixed element
        /// Algorithmic coding pattern: Two Pointer
        /// Data structure used: List of Lists
        /// Company name: Commonly asked in various companies like Amazon, Google, Facebook
        /// Important Tips and Tricks: Always sort the array first, to make the two-pointer approach efficient
        /// Lessons Learned: 
        ///     1. Sorting is a common preparatory step for two-pointer algorithms.
        ///     2. Central Idea: Fix one element and then apply the two-pointer technique for the remaining elements.
        ///     3. Always consider and include edge cases in your solution.
        /// </summary>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            // Step 1: Edge case check and sort the array.
            // Reason: A sorted array helps us use the two-pointer technique effectively.
            IList<IList<int>> result = new List<IList<int>>();

            if (nums == null || nums.Length < 3) 
                return result;

            Array.Sort(nums);

            // Step 2: Loop through the sorted array and fix the first element for each triplet.
            for (int i = 0; i < nums.Length - 2; i++)
            {

                // Step 2.1: Skip duplicates to ensure unique triplets.
                if (i > 0 && nums[i] == nums[i - 1]) 
                    continue;

                // Step 2.2: Initialize two pointers, one at i+1 and the other at the end of the array.
                int left = i + 1, right = nums.Length - 1;

                // Step 2.3: Loop through with the two pointers to find triplets.
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    // Step 2.4: Check if the sum of the triplet is zero, and adjust pointers accordingly.
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        // Step 2.5: Skip duplicates for the second and third elements of the triplet.
                        // // Skip duplicate elements for j
                        while (left < right && nums[left] == nums[left + 1]) left++;

                        // // Skip duplicate elements for k
                        while (left < right && nums[right] == nums[right - 1]) right--;


                        // Move the pointer
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return result;
        }


    }
}