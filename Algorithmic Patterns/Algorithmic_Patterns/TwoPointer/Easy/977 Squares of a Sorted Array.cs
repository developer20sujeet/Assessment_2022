using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Easy
{
    public class _977_Squares_of_a_Sorted_Array
    {

        /// <summary>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// Algorithm used: Two Pointer
        /// Algorithmic coding pattern: Two Pointer
        /// Data structure used: Array
        /// Company name: Commonly asked in various companies
        /// Central point :
        ///     1. Clue - your array is sorted in decreasing order so last index is bigger 
        ///     2. so Squered sorted array last index should be bigger as well 
        ///     3. so take a poistion = array.length-1 and start putting the bigger at last and move to left 
        /// </summary>
        public int[] SortedSquares(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[] { };
            }

            // Step 1: Initialize pointers and result array
            int left = 0;
            int right = nums.Length - 1;
            int[] result = new int[nums.Length];
            int position = nums.Length - 1;

            // Step 2: Iterate through the array using two pointers
            while (left <= right)
            {
                // Step 2.1: Compare absolute values
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    // Step 2.1.1: Add square of the left element if it's greater
                    result[position] = nums[left] * nums[left];
                    left++; // Move the left pointer
                }
                else
                {
                    // Step 2.1.2: Add square of the right element if it's greater or equal
                    result[position] = nums[right] * nums[right];
                    right--; // Move the right pointer
                }
                position--; // Decrement the position for the next largest square
            }

            // Step 3: Return the result array
            return result;
        }


    }
}
