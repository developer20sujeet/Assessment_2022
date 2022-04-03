using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /**
      A unique character is one that appears only once in a string. Given a string consisting of lowercase English letters only, 
      return the index of the first occurrence of a unique character in the string using 1-based indexing. 
      If the string does not contain any unique character, return -1.
     **/
    //https://leetcode.com/problems/first-unique-character-in-a-string/
    public class First_Unique_Character_in_a_String
    {
        public int FirstUniqChar(string s)
        {

            int ans = 0;

            Dictionary<char, int> hm = new Dictionary<char, int>();

            foreach (char ch in s)
            {

                if (!hm.ContainsKey(ch))
                    hm.Add(ch, 1);
                else
                    hm[ch]++;

            }
            foreach (char ch in s)
            {

                if (hm[ch] == 1)
                    return ans;
                ans++;
            }
            return -1;

        }
    }
}
