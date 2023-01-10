using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.Medium
{
    public class _567_Permutation_in_String
    {

        // if s2 contains a permutation of s1, 
        public bool CheckInclusion(string s1, string s2)
        {
          

            if (s1.Length > s2.Length)
                return false;


            Dictionary<char, int> s1Dic = new Dictionary<char, int>();
            Dictionary<char, int> s2Dic = new Dictionary<char, int>();

            int windowStart = 0;

            foreach (char item in s1)
            {

                if (!s1Dic.ContainsKey(item))
                {
                    s1Dic[item] = 1;

                }
                else
                {
                    s1Dic[item]++;
                }
            }

            // Step 1 of Sliding window 
            for (int windowEnd = 0; windowEnd < s2.Length; windowEnd++)
            {

                if (!s2Dic.ContainsKey(s2[windowEnd]))
                {
                    s2Dic[s2[windowEnd]] = 1;

                }
                else
                {
                    s2Dic[s2[windowEnd]]++;
                }

                if(windowEnd >= s1.Length-1)
                {
                    if (AreDictsEqual(s2Dic, s1Dic))
                    {
                        return true;
                    }

                    if (s2Dic[s2[windowStart]] == 1)
                    {
                        s2Dic.Remove(s2[windowStart]);
                    }
                    else
                    {
                        s2Dic[s2[windowStart]] = s2Dic[s2[windowStart]] - 1;
                    }
                    windowStart++;
                }


            }  


            return false;
        }
        private bool AreDictsEqual(Dictionary<char, int> s2dic, Dictionary<char, int> s1dic)
        {
            // Number of keys have to be the same.
            if (s2dic.Count != s1dic.Count)
            {
                return false;
            }

            // For every pDict.Key, ensure there is a match with sDict.Key.
            foreach (var s1item in s1dic)
            {
                if (!s2dic.ContainsKey(s1item.Key) || s1item.Value != s2dic[s1item.Key])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
