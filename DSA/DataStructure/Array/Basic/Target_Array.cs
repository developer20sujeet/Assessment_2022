using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Others
{

    //Given an array of integers nums and an integer target,
    //return indices of the two numbers such that they add up to target
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.

    //You can return the answer in any order.Example 1:
    //Input: nums = [2, 7, 11, 15], target = 9
    //Output: [0,1]
    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    //Example 2:

    //Input: nums = [3, 2, 4], target = 6
    //Output: [1,2]
    class Target_Array
    {
        public static int[] twoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            // In case there is no solution, we'll just return null
            return null;
        }
        public int[] TwoSum_m2(int[] nums, int target)
        {
            Dictionary<int, int> lookup = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (lookup.ContainsKey(target - nums[i]))
                {
                    return new int[] { lookup[target - nums[i]], i };
                }
                lookup[nums[i]] = i;
            }
            return new int[] { };
        }
    }
}
