using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.Medium
{
    public class _438_Find_All_Anagrams_in_a_String
    {

        #region Approach 1 dictionary


        // [WORKING] Using Approach 1 of Solution (hashmap / dictionary).
        public IList<int> FindAnagrams(string s, string p)
        {
            Dictionary<char, int> pMap = new Dictionary<char, int>();
            Dictionary<char, int> sMap = new Dictionary<char, int>();

            int k = p.Length;

            int windowStart = 0;

            // result to return;
            List<int> result = new List<int>();

            // if a string in which we need to find anagram is less then it is not possible 
            if (s.Length < p.Length)
            {
                return new List<int>();
            }

            // keep all character and its count in dictionary 
            foreach (char c in p)
            {
                if (!pMap.ContainsKey(c))
                {
                    pMap[c] = 1;
                }
                else
                {
                    pMap[c]++;
                }
            }            

           

            for (int i = 0; i < s.Length; i++)
            {
                if (!sMap.ContainsKey(s[i]))
                {
                    sMap[s[i]] = 1;
                }
                else
                {
                    sMap[s[i]]++;
                }

                // sliding window - window where we need to check condition and do operation and slide forward while removing backword 
                if (i >= k - 1)
                {
                    // As soon as i hits p.Lenght - 1, do the comparison, and remove from head of the window (left-end).
                    if (AreDictsEqual(pMap, sMap))
                    {
                        result.Add(windowStart);
                    }

                    if (sMap[s[windowStart]] == 1)
                    {
                        sMap.Remove(s[windowStart]);
                    }
                    else
                    {
                        sMap[s[windowStart]] = sMap[s[windowStart]] - 1;
                    }
                    windowStart++;
                }

            }

            return result;
        }


        private bool AreDictsEqual(Dictionary<char, int> pDict, Dictionary<char, int> sDict)
        {
            // Number of keys have to be the same.
            if (pDict.Count != sDict.Count)
            {
                return false;
            }

            // For every pDict.Key, ensure there is a match with sDict.Key.
            foreach (var pitem in pDict)
            {
                if (!sDict.ContainsKey(pitem.Key) || pitem.Value != sDict[pitem.Key])
                {
                    return false;
                }
            }
            return true;
        }


        #endregion


        #region Approach 2 Array


        // [WORKING] Using Approach 2 of Solution (arrays).
        public IList<int> FindAnagrams_Approach2(string s, string p)
        {
            var sArray = new int[26];
            var pArray = new int[26];
            var output = new List<int>();

            for (var i = 0; i < p.Length; ++i)
            {
                ++pArray[p[i] - 'a'];
            }

            for (var i = 0; i < s.Length; ++i)
            {
                ++sArray[s[i] - 'a'];
                if (i >= p.Length - 1)
                {
                    if (CompareArrays(sArray, pArray))
                    {
                        output.Add(i - p.Length + 1);
                    }
                    // Decrement count for char at head of window (left-end).
                    --sArray[s[i - p.Length + 1] - 'a'];
                }
            }
            return output;
        }

        private bool CompareArrays(int[] s, int[] p)
        {
            return s.SequenceEqual(p);
        }
        #endregion


    }
}
