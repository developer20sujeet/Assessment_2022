using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Programming
{
    internal class ContainsDuplicate_Array
    {
        /// <summary>
        /// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool ContainsDuplicate(int[] nums)
        {
            // Sort the array in ascending order
            Array.Sort(nums);

            // Iterate over the array and compare each element with its next element
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    // If the elements are equal, return true
                    return true;
                }
            }

            // If the loop completes without finding a duplicate element, return false
            return false;
        }

    }

}
