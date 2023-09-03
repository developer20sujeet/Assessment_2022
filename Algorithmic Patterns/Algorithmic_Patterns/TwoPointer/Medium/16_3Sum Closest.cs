using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Medium
{
    internal class _16_3Sum_Closest
    {

        /// <summary>
        /// Time Complexity: O(n^2)
        /// Space Complexity: O(1)
        /// Algorithm Used: Two Pointers after Sorting
        /// Algorithmic Coding Pattern: Two Pointers
        /// Data Structure Used: Array
        /// Company Where This Problem Was Asked: Frequently asked in various companies
        /// Important Tips and Tricks: Always sort the array before using two pointers
        /// Lessons Learned: When to move left and right pointers based on the target
        /// Central Idea: Sort the array, fix one number, then use two pointers to find the closest sum
        /// </summary>
        public int ThreeSumClosest(int[] nums, int target)
        {
            // Step 1: Initialize the result variable with a base sum
            // Reason: To have a starting point for the closest sum to the target
            int result = nums[0] + nums[1] + nums[nums.Length - 1];

            // Step 2: Sort the array
            // Reason: Sorting allows the use of two pointers to optimize the search
            Array.Sort(nums);

            // Step 3: Iterate through the array
            // Reason: The loop iterates through each element to find a triplet that is closest to the target
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int j = i + 1, k = nums.Length - 1;

                // Step 4: Use two pointers technique
                // Reason: Two pointers help to find the closest sum by comparing and adjusting the positions
                // Reason: To find the closest triplet sum for each 'i'
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];

                    // Step 5: If sum matches target, return the target
                    // Reason: If the sum is equal to the target, then it's the closest possible sum
                    if (sum == target)
                    {
                        return target;
                    }

                    // Step 6: Update the closest sum
                    // Update result if the absolute difference is smaller
                    // Reason: We update the result if we find a sum closer to the target -The goal is to minimize this difference
                    //         Math.Abs(sum - target) - Essentially, it calculates how close the current sum is to the target.
                    //         Math.Abs(result - target) -  It represents the closest sum we have found up to this point.
                    // We took result as base to compare with sum later on - two compare closet we  need two number like - target 10 , num1 13 , numb2 16. so 10 is closeset to number 10 so result here acting like another number to help to compare with sum
                    if (Math.Abs(sum - target) < Math.Abs(result - target))
                    {
                        result = sum;
                    }

                    // Step 7: Move pointers
                    // Reason: Adjust the pointers based on whether the sum is less or more than the target
                    if (sum < target)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }

                    
                }
            }
            return result;
        }


    }
}
