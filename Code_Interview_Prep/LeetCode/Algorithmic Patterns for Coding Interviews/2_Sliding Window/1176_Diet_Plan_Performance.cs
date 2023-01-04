using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window
{
    /// <summary>
    /// https://algolab.so/courses/algorithms-and-data-structure-video-course/lectures/43213063
    /// </summary>
    public class _1176_Diet_Plan_Performance
    {

        public static int dietPlanPerformance(int[] calories, int k, int lower, int upper)
        {

            double windowSum = 0;

            int windowStart = 0;

            int count = 0;

            for (int windowEnd = 0; windowEnd < calories.Length; windowEnd++)
            {
                windowSum += calories[windowEnd];

                if (windowEnd >= k - 1)
                {
                    if (windowSum > upper)
                    {
                        count++;
                    }
                    else if (windowSum < lower)
                    {
                        count--;
                    }

                    windowSum -= calories[windowStart];
                    windowStart ++;
                }
            }

            return count;
        }


    }
}
