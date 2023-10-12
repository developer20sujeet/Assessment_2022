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
        // time complexity of O(n) and a space complexity of O(n).
        #region Best With Dictionary

        /// <summary>
        ///  time complexity of O(n) and a space complexity of O(n).
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>     
        public int[] TwoSum_Dictionary(int[] nums, int target)
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

                // Otherwise, add and update the current number and its index to the dictionary
                // Note -map.Add(nums[i], i); this will not work why? think
                numIndices[nums[i]] = i;
            }

            // If no solution is found, return an empty array (this should never happen for valid input)
            return new int[0];
        }
        #endregion



        //Time Complexity: O(n^2) && Space Complexity: O(1)
        #region BruteForce N^2
        /// <summary>
        /// Solves the Two Sum problem.
        /// Time Complexity: O(n^2) && Space Complexity: O(1)
        /// Algorithm Used: Brute-force
        /// </summary>
        /// <param name="nums">Input array of integers.</param>
        /// <param name="target">Target sum to find.</param>
        /// <returns>An array of two indices whose values add up to the target sum.</returns>
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
        #endregion


        //Time Complexity: O(n log n) & Space Complexity: O(n)
        #region with Array and Tuples - Array Sort
        /// <summary>
        /// Solves the Two Sum problem using two-pointer technique.
        /// Time Complexity: O(n log n)
        /// Space Complexity: O(n)
        /// Algorithm Used: Sorting with Two Pointers
        /// 
        /// 
        /// The first loop to populate numbersWithIndices runs in O(n) time.
        /// Sorting the array - O(nlogn) time.
        /// The two-pointer technique runs in O(n) time.
        /// </summary>
        /// <param name="nums">Input array of integers.</param>
        /// <param name="target">Target sum to find.</param>
        /// <returns>An array of two indices whose values add up to the target sum.</returns>
        public int[] TwoSum_TwoPointer_TuplesWithArray(int[] nums, int target)
        {
            // Create an array to store the numbers and their corresponding indices
            (int number, int index)[] numbersWithIndices = new (int number, int index)[nums.Length];


            for (int i = 0; i < nums.Length; i++)
            {
                numbersWithIndices[i] = (nums[i], i);
            }


            // Sort the numbers with indices based on the value
            // Sort smallest to largest (or in ascending order).

            // Learn -a and b in the lambda expression (a, b) => a.number.CompareTo(b.number) each represent individual tuples of the form (int number, int index).
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
        #endregion


        //Time Complexity: O(n log n) & Space Complexity: O(n)
        #region With List and ketvaluepair - Sort - like array

        /// <summary>
        /// https://leetcode.com/problems/two-sum/
        /// Use KeyValuePair
        /// The time complexity of this approach is  O(nlogn) due to the sorting step
        /// The space complexity is O(n) because of the additional data structure to store the pairs of numbers and indices.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum_ByKeyValuePair(int[] nums, int target)
        {
            // Create a list to store the numbers and their corresponding indices
            List<KeyValuePair<int, int>> numbersWithIndices = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                numbersWithIndices.Add(new KeyValuePair<int, int>(nums[i], i));
            }

            // Main part
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
        #endregion


    }
}
