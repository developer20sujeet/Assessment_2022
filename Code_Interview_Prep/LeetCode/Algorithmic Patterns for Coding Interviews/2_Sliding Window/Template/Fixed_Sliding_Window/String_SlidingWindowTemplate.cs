using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.Template.Fixed_Sliding_Window
{
    internal class String_SlidingWindowTemplate
    {
        // Sliding Window Template - String 
        public static int countGoodSubstrings_slidingWindow_AlgoLabIo(string s)
        {
            // any constraint 
            var k = 3;
            if (s.Length < k)
            {
                return 0;
            }

            // keep track of result based on condition of requirement 
            int count = 0;

            // Hasmap to store occurance of each character of string 
            // tricks - this hasmap count will determine many condition of requiremtn - example line 45 of code 
            Dictionary<char, int> freq = new Dictionary<char, int>();

            // help to slid 
            var windowStart = 0;

            // Outer loop
            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                // store occurance of each character of string 
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
                    // Tricks - need to understand 
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
    }
}
