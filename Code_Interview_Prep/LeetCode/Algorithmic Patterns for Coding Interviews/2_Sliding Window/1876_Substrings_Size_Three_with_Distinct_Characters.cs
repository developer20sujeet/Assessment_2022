using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window
{
    public class Substrings_Size_Three_with_Distinct_Characters
    {
        public static int countGoodSubstrings_slidingWindow_AlgoLabIo(string s)
        {
            var k = 3;
            if (s.Length < k)
            {
                return 0;
            }

            var count = 0;
            Dictionary<char, int> freq = new Dictionary<char, int>();

            var windowStart = 0;

            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                if (!freq.ContainsKey(s[windowEnd]))
                {
                    freq[s[windowEnd]] = 1;
                }
                else
                {
                    freq[s[windowEnd]] = freq[s[windowEnd]] + 1;
                    //freq[s[windowEnd]] ++;
                }

                // Step 2 of Sliding Window
                if (windowEnd >= k - 1)
                {
                    // this count will be equal to K only if all previous charcater is unique and distinct
                    if (freq.Count == k)
                    {
                        count++;
                    }

                    //removes the character at index windowStart from the freq dictionary,
                    //either by deleting the key-value pair if the character has a frequency of 1, or by decrementing the frequency if it is greater than 1.
                    if (freq[s[windowStart]] == 1)
                    {
                        // Step 3 - of sliding window - remove from back and move forward by 1
                        freq.Remove(s[windowStart]);
                    }
                    else
                    {
                        // why descrease - because if string value is 'aab' and k=2, then total substring os aa, ab -  the a-2 , b-1 so to get ab we need a item from second position
                        // 1. it ensures that the freq dictionary accurately reflects the characters within the current window as the window is moved along the input string.
                        // 2. Main reason - it reduce so that in next iteration count will be 1 and will be removed in above condition , not doing this will caused dictionary to hold 4 items 
                        freq[s[windowStart]] = freq[s[windowStart]] - 1;
                    }

                    // need to increment so that next time this position valaue can be removed 
                    windowStart++;
                }
            }
            return count;
        }

        #region Others 

        /// <summary>
        /// not efficient if sliding window greater 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int CountGoodSubstrings(string s)
        {
            if (s.Length < 3)
                return 0;

            int cnt = 0;

            for (int i = 0; i < s.Length - 2; i++)
            {
                if (s[i] == s[i + 1] || s[i] == s[i + 2] || s[i + 1] == s[i + 2])
                    continue;

                cnt++;
            }

            return cnt;
        } 
        #endregion

        public static int countGoodSubstrings_slidingWindow_Practice(string s)
        {
            int k = 3; // window
            int count = 0;
            Dictionary<char, int> dic= new Dictionary<char, int> ();

            // Sliding window template 

            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                if (!dic.ContainsKey(s[windowEnd]))
                {
                    dic[s[windowEnd]] = 1;

                }
                else
                {
                    dic[s[windowEnd]]++;
                }


                if(windowEnd >= k-1)
                {
                    if(dic.Count==k)
                    {
                        count++;
                    }

                    if (dic[s[windowStart]]==1)
                    {
                        dic.Remove(s[windowStart]);
                    }
                    else
                    {
                        dic[s[windowStart]]--;
                    }

                    // Remove backward element by 1 
                    // slide forward by 1
                    windowStart++;

                }

               

            }

            return count;

        }

    }
}
