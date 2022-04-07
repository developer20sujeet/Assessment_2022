using Assessment.Array;
using System;
using Assessment.Array.Basic;
using Assessment.Others;
using Assessment.Pattern_Making;
using Assessment.String;
using Assessment.Integer;
using Assessment.Array.DS_Algo;
using Assessment.LeetCode;
using System.Collections.Generic;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 7, 1, 5, 3, 6, 4 };

            int minValue = int.MaxValue;
            int profit = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if(arr[i]< minValue)
                {
                    minValue = arr[i];
                }

            }

          
        }


    }
}



