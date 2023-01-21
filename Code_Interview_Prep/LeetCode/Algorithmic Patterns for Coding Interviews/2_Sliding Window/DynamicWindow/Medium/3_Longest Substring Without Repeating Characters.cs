using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.DynamicWindow.Medium
{
    public class _3_Longest_Substring_Without_Repeating_Characters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int longestSubstringCount = 0;
            int windowStart = 0;

            Dictionary<char, int> map = new Dictionary<char, int>();

            //The window is expanded by incrementing the "windowEnd" pointer
            // Outer for loop used to expand window 
            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                //continues to run as long as the current character already exists in the "map" dictionary 
                //Dynamic sliding window use while loop 
                // Inner while loop is used to shrink window 
                while (map.ContainsKey(s[windowEnd]))
                {
                    map.Remove(s[windowStart]);

                    //This is done to ensure that we only keep the characters in the current substring and remove the previous ones.
                    windowStart++;
                }

                map[s[windowEnd]] = 1;
                longestSubstringCount = Math.Max(longestSubstringCount, windowEnd - windowStart + 1);
               
            }
            return longestSubstringCount;

        }


    }
}
