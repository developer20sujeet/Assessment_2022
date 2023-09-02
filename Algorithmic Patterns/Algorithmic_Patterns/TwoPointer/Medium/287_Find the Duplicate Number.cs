using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Medium
{
    //https://www.youtube.com/watch?v=PvrxZaH_eZ4
    internal class _287_Find_the_Duplicate_Number
    {
        /// <summary>
        /// Find the Duplicate Number using Two Pointer Technique
        /// Time Complexity: O(n log n) due to sorting
        /// Space Complexity: O(1) if we are allowed to sort the original array, otherwise O(n)
        /// Algorithm Used: Two Pointers
        /// Algorithmic Code Pattern: Two Pointers
        /// Data Structure Used: Array
        /// Company: Commonly asked in companies like Google, Microsoft, Amazon
        /// Tips and Tricks: Sorting simplifies the problem but may not be allowed in all cases.
        /// Lessons Learned: Understand the trade-offs between time and space complexity.
        /// </summary>
        /// <param name="nums">The input array</param>
        /// <returns>The duplicate number</returns>
        public static int FindDuplicate_bySortingWay(int[] nums)
        {
            // Step 1: Sort the array
            Array.Sort(nums);

            // Step 2: Initialize two pointers
            int left = 0, right = 1;

            // Step 3: Scan the array with two pointers to find the duplicate
            while (right < nums.Length)
            {
                if (nums[left] == nums[right])
                {
                    return nums[left];
                }

                left++;
                right++;
            }

            return -1; // Should not reach here as per problem constraint
        }


        /// <summary>
        /// Uses Floyd's Tortoise and Hare (Cycle Detection) algorithm to find the duplicate number in an array.
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// Algorithm used: Floyd's Tortoise and Hare algorithm
        /// Algorithmic code pattern used: Two Pointers
        /// Data structure used: Array
        /// Lessons Learned: Always consider edge cases and use efficient algorithms for cycle detection.
        /// </summary>
        /// <param name="nums">The input array</param>
        /// <returns>The duplicate number</returns>
        public int FindDuplicate(int[] nums)
        {
            // Step 1: Initialize slow and fast pointers to the first element (index 0)
            int slow = 0, fast = 0;


            // Step 2: run while loop to know if cycle exist 
            while (true)
            {

                // Step 3: Move the slow pointer one step
                slow = nums[slow];


                // Step 4: Move the fast pointer two steps
                //  array values themselves are used as indices for the next hop.
                //  In problems like "Find the Duplicate Number", the array is often described as containing n + 1 integers, where each integer is between 1 and n.
                //  This guarantees that any value you pick from the array can be used as an index. 

                fast = nums[nums[fast]];//  array values themselves are used as indices for the next hop - case for cycle detection or duplicate 


                //indicating a cycle 
                if (slow == fast)
                    break;// Step 5: The loop breaks when the slow & fast pointers meet, indicating a cycle in linkedlist/duplicate in array

            }
            //do
            //{
            //    // Step 3: Move the slow pointer one step
            //    slow = nums[slow];

            //    // Step 4: Move the fast pointer two steps
            //        //  array values themselves are used as indices for the next hop.
            //        //  In problems like "Find the Duplicate Number", the array is often described as containing n + 1 integers, where each integer is between 1 and n.
            //        //  This guarantees that any value you pick from the array can be used as an index. 
            //    fast = nums[nums[fast]];//  array values themselves are used as indices for the next hop - case for cycle detection or duplicate 
            //}
            ////indicating a cycle 
            //while (slow != fast);  // Step 5: The loop breaks when the slow & fast pointers meet, indicating a cycle in linkedlist/duplicate in array


            // Phase 2 : Identifying Cycle Start
            // Step 6: Reset the slow pointer to the start
            slow = 0;

            // Step 7: Move both pointers one step at a time until they meet again
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            // Step 8: The element where they meet again is the duplicate element
            return slow;
        }
    }
}
