using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Array
{
    public class Two_Sum
    {
        // LeetCode -Accepted //Runtime: 178 ms, faster than 74.43%
        // https://leetcode.com/problems/two-sum/
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return null;
        }


        // LeetCode -Accepted faster than 95.62% of C#
        //https://leetcode.com/problems/two-sum/
        public int[] TwoSum_V2(int[] nums, int target)
        {

            var seen = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (seen.TryGetValue(target - nums[i], out var index))
                {
                    return new[] { index, i };
                }
                else if (!seen.ContainsKey(nums[i]))
                {
                    seen.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}
