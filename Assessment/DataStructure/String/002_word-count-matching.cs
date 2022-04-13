using System;
using System.Collections.Generic;
using System.Text;
namespace Assessment.DataStructure.String
{
    /*
        Given two words as input, write a function to return true/false if they match based a condition.
    What will indicate if a word matches is that it must contain the same character count for each letter.
    For an example: "level" has 2 'l' charcters, 2, 'e' characters, and one 'v' character
    The following words compared to "level" would return as true:
    leevl
    veell
   
    Charles Swab
    */
    public class word_count_matching
    {
        public static bool IsValid(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            Dictionary<char, int> dic1 = new Dictionary<char, int>();

            // string 1
            for (int i = 0; i < s1.Length; i++)
            {
                if (!dic1.ContainsKey(s1[i]))
                {
                    dic1.Add(s1[i], 1);
                }
                else
                {
                    dic1[s1[i]]++;
                }
            }
            // string 2
            Dictionary<char, int> dic2 = new Dictionary<char, int>();
            for (int i = 0; i < s2.Length; i++)
            {
                if (!dic2.ContainsKey(s2[i]))
                {
                    dic2.Add(s2[i], 1);
                }
                else
                {
                    dic2[s2[i]]++;
                }
            }
            foreach (Char v in s1)
            {
                if (dic1[v] != dic2[v])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsValid_way2(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            // Array one 
            char[] arr1 = s1.ToCharArray();
            System.Array.Sort(arr1);

            // Array 2
            char[] arr2 = s2.ToCharArray();
            System.Array.Sort(arr2);

            // For loop 
            for (int i = 0; i < s1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;

            }

            return true;

        }
    }
}
