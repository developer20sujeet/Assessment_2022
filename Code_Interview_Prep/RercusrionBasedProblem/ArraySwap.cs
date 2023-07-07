using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RercusrionBasedProblem
{
    internal class ArraySwap
    {

        public void SwapArray(int[] arr, int start, int end)
        {
            // Base case: If start index is greater than or equal to end index, return
            if (start >= end)
            {
                return;
            }

            // Swap the elements at start and end indices
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            // Recursive call with updated indices
            SwapArray(arr, start + 1, end - 1);
        }

    }
}
