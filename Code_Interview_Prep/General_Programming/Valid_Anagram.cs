using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Programming
{
    /// <summary>
    /// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    /// </summary>
    internal class Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            // Check if the lengths of the two strings are equal
            if (s.Length != t.Length)
            {
                return false;
            }

            // Create a dictionary to store the frequency of each character in the first string
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Iterate over the characters in the second string and decrement the frequency of each character in the dictionary
            foreach (char c in t)
            {
                if (!charCount.ContainsKey(c))
                {
                    return false;
                }
                charCount[c]--;

                //The if (charCount[c] < 0) check is needed to handle the case where a character in the second string appears more times than it appears in the first string.
                if (charCount[c] < 0)
                {
                    return false;
                }
            }

            // If the loop completes, return true
            return true;
        }


    }
}
