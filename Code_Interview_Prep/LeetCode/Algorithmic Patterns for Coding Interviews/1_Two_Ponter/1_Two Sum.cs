using System.Collections.Generic;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews.Two_Ponter
{
    public class Solution
    {
        public static int[] twoSum(int[] nums, int target)
        {

            if (nums == null || nums.Length < 2)
                return new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();

            int[] indices = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int remainder = target - nums[i];

                if (dic.ContainsKey(remainder))
                {
                    // will give array index position
                    // Key is to store array value as key in dictionary
                    indices[0] = dic[remainder];
                    indices[1] = i;
                    return indices;
                }
                else if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i); // nums[i] is array i index value and i is index position
                }
            }

            return new int[] { };
        }

        
    }
}
