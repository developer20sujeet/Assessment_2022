
using LeetCode;
using LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window;
using LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.DynamicWindow.Easy;
using LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.DynamicWindow.Hard;
using LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.DynamicWindow.Medium;
using LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.Medium;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] arr1 = { 1, 0, 1, 1, 0 };

            //string a = new _76_Minimum_Window_Substring_cs().MinWindow("ADOBECODEBANC", "ABC");
            //string a = new _76_Minimum_Window_Substring_cs().MinWindow("AAOBEBCODEBANC", "ABBC");

            int a = new _487_Max_Consecutive_Ones_II().solution(arr1);

        }
    }
}
