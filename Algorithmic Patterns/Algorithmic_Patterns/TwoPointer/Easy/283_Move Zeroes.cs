using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Easy
{
    /*
       Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Note that you must do this in-place without making a copy of the array.
        Example 1:

        Input: nums = [0,1,0,3,12]
        Output: [1,3,12,0,0]
        Example 2:

        Input: nums = [0]
        Output: [0] 
     */
    internal class _283_Move_Zeroes
    {
        /// <summary>
        /// Moves all zeros present in the array to the end.
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// Algorithm: Two Pointers
        /// Algorithmic Code Pattern: Pointer Manipulation
        /// Data Structure: Array
        /// Company Name: Frequently asked at companies like Facebook, Amazon, Google, and Microsoft.
        /// Tips Central Idea: 
        ///     loop through array and // If the element is non-zero, it should be moved to the front
        ///     and at last fill up rest of array index using 0 
        ///     Two loop needed - 1. to move all non zero to front , 2. Fill remaining array index with zero
        /// </summary>
        public void MoveZeroes(int[] nums)
        {
            // Initialize a pointer to track the position where the next non-zero element should be placed.
            int position = 0;

            // Iterate through the array to find non-zero elements
            for (int i = 0; i < nums.Length; i++)
            {
                // If the element is non-zero, it should be moved to the front
                if (nums[i] != 0)
                {
                    // Place the non-zero element at the current 'position' index to maintain the relative order of non-zero elements
                    nums[position] = nums[i];

                    // Increment 'position' so that the next non-zero value can be placed at the correct index
                    position++;
                }
            }

            // Fill the remaining positions with zeros, as all non-zero elements have been moved to the front
            while (position < nums.Length)
            {
                // Assign zero to the remaining positions, ensuring that all zeros are moved to the end
                nums[position] = 0;

                // Increment 'position' to move to the next index, as we are filling the rest of the array with zeros
                position++;
            }
        }



    }
}
