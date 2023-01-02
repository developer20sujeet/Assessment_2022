using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window
{
    public class Average_Of_All_Subarrays
    {
        /*
         Given an array, find the average of all subarrays of ‘K’ contiguous elements in it.

        Let’s understand this problem with real input:

        Array: [1, 3, 2, 6, -1, 4, 1, 8, 2], K=5
        Here is the final output containing the averages of all subarrays of size '5':

        Output: [2.2, 2.8, 2.4, 3.6, 2.8]

         */

        public static double[] Average_Of_All_Subarrays_Demo(int[] nums, int k)
        {
            List<double> list = new List<double>();

          
            // Running total
            double WindowSum = 0;


            // sliding start 
            int start = 0;
            int arrCounter = 0;

            for (int WindowEnd = 0; WindowEnd < nums.Length; WindowEnd++)
            {
                WindowSum += nums[WindowEnd];

                if (WindowEnd >= k - 1)
                {
                    double average = WindowSum / k;

                    WindowSum -= nums[start];

                    list.Add(average);

                    start++;

                    arrCounter++;
                }
            }
            return list.ToArray();
        }
    }
}
