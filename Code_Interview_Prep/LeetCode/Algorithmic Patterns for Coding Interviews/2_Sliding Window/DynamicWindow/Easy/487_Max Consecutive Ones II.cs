using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.DynamicWindow.Easy
{
    /// <summary>
    ///  { 1, 0, 1, 1, 0 };
    /// </summary>
    public class _487_Max_Consecutive_Ones_II
    {
        int maxZeroFlipedAllowed = 1;
        int ZeroCounter = 0;
        int currentWindow = 0;
        int maxWindow = 0;

        int windowStart = 0;

        public int solution(int[] nums)
        {

            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {

                if (nums[windowEnd]==0)
                {
                    ZeroCounter++;

                }

                while(ZeroCounter > maxZeroFlipedAllowed)
                {

                    if (nums[windowStart]==0)
                    {
                        ZeroCounter--;
                    }
                    windowStart++;
                }

                maxWindow = Math.Max(maxWindow, windowEnd - windowStart + 1);

            }

            return maxWindow;

        }


    }
}
