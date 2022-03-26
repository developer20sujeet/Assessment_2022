using System;
using System.Collections;

namespace Assessment
{
    class Array_Sort
    {
        public static void SortArray_library()
        {
            // declaring and initializing the array
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            // Sort array in ascending order.
            // System.Array.Sort(arr);

            // reverse array
            // System.Array.Reverse(arr);

            // print all element of array
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
        public static void SortArray_Without_library()
        {
            // declaring and initializing the array
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            int temp;

            // traverse 0 to array length
            for (int i = 0; i < arr.Length; i++)
            {
                // traverse i+1 to array length
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // compare array element with 
                    // all next element
                    if (arr[i] < arr[j])
                    {

                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            // print all element of array
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}

