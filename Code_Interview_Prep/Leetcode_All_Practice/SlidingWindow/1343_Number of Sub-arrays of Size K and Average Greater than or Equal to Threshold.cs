using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Leetcode_All_Practice.SlidingWindow
{
    public class _1343_Number_of_Sub_arrays_of_Size_K_and_Average_Greater_than_or_Equal_to_Threshold
    {
        //Given an array of integers arr and two integers k and threshold, return the number of sub-arrays of size k and average greater than
        //or equal to threshold.
        public int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            double Average = 0;
            double currentRunningWindow = 0;
            int counter = 0;
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                currentRunningWindow += arr[windowEnd];

                if (windowEnd >= k - 1)
                {

                    Average = currentRunningWindow / k;

                    if (Average >= threshold)
                    {
                        counter++;
                    }

                    currentRunningWindow -= arr[windowStart];
                    windowStart++;
                }
            }
            return counter++;

        }
    }
}
