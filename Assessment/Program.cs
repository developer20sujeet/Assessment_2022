using Assessment.Array;
using System;
using Assessment.Array.Basic;
using Assessment.Others;
using Assessment.Pattern_Making;
using Assessment.String;
using Assessment.Integer;
using Assessment.Array.DS_Algo;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 7, 8, 9 };

           new  Binary_Search_Array().Binary_Search_Array_M2(arr, 8, 0, 6);


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
