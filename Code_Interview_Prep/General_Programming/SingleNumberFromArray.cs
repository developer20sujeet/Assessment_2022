using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Programming
{
    /// <summary>
    /// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
    /// You must implement a solution with a linear runtime complexity and use only constant extra space.
    /// </summary>
    internal class SingleNumberFromArray
    {
        public int SingleNumber(int[] nums)
        {
            // Sort the array in ascending order
            Array.Sort(nums);

            // Iterate over the array and compare each element with its next element
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    // If the elements are different, return the current element as the single element
                    return nums[i];
                }
            }

            // If the loop completes without returning an element, return the last element of the array
            return nums[nums.Length - 1];
        }

    }
}
