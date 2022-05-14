using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Array.DS_Algo
{
    public class Binary_Search_Array
    {
        public void Binary_Search_Array_M2(int[] arr, int keyToSearch, int low, int high)
        {
            int a = System.Array.BinarySearch(arr, keyToSearch);
        }

        //https://logicmojo.com/cracking_interview/#SampleLecture
        public int Binary_Search_Array_logicmojo_M2(int[] arr, int keyToSearch, int low, int high)
        {
            // Binary search work on sorted array 
            // Stop Recursive 
            if (low > high)
                return -1;

            // Divide = Binary search work on divide rule 
            // Why low + >>> addeded 
            // 
            int mid = low + ((high - low) / 2);

            if (arr[mid] == keyToSearch)
            {
                return mid;
            }
            else if (keyToSearch < arr[mid])
            {
                // mid - 1=  search left of middle [divide] 
                return Binary_Search_Array_logicmojo_M2(arr, keyToSearch, low, mid - 1);
            }
            else
            {
                // mid + 1=  search right of middle [divide] 
                return Binary_Search_Array_logicmojo_M2(arr, keyToSearch, mid + 1, high);
            }

        }

    }
}
