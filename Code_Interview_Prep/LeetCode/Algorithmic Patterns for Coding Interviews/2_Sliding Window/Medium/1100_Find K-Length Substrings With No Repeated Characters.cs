using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.Medium
{
    //Given a string s and an integer k, return the number of substrings in s of length k with no repeated characters.
    public class _1100_Find_K_Length_Substrings_With_No_Repeated_Characters
    {

        public int numKLenSubstrNoRepeats(string s, int k)
        {
            if (s.Length < k)
                return 0;

            Dictionary<char, int> dict = new Dictionary<char, int>();
            int windowStart = 0;
            int counter=0;

            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {

                if (!dict.ContainsKey(s[windowEnd]))
                {

                    dict[s[windowEnd]] = 1;

                }
                else
                {
                    dict[s[windowEnd]]++;
                }

                if(windowEnd >= k-1)
                {
                    // tips and tricks - if we checked three element and if all are unique then count will be 3
                    // if there is not unique then count will be less than 3 .
                    if (dict.Count == k)
                        counter++;

                    if(dict[s[windowStart]] == 1)
                    {
                        dict.Remove(s[windowStart]);

                    }
                    else
                    {
                        dict[s[windowStart]] = dict[s[windowStart]] - 1;
                    }

                    windowStart++;
                }


            }


            return counter;
        }


    }
}
