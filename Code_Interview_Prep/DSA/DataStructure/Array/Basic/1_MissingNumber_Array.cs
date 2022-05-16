using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Array.Basic
{
    //https://practice.geeksforgeeks.org/problems/missing-number-in-array1416/1
    //Given an array of size N-1 such that it only contains distinct integers in the range of 1 to N.Find the missing element.
    public class MissingNumber_Array
    {
        public static void driver()
        {
            int[] array = { 1, 2, 4, 6, 3, 7, 8 };


            getMissingNo_method_1_sum_way(array, 8);
        }
        public static void MissingNumber_method_2_normal_way(int[] array, int n)
        {
            System.Array.Sort(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                int start = array[i];
                int nextToNextFromStart = array[i + 1];
                if (start + 1 != nextToNextFromStart)
                    Console.WriteLine("Missing Nuber -" + (start + 1));
            }
        }

        // most efficient 
        static void getMissingNo_method_1_sum_way(int[] a, int n)
        {
            int n_elements_sum = (n * (n + 1) / 2);
            int sum = 0;

            for (int i = 0; i < n - 1; i++)
                sum = sum + a[i];

            Console.WriteLine("Missing Nuber -" + (n_elements_sum - sum));;
        }
    }
    }
