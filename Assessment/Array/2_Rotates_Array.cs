using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Array
{
    public class Rotates_Array
    {
        //https://www.geeksforgeeks.org/array-rotation/?ref=lbp

        #region Method 1
        public static void Driver_Main_M1()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            leftRotate_m1(arr, 2, 7);
            printArray(arr, 7);
        }

        static void leftRotate_m1(int[] arr, int d, int n)
        {
            //1) Store the first d elements in a temp array
            int[] arr2 = { arr[0], arr[1] };

            //2) Shift rest of the arr[]
            for (int i = 0; i < n - 2; i++)
                arr[i] = arr[i + 2];

            //3) Store back the d elements
            arr[n-2] = arr2[0];
            arr[n-1] = arr2[1];
        }


        #endregion

        #region Method 2
        public static void Driver_Main_M2()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            leftRotate(arr, 2, 7);
            printArray(arr, 7);
        }
        /* Function to left rotate arr[] of size n by d*/
        static void leftRotate(int[] arr, int d, int n)
        {
            //  loop till less than element to rotate 
            for (int i = 0; i < d; i++)
                leftRotatebyOne(arr, n);
        }

        static void leftRotatebyOne(int[] arr, int n)
        {
            int i, temp = arr[0];
            for (i = 0; i < n - 1; i++)
                arr[i] = arr[i + 1];

            // putting first element at last 
            arr[n - 1] = temp;
        }
        #endregion

        /* utility function to print an array */
        static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
        }

        // Driver code
        //public static void Main()
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        //    leftRotate(arr, 2, 7);
        //    printArray(arr, 7);
        //}
    }
}
