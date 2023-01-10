using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.DynamicWindow.Easy
{
    /// <summary>
    /// Given a binary array nums, return the maximum number of consecutive 1's in the array.
    /// </summary>
    public class _485_Max_Consecutive_Ones
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int counter = 0;
            int result = 0;

            for (int windowRight = 0; windowRight < nums.Length; windowRight++)
            {
                counter++;

                if (nums[windowRight] == 0)
                {
                    counter = 0;

                }

                result = Math.Max(result, counter);

            }
            return result;

        }
        public int FindMaxConsecutiveOnes_1(int[] nums)
        {

            int windowLeft = 0;
            int counter = 0;
            int result = 0;

            for (int windowRight = 0; windowRight < nums.Length; windowRight++)
            {
                if (nums[windowRight] == 1)
                {

                    counter++;
                    result = Math.Max(result, counter);

                }
                else
                {
                    counter = 0;
                }

            }
            return result;

        }
    }
}
