using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Easy
{
    internal class _26_Remove_Duplicates_from_Sorted_Array
    {

        public int RemoveDuplicates(int[] nums)
        {

            if (nums == null || nums.Length == 0) return 0;

            int i = 0; // Pointer for keeping track of the last non-duplicate element

            // Iterate through the array with j
            for (int j = 1; j < nums.Length; j++)
            {
                // If the current element (pointed by j) is not equal to the last non-duplicate element (pointed by i)
                /*
                 Inside the loop, the current element (nums[j]) is compared with the last unique element (nums[i]). If they are different, it means a new unique element is found.
                 */
                if (nums[j] != nums[i])
                {
                    i++; // Increment i to move to the next position
                    /*
                    If a unique element is found, increment i and copy the value of the current element to the next position in the array (nums[i]).
                     */
                    nums[i] = nums[j]; // Copy the value of the current element to the next non-duplicate position
                }
            }

            //the function returns the count of unique elements, which is i + 1, since i is a zero-based index.
            return i + 1; // Return the count of unique elements
        }


        public static int removeDuplicates(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    continue;
                }
                else
                {
                    nums[count] = nums[i];
                    count++;
                }
            }

            return count;
        }


    }
}
