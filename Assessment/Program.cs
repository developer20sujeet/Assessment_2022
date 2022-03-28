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
            HashSet<int> mySet = new HashSet<int>();

            bool b2 = mySet.Add(1);
            bool a1 = mySet.Add(1);


            int a =  Math.Max(5, 10);
            int[] arr = { 7, 6, 4, 3, 1 };

            //new BestTime_Buy_Sell_Stock().MaxProfit(arr);


            ClsString.findallsubstring("Sujeet");

            //Duplicate.FindDuplicate();
            //int a = 1221;
            //int x = a / 10;
            //int x1 = a % 10;
            //Palindrome.IsPalindrome_m1(1221);
            //int[] arr = { 3, 2, 4,5,9 };
            //int[] a1 = Target_Array.twoSum(arr, 11);


            Console.Read();
        }

        static void test()
        {
            int b = -2;
            int a = -1 - b;
        }
    }
}
