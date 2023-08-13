using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Patterns.TwoPointer.Medium
{
    internal class _167_Two_Sum_II_Input_Array_Is_Sorted
    {
        /// <summary>
        /// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            int leftPointer = 0;
            int rightPointer = numbers.Length - 1;

            while (leftPointer < rightPointer)
            {
                int sum = numbers[leftPointer] + numbers[rightPointer];

                if (sum == target)
                {
                    return new int[] { leftPointer + 1, rightPointer + 1 };

                }
                else if (sum < target)
                {
                    leftPointer++;
                }
                else if (sum > target)
                {
                    rightPointer--;
                }

            }

            return new int[0];
        }
    }
}
