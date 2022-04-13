using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.String
{
    public class uniqueFirstCharcterString_john
    {
        // All Test case passing 
        //A unique character is one that appears only once in a string. Given a string consisting of lowercase English letters only, 
        //return the index of the first occurrence of a unique character in the string using 1-based indexing. 
        //If the string does not contain any unique character, return -1.
        public static int uniqueFirstCharcterString(string s)
        {
            //string s = "hackthegame";

            // Method 1 - arrall test carrse passed 
            //defining an array of size 26 to keep track of all duplicated lower case
            //a   97  lowercase a
            //b   98  lowercase b
            //c   99  lowercase c
            //d   100 lowercase d 
            //e   101 lowercase e
            //f   102 lowercase f
            //g   103 lowercase g
            //h   104 lowercase h
            //i   105 lowercase i
            //j   106 lowercase j
            //k   107 lowercase k
            //l   108 lowercase l
            //m   109 lowercase m
            //n   110 lowercase n
            //o   111 lowercase o
            //p   112 lowercase p
            //q   113 lowercase q
            //r   114 lowercase r
            //s   115 lowercase s
            //t   116 lowercase t
            //u   117 lowercase u
            //v   118 lowercase v
            //w   119 lowercase w
            //x   120 lowercase x
            //y   121 lowercase y
            //z   122 lowercase z

            int[] a = new int[26];

            for (int i = 0; i < 26; i++)
                a[i] = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int m = s[i];
                a[m - 97]++;

            }

            for (int i = 0; i < s.Length; i++)
            {
                int m = s[i];

                if (a[m - 97] == 1)
                {
                    return i + 1;
                }
            }

            return -1;
        }

        // passing 9 test case out of 15
        public static int uniqueFirstCharacterString_v2(string s)
        {
            // Method 2 only 9 test case passed out of 15
            for (int i = 0; i < s.Length; i++)
            {
                bool isDuplicateCharacterExist = false;

                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        isDuplicateCharacterExist = true;

                        break;
                    }
                }

                if (!isDuplicateCharacterExist)
                {
                    return i + 1;
                }
            }
            return -1;
        }



        //LeetCode passed 
        public int FirstUniqChar(string s)
        {

            Dictionary<char, List<int>> map = new Dictionary<char, List<int>>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], new List<int>() { i });
                }
                else
                {
                    map[s[i]].Add(i);
                }
            }

            int minIndex = Int32.MaxValue;

            foreach (var value in map.Values)
            {
                if (value.Count == 1 && value[0] < minIndex)
                {
                    minIndex = value[0];
                }
            }

            return minIndex == Int32.MaxValue ? -1 : minIndex;

        }

        //LeetCode passed 
        //https://leetcode.com/problems/first-unique-character-in-a-string/discuss/1874350/C-Solution-using-Dictionary
        public static int FirstUniqChar_v2(string s)
        {

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]] = dic[s[i]] + 1;
                }

                else
                {
                    dic.Add(s[i], 1);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (dic[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int FirstUniqChar_v3(string s)
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
