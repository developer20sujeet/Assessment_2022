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
            int[] arr = { 1, 3, 0, 0, 4, 0, 9 };

            Move_zeros_array_end.Move_zero_array_logicmojo_M3(arr);


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
