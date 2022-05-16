using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    //https://leetcode.com/problems/permutation-in-string/submissions/
    // Need to understand 
    public class Permutation_in_String
    {
        public static bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            // 26 alphabet character 
            int[] s1Hash = new int[26];
            int[] s2Hash = new int[26];

            // idea is to know the alphabet occorence 
            for (int i = 0; i < s1.Length; i++)
            {
                // you need to know ACII table 
                // Aarray is 0 to 25 index 
                // 97 = a so s1['i'] = 97 so 97-97=0 and index 0=1 means a is present in array 
                s1Hash[s1[i] - 97]++;

                // only firt few character equal to lenghth of s1 
                s2Hash[s2[i] - 97]++;
            }

            // first chech if both string has same charctaer at the very begging 
            if (s1Hash.SequenceEqual(s2Hash))
                return true;

            for (int i = s1.Length; i < s2.Length; i++)
            {
                s2Hash[s2[i] - 97]++;

                // 
                s2Hash[s2[i - s1.Length] - 97]--;

                if (s1Hash.SequenceEqual(s2Hash))
                    return true;
            }
            return false;
        }
    }
}
