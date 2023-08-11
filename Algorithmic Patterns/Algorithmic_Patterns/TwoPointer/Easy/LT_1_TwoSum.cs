using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Easy
{
    internal class LT_1_TwoSum
    {
        /// <summary>
        /// https://leetcode.com/problems/two-sum/
        /// Advanced Way
        /// The time complexity of this approach is  O(nlogn) due to the sorting step
        /// The space complexity is O(n) because of the additional data structure to store the pairs of numbers and indices.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            // Create a list to store the numbers and their corresponding indices
            List<KeyValuePair<int, int>> numbersWithIndices = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                numbersWithIndices.Add(new KeyValuePair<int, int>(nums[i], i));
            }

            // Sort the numbers with indices based on the value
            numbersWithIndices.Sort((a, b) => a.Key.CompareTo(b.Key));

            int left = 0;
            int right = nums.Length - 1;

            // Use two pointers technique to find the indices that add up to the target
            while (left < right)
            {
                int sum = numbersWithIndices[left].Key + numbersWithIndices[right].Key;
                if (sum == target)
                {
                    return new int[] { numbersWithIndices[left].Value, numbersWithIndices[right].Value };
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            // If no solution is found, return an empty array (this should never happen for valid input)
            return new int[0];
        }

        /// <summary>
        ///  time complexity of O(n) and a space complexity of O(n).
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum_way2_Without_TwoPointer(int[] nums, int target)
        {
            // Create a dictionary to store the numbers and their corresponding indices
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            // Iterate through the array, looking for the complement of each number
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                // If the complement is found in the dictionary, return its index along with the current index
                if (numIndices.ContainsKey(complement))
                {
                    return new int[] { numIndices[complement], i };
                }

                // Otherwise, add the current number and its index to the dictionary
                numIndices[nums[i]] = i;
            }

            // If no solution is found, return an empty array (this should never happen for valid input)
            return new int[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum_TwoPointer_withArray(int[] nums, int target)
        {
            // Create an array to store the numbers and their corresponding indices
            var numbersWithIndices = new (int number, int index)[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                numbersWithIndices[i] = (nums[i], i);
            }

            // Sort the numbers with indices based on the value
            Array.Sort(numbersWithIndices, (a, b) => a.number.CompareTo(b.number));

            int left = 0;
            int right = nums.Length - 1;

            // Use two pointers technique to find the indices that add up to the target
            while (left < right)
            {
                int sum = numbersWithIndices[left].number + numbersWithIndices[right].number;
                if (sum == target)
                {
                    return new int[] { numbersWithIndices[left].index, numbersWithIndices[right].index };
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            // If no solution is found, return an empty array (this should never happen for valid input)
            return new int[0];
        }



    }
}
