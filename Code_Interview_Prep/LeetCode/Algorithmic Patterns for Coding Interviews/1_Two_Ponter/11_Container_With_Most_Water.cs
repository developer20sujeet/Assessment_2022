using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._1_Two_Ponter
{
    internal class Solution
    {
        /// <summary>
        /// https://www.youtube.com/watch?v=e0kiAdtRGk8&list=PLPyD8bF-abzuUAt2Lf--gpMlrQNjxXgDX&index=9
        /// https://leetcode.com/problems/container-with-most-water/
        /// 
        /// Tips 
        ///   1. You need to find Areas of rectangle = Areas = Lenght * width 
        ///   2. Max water a container can keep is =Areas of rectangle
        ///   4. Solved by Two pointer 
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public long maxArea(int[] height)
        {
            // edge case , must be array size of 2
            if (height == null || height.Length < 2)
            {
                return 0;
            }

            // Two pointer need start and end 
            int start = 0;
            int end = height.Length - 1;

            long maxArea = long.MinValue;

            // Starting the loop from very left side 
            while (start < end)
            {
                // We know that a container can hold water till Minium of wall width
                // so we need to find Minium of wall width between two wall
                int minContainerWallWidth = Math.Min(height[start], height[end]);

                // we need wall lenght to know area of rectangle 
                int totalContainerLength = end - start;

                // Total area of rectangle 
                long totalContainerAreaToHoldWater = minContainerWallWidth * totalContainerLength;

                // Take MaxArea
                maxArea = Math.Max(maxArea, totalContainerAreaToHoldWater);

                // Decision to make to move pointer from left to right or from right  to left
                // whichever container wall is smaller that pointer should move (left or right)
                if (height[start] < height[end])
                {
                    // If left side pointer wall is smaller then move bit right side 
                    start++;
                }
                else
                {
                    // If right side pointer wall is smaller then move bit left side 
                    end--;
                }
            }

            return maxArea;
        }
    }
}
