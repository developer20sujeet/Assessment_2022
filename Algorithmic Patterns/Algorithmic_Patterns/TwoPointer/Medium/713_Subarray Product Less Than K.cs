using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Medium
{
    internal class _713_Subarray_Product_Less_Than_K
    {
        /// <summary>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// Algorithm used: Sliding Window
        /// Algorithmic coding pattern: Two Pointers
        /// Data structure used: Array
        /// Company name: Commonly asked in various companies
        /// Important Tips and Tricks: Maintain a running product and adjust window based on its value.
        /// Lessons Learned: Keeping track of the running product allows us to solve the problem in a single pass.
        /// Central Idea: Use two pointers to keep track of a subarray and a running product to check the condition.
        /// </summary>
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            // Step 1: Initialize pointers and variables
            // Reason: To keep track of the subarray and count of subarrays
            int left = 0, count = 0, product = 1;

            // Step 2: Iterate over the array
            // Reason: To explore all subarrays
            for (int right = 0; right < nums.Length; right++)
            {

                // Step 3: Update running product
                // Reason: To include the current element in the subarray
                product *= nums[right]; //if the running product(product) becomes greater than or equal to k, it violates our requirement.so below in while loop you need to adjust and bring it back under k or equal to k


                // Step 4: Adjust the left pointer and product
                // Reason: To maintain subarrays with product less than k
                //         if the running product(product) becomes greater than or equal to k, it violates our requirement.so below in while loop you need to adjust and bring it back under k or equal to k
                // while (product >= k) loop is only meant to adjust the left pointer until we have a valid subarray that includes nums[right]
                while (product >= k && left <= right)
                {
                    product /= nums[left];// remove one array index value from product(multiplication)
                    left++;
                }

                // Step 5: Update the count
                // Reason: All subarrays ending at 'right' are valid, so add their count
                count += right - left + 1;// think when right and left =0 and found one subarray so it will be 0 but technically there is one element so +1
            }

            return count;
        }
    }
}
