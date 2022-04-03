using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assessment.Array.Basic
{
    public class Duplicate
    {
        public static void RemoveDuplicate()
        {
            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2 };

            int[] dist = nums.Distinct().ToArray();
        }

        public static void FindDuplicate()
        {
            var counts = new Dictionary<int, int>();
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            for (int i = 0; i < array.Length; i++)
            {
                int currentVal = array[i];
                if (counts.ContainsKey(currentVal))
                    counts[currentVal]++;
                else
                    counts[currentVal] = 1;
            }
            foreach (var kvp in counts)
                Console.WriteLine("\t\n " + kvp.Key + " occurs " + kvp.Value);
        }

        public static void FindDuplicate_m2()
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            int count = 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j + 1])
                        count = count + 1;
                }
                Console.WriteLine("\t\n " + array[i] + "occurse" + count);
                Console.ReadKey();
            }
        }

        public static void FindDuplicate_m4()
        {
            HashSet<int> mySet = new HashSet<int>();
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            //int count = 1;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if(mySet.Add(array[i]) == false))
            //    {
            //        // print Diplicate 
            //    }
            //}
              
        }
    }
}
