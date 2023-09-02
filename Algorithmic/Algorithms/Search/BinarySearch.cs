using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms.Search
{
    internal class BinarySearchs
    {
        /// <summary>
        /// Binary Search Algorithm without Recursion
        /// Time Complexity: O(log n)
        /// Space Complexity: O(1)
        /// Algorithm Used: Binary Search
        /// Algorithmic Code Pattern Used: Iterative
        /// Data Structure Used: Array
        /// Company: This problem is often asked in companies like Google, Microsoft, Amazon, etc.
        /// Tips and Tricks: Always validate the input and handle edge cases like a null, empty, or single-element array.
        /// Lessons Learned: Use a while loop for the iterative approach and ensure to update 'left' and 'right' pointers appropriately.
        /// </summary>
        /// <param name="arr">The sorted array</param>
        /// <param name="target">The target value</param>
        /// <returns>The index of the target element, or -1 if not found</returns>
        static int BinarySearch(int[] arr, int target)
        {
            // Edge Case 1: Null array
            if (arr == null || arr.Length == 0)
                return -1;


            // Edge Case 3: Single-element array
            if (arr.Length == 1)
            {
                return arr[0] == target ? 0 : -1;
            }

            // Step 1: Initialize 'left' and 'right' pointers
            int left = 0;
            int right = arr.Length - 1;

            // Step 2: Loop until 'left' is less than or equal to 'right'
            while (left <= right)
            {
                // Step 3: Calculate the middle index using `left + (right - left) / 2` to avoid overflow
                // The expression int mid = left + (right - left) / 2; is used instead of (left + right) / 2 to prevent integer overflow.
                // If left and right are large integers, their sum could exceed the maximum value that can be stored in an integer variable, causing an overflow

                int mid = left + (right - left) / 2;

                // Step 4: Check if the middle element is the target
                if (arr[mid] == target)
                {
                    return mid;
                }

                // Step 5: Update the 'left' and 'right' pointers based on the comparison
                if (arr[mid] < target)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }

            // Step 6: If the element is not found, return -1
            return -1;
        }


        /// <summary>
        /// Binary Search Algorithm using Recursion
        /// Time Complexity: O(log n)
        /// Space Complexity: O(log n) due to recursive stack
        /// Algorithm Used: Binary Search
        /// Algorithmic Code Pattern Used: Recursion
        /// Data Structure Used: Array
        /// Company: This problem is commonly asked in companies like Google, Microsoft, and Amazon.
        /// Tips and Tricks: Make sure to handle edge cases like empty array or single-element array.
        /// Lessons Learned: Always remember to calculate the middle index as (left + right) / 2 to avoid overflow.
        /// </summary>
        /// <param name="arr">The sorted array</param>
        /// <param name="target">The target value</param>
        /// <param name="left">The leftmost index</param>
        /// <param name="right">The rightmost index</param>
        /// <returns>The index of the target element, or -1 if not found</returns>
        static int BinarySearch_Recursive(int[] arr, int target, int left, int right)
        {
            // Step 1: Check the base case that the array does not contain the target
            if (left > right)
            {
                return -1;
            }

            // Step 2: Calculate the middle index
            int mid = (left + right) / 2; // Avoids overflow compared to (left + right) / 2

            // Step 3: Check the middle element
            if (arr[mid] == target)
            {
                return mid;
            }

            // Step 4: Recur on the appropriate half
            if (arr[mid] > target)
            {
                return BinarySearch(arr, target, left, mid - 1); // Search in the left half
            }
            else
            {
                return BinarySearch(arr, target, mid + 1, right); // Search in the right half
            }
        }

    }
}