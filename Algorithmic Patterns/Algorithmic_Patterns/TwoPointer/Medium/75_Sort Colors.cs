using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithmic_Patterns.TwoPointer.Medium
{
    internal class _75_Sort_Colors
    {
        /// <summary>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// Algorithm used: Dutch National Flag Problem -Dutch National Flag consists of three horizontal bands of color: red on the top, white in the middle, and blue at the bottom
        /// Algorithmic coding pattern: Three Pointers
        /// Data structure used: Array 
        /// Company name: Commonly asked in various companies
        /// Important Tips and Tricks: Use three pointers to separate 0s, 1s, and 2s.
        /// Lessons Learned: Manipulate pointers carefully to sort the array in one pass.
        /// Central Idea: Use three pointers to sort the array in one pass without extra space.
        /// 
        /// p0 (Pointer for 0s or "Red"): Starting at the beginning of the array
        /// curr(Current Pointer or "White") : Also starting at the beginning of the array
        /// p2(Pointer for 2s or "Blue") : Starting at the end of the array
        /// 
        /// // RED   | 0 0 0 0 0
        //-----  | ---------
        // WHITE | 1 1 1 1 1
        //-----  | ---------
        // BLUE  | 2 2 2 2 2
        /// </summary>
        public void SortColors(int[] nums)
        {
            // Step 1: Initialize pointers
            // p0 keeps track of the rightmost boundary for zeros.
            // p2 keeps track of the leftmost boundary for twos.
            // curr iterates over the array.
            // Reason: This step sets the initial positions for the pointers that will guide the algorithm.
            int p0 = 0; //Points to the position where the next 0 should go. 
            int curr = 0; // Points to the current element under consideration.
            int p2 = nums.Length - 1;//Points to the position where the next 2 should go.

            // Step 2: One-pass through the array
            // Reason: Loop iterates through the array, sorting it on-the-go.
            while (curr <= p2)
            {
                // Reason: If current element is 0, it needs to go at the beginning.
                if (nums[curr] == 0)
                {
                    // Swap nums[curr] and nums[p0] and advance both p0 and curr
                    // Reason: Puts the 0 in its correct position at p0
                    Swap(nums, curr, p0);

                    // Move p0 and curr pointers
                    // Reason: Update pointers for the next iteration.
                    p0++; //moved one step to the right to prepare for the next 0 you might find
                    curr++; //Move one step ahead because the element at curr was a 0 and has been swapped and placed correctly
                }
                else if (nums[curr] == 1)
                {
                    // Move curr pointer
                    // Reason: If nums[curr] is 1, it's already in the correct position.
                    curr++;
                }
                // Reason: If current element is 2, it needs to go at the end.
                else //if (nums[curr] == 2)
                {

                    // Reason: Puts the 2 in its correct position.
                    // Swap nums[curr] and nums[p2] and only advance p2 (curr remains at the same position)
                    Swap(nums, curr, p2);

                    // Move p2 pointer
                    // Reason: Update p2 for the next iteration.
                    p2--;//it moves one step to the left to prepare for the next 2 you might find
                         // not need to curr++;--did not increment curr because after swapping with p2, the new element at curr has not yet been evaluated. It could be another 2, a 0, or a 1.
                }

            }
        }


        /// <summary>
        /// Swap helper function to exchange two elements in the array
        /// </summary>
        private void Swap(int[] nums, int curr, int p0p2)
        {
            int temp = nums[curr];
            nums[curr] = nums[p0p2];
            nums[p0p2] = temp;
        }

    }
}
