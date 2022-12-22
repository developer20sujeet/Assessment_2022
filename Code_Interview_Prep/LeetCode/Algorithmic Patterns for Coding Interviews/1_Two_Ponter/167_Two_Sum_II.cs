using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews.Two_Ponter
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    /// https://www.youtube.com/watch?v=4YKBwKnTnlM
    /// https://www.youtube.com/watch?v=2wVjt3yhGwg
    /// 
    /// Solution : Two Pointer
    /// </summary>
    public class Solution
	{

        /// <summary>
        /// Runtime: 211 ms, faster than 63.69% of C# online submissions for Two Sum II - Input Array Is Sorted.
        /// Memory Usage: 44.7 MB, less than 84.30% of C# online submissions for Two Sum II - Input Array Is Sorted.
        /// 
        /// We will use TWO POINTER here 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSumII(int[] arr, long target)
        {
            int pointe_one = 0;
            int pointer_two = arr.Length - 1;
            long sum;

            while (pointe_one < pointer_two)
            {
                sum = arr[pointe_one] + arr[pointer_two];

                if (sum == target)
                {
                    return new int[] { pointe_one + 1, pointer_two + 1 };
                }
                else if (sum < target)
                {
                    // why we increasing the pointe_one by 1 
                    // Because array is sorted in increasing order 
                    // and if left side pointer_one is less number then we need higher number to increase sum value to meet target
                    pointe_one += 1;

                }
                else
                {
                    // why we increasing the pointe_one by 1 
                    // Because array is sorted in increasing order 
                    // and if right side pointer_two is bigger number then we need lesser number to decrease sum value to meet target

                    pointer_two -= 1;
                }

            }

            return new int[] {}; // there is no such element to add to meet target
        }

    }
}
