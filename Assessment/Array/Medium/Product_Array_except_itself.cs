using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Array.Medium
{
    //https://www.geeksforgeeks.org/a-product-array-puzzle/

    //Given an array arr[] of n integers, construct a Product Array prod[] (of same size) such that prod[i] is equal to the product of all the elements of arr[] except arr[i]. 
    //Solve it without division operator in O(n) time.
    class Product_Array_except_itself
    {
        /* Function to print product array
        for a given array arr[] of size n */
        static void productArray_Gfg_m2(int[] arr, int n)
        {

            // Base case
            if (n == 1)
            {
                Console.Write(0);
                return;
            }
            // Initialize memory to all arrays
            int[] left = new int[n];
            int[] right = new int[n];
            int[] prod = new int[n];

            int i, j;

            /* Left most element of left array
            is always 1 */
            left[0] = 1;

            /* Right most element of right
            array is always 1 */
            right[n - 1] = 1;

            /* Construct the left array */
            for (i = 1; i < n; i++)
                left[i] = arr[i - 1] * left[i - 1];

            /* Construct the right array */
            for (j = n - 2; j >= 0; j--)
                right[j] = arr[j + 1] * right[j + 1];

            /* Construct the product array using
            left[] and right[] */
            for (i = 0; i < n; i++)
                prod[i] = left[i] * right[i];

            /* print the constructed prod array */
            for (i = 0; i < n; i++)
                Console.Write(prod[i] + " ");

            return;
        }

        /* Driver program to test the above function */
        public static void driver()
        {
            int[] arr = { 10, 3, 5, 6, 2 };
            int n = arr.Length;
            Console.Write("The product array is :\n");
        }
    }

}
