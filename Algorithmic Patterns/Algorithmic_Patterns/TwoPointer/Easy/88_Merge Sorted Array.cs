using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Easy
{
    
    internal class _88_Merge_Sorted_Array
    {
        
        /// <summary>
        ///  Central Idea of solution :  
        ///     1. First you know that both array is sorted so both's array max value will be at the last of array index 
        ///     2. and you will have final(resulted array) that would be sorted in ascendeing also so the final result array last index should be the max also - the whole tricks is to understand this 
        ///     3. Now compare both array last index value and whichever is max , put into result array at last index 
        ///  
        /// 
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            //two integers m and n, representing the number of elements in nums1 and nums2
            // stored inside the array nums1.
            //nums1 has a length of m + n,

            int i = m - 1; // Pointer i initialized to the last element of nums1 that has a value (excluding the extra space)
            int j = n - 1; // Pointer j initialized to the last element of nums2
            int k = m + n - 1; // Pointer k initialized to the last position of the merged array nums1 (including extra space)

            // Iterate as long as both i and j pointers are within bounds
            while (i >= 0 && j >= 0)
            {
                // If the current element in nums1 is greater than the current element in nums2
                if (nums1[i] > nums2[j])
                {
                    // Place the greater value at the current position of k in the merged array
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    // Place the greater or equal value from nums2 at the current position of k in the merged array
                    nums1[k--] = nums2[j--];
                }
            }

            // If there are any remaining elements in nums2 after the above loop
            // (this means all elements in nums1 have been considered)
            while (j >= 0)
            {
                // Copy the remaining elements from nums2 to nums1
                nums1[k--] = nums2[j--];
            }

        }
    }
}
