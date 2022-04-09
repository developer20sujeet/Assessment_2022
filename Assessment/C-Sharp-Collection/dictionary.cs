using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.C_Sharp_Collection
{
    /*
    Concept Remember 
        1. In Dictionary, key must be unique.
        2. Duplicate keys are not allowed if you try to use duplicate key then compiler will throw an exception.
        3. In Dictionary, you can only store same types of elements.
    */
    public class dictionary
    {
        public void dictionaryv2()
        {
            string s1 = "level";

            Dictionary<char, int> My_dict1 = new Dictionary<char, int>();

            foreach (char item in s1)
            {
                if (My_dict1.ContainsKey(item))
                {
                    My_dict1[item]++;
                }
                else
                {
                    // My_dict1[item] = 1;
                    My_dict1.Add(item, 1);
                }
            }


            foreach (var ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);
            }

        }

        public void dictionaryv3()
        {
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
