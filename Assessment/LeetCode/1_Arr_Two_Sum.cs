using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.LeetCode
{
    public class Two_Sum
    {
        // LeetCode -Accepted
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int [] { i, j };
                    }
                }
            }

            return null;
        }
    }
}
