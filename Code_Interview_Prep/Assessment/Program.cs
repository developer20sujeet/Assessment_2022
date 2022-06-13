
using System;

using Assessment.Others;
using Assessment.Pattern_Making;

using Assessment.Integer;

using System.Collections.Generic;



namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unSortedArr = { 9, 4, 1, 8, 2, 6, 8, 10 };

            //unSortedArr= new MergeSort().MergeSort_Array_Alog(unSortedArr);

            // bool isValid= word_count_matching.IsValid_way2("level", "leevl");

            string s1 = "level";

            Dictionary<char, int> My_dict1 = new Dictionary<char, int>();

            for (int i = 0; i < s1.Length; i++)
            {
                if (My_dict1.ContainsKey(s1[i]))
                {
                    My_dict1[s1[i]]++;
                }
                else
                {
                    // My_dict1[item] = 1;
                    My_dict1.Add(s1[i], 1);
                }

            }


            foreach (var ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);
            }

        }


    }
}



