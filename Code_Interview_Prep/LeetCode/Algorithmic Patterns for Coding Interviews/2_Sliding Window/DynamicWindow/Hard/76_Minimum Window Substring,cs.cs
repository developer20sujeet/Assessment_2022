using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithmic_Patterns_for_Coding_Interviews._2_Sliding_Window.DynamicWindow.Hard
{
    //Trie or Aho-Corasick algorithm
    public class _76_Minimum_Window_Substring_cs
    {

        public string MinWindow(string s, string t)
        {
            #region freqStringToSearch For String t
            // Getting character frequency of string need to be searched 
            Dictionary<char, int> freqStringToSearch = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (!freqStringToSearch.ContainsKey(c))
                {
                    freqStringToSearch[c] = 1;
                }
                else
                {
                    freqStringToSearch[c]++;
                }
            }
            #endregion


            int matched = 0;
            int minStart = 0;
            int minLength = int.MaxValue;

            int windowStart = 0;


            // Sliding window - outer loop - think of right pointer 
            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                char c = s[windowEnd];

                #region freqStringToSearch If t frequency contain character from main string 

                // if t string frequency contain any charcter from main string s then remove matched character from frequency map
                if (freqStringToSearch.ContainsKey(c))
                {
                    // We found the character in main string (s string) so removing the frequency from t string
                    // simply we removing the frequency so that we are left with only frequency that we need next time 
                    freqStringToSearch[c]--;

                    // If all charcter found in main string (s) then we found 1 match 
                    if (freqStringToSearch[c] == 0)
                    {
                        //all the characters in the target string have been found within the current window of the input string.
                        matched++;
                    }
                }
                #endregion


                char remove;
                // if matched == freqStringToSearch.Count means we found our first substring 
                //When the matched character count is equal to the size of the HashMap/Dictionary, it means that all the characters in the target string have been found within the current window of the input string.
                while (matched == freqStringToSearch.Count)
                {
                    // windowEnd - windowStart + 1 - help to get window size , why +1 >> think when windowStart and windowEnd on Zero Index then still we have one count 
                    int windowSize = windowEnd - windowStart + 1;//get window size

                    //check if the current window's length is less than the current minimum length
                    // If it is, update the minimum length and starting index.
                    if (windowSize < minLength)
                    {
                        minLength = windowSize;
                        minStart = windowStart;
                    }

                    // we are shrinking now so we need to remove from left side 
                    remove = s[windowStart];

                    // we are only rebuilding the frequency count back 
                    if (freqStringToSearch.ContainsKey(remove))
                    {
                        // it is already made zero above - check region "freqStringToSearch If t frequency contain character from main string"
                        if (freqStringToSearch[remove] == 0)
                        {
                            //This is because the character being removed above was previously counted as a match, but now that it's being removed, the match count needs to be reduced.
                            matched--;
                        }


                        // Increasing the frequency 
                        //This is to reflect that this character is now being removed from the window and is no longer being considered as part of the current match
                        freqStringToSearch[remove]++; // ?? If the input string contains more occurrences of a certain character than the target string, the frequency count for that character in the HashMap/Dictionary can exceed the frequency of that character in the target string

                    }
                    windowStart++;
                }
            }

            if (minLength == int.MaxValue)
            {
                return "";
            }

            //return the substring of the input string starting at the minimum starting index and with the minimum length
            return s.Substring(minStart, minLength);
        }



        #region Other Implementation
        public string MinWindow_ArrayImplementation(string s, string t)
        {

            var pat = new int[256];

            for (int i = 0; i < t.Length; i++)
                pat[t[i]]++;

            var start = 0;
            var str = new int[256];

            var count = 0;
            var min = int.MaxValue;
            var startIndex = -1;
            for (int j = 0; j < s.Length; j++)
            {
                str[s[j]]++;

                if (pat[s[j]] > 0 && str[s[j]] <= pat[s[j]])
                    count++;

                if (count == t.Length)
                {
                    while (str[s[start]] > pat[s[start]] || pat[s[start]] == 0)
                    {
                        str[s[start]]--;
                        start++;
                    }

                    var len = j - start + 1;

                    if (len < min)
                    {
                        min = len;
                        startIndex = start;
                    }

                }
            }
            if (startIndex == -1)
                return "";

            return s.Substring(startIndex, min);

        }
        public string MinWindow_ChatGpt(string s, string t)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (!freq.ContainsKey(c))
                {
                    freq.Add(c, 0);
                }
                freq[c]++;
            }

            int matched = 0;
            int minStart = 0;
            int minLength = int.MaxValue;
            int windowStart = 0;
            Dictionary<char, int> originalFreq = new Dictionary<char, int>(freq); // added this line

            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                char c = s[windowEnd];

                if (freq.ContainsKey(c))
                {
                    freq[c]--;

                    if (freq[c] == 0)
                    {
                        matched++;
                    }
                }

                char remove;
                while (matched == freq.Count)
                {
                    int windowSize = windowEnd - windowStart + 1;
                    if (windowSize < minLength)
                    {
                        minLength = windowSize;
                        minStart = windowStart;
                    }

                    remove = s[windowStart];

                    if (freq.ContainsKey(remove))
                    {
                        if (freq[remove] == 0)
                        {
                            matched--;
                        }
                        freq[remove]++;
                    }
                    windowStart++;
                }
            }
            // added this region
            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                char remove = s[windowEnd];
                if (freq.ContainsKey(remove))
                {
                    freq[remove] = originalFreq[remove];
                }
            }
            //end
            if (minLength == int.MaxValue)
            {
                return "";
            }
            return s.Substring(minStart, minLength);
        }

        public string MinWindow_gpt_v1(string s, string t)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (!freq.ContainsKey(c))
                {
                    freq.Add(c, 0);
                }
                freq[c]++;
            }

            int matched = 0;
            int minStart = 0;
            int minLength = int.MaxValue;
            int windowStart = 0;

            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                char c = s[windowEnd];

                if (freq.ContainsKey(c))
                {
                    freq[c]--;

                    if (freq[c] >= 0)
                    {
                        matched++;
                    }
                }

                while (matched == t.Length)
                {
                    if (windowEnd - windowStart + 1 < minLength)
                    {
                        minLength = windowEnd - windowStart + 1;
                        minStart = windowStart;
                    }

                    char remove = s[windowStart];

                    if (freq.ContainsKey(remove))
                    {
                        if (freq[remove] >= 0)
                        {
                            matched--;
                        }
                        freq[remove]++;
                    }
                    windowStart++;
                }
            }

            if (minLength == int.MaxValue)
            {
                return "";
            }
            return s.Substring(minStart, minLength);
        }
        public string MinWindow_gpt_v2(string s, string t)
        {
            int[] freq = new int[128];
            int count = t.Length;
            for (int i = 0; i < count; i++)
            {
                freq[t[i]]++;
            }

            int minStart = 0, minLength = int.MaxValue, start = 0, end = 0;
            while (end < s.Length)
            {
                if (freq[s[end++]]-- > 0)
                {
                    count--;
                }

                while (count == 0)
                {
                    if (end - start < minLength)
                    {
                        minStart = start;
                        minLength = end - start;
                    }

                    if (freq[s[start++]]++ == 0)
                    {
                        count++;
                    }
                }
            }

            return minLength == int.MaxValue ? "" : s.Substring(minStart, minLength);
        }


        public string MinWindow_gpt_V3_Q(string s, string t)
        {
            int minStart = 0, minLength = int.MaxValue;
            int matched = 0;
            Queue<int> queue = new Queue<int>();

            int[] freq = new int[128];
            for (int i = 0; i < t.Length; i++)
            {
                freq[t[i]]++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (freq[c] > 0)
                {
                    queue.Enqueue(i);
                    freq[c]--;
                    matched++;
                    if (matched == t.Length)
                    {
                        int start = queue.Peek();
                        if (i - start + 1 < minLength)
                        {
                            minStart = start;
                            minLength = i - start + 1;
                        }
                        char removed = s[queue.Dequeue()];
                        freq[removed]++;
                        matched--;
                    }
                }
            }

            return minLength == int.MaxValue ? "" : s.Substring(minStart, minLength);
        }

        // Time Complexity: O(S)
        // Space Complexity: O(T)
        public string MinWindow_Pyhton_toGPT(string s, string t)
        {
            // Creating a dictionary to store the character frequency of string t
            var counts = new Dictionary<char, int>();
            foreach (var c in t)
            {
                if (!counts.ContainsKey(c))
                {
                    counts[c] = 1;
                }
                else
                {
                    counts[c]++;
                }
            }

            var minWindow = new int[] { 0, s.Length + 1 };
            var windowStart = 0;
            var match = 0;

            // Expanding the window and shrinking the window to find the smallest
            // substring that contains all characters of t
            for (var windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                if (counts.ContainsKey(s[windowEnd]))
                {
                    counts[s[windowEnd]]--;
                    if (counts[s[windowEnd]] == 0)
                    {
                        match++;
                    }
                }

                while (match == counts.Count) // was while (match >= counts.Count)
                {
                    var curWindowSize = windowEnd - windowStart + 1;
                    if (curWindowSize < minWindow[1] - minWindow[0])
                    {
                        minWindow = new int[] { windowStart, windowEnd + 1 };
                    }

                    if (counts.ContainsKey(s[windowStart]))
                    {
                        if (counts[s[windowStart]] == 0)
                        {
                            match--;
                        }
                        counts[s[windowStart]]++;
                    }
                    windowStart++;
                }
            }

            if (minWindow[1] > s.Length)
            {
                return "";
            }
            return s.Substring(minWindow[0], minWindow[1] - minWindow[0]);
        }



        public string MinWindow_SeanPrashad(string s, string t)
        {
            if (t == null || s.Length < t.Length)
            {
                return "";
            }

            Dictionary<char, int> hm = new Dictionary<char, int>();

            foreach (char c in t)
            {
                if (hm.ContainsKey(c))
                {
                    hm[c]++;
                }
                else
                {
                    hm.Add(c, 1);
                }
            }

            int start = 0, end = 0, minLen = int.MaxValue, counter = hm.Count;
            string ans = "";

            while (end < s.Length)
            {
                char eCh = s[end];

                if (hm.ContainsKey(eCh))
                {
                    int cnt = hm[eCh];
                    hm[eCh] = --cnt;

                    if (cnt == 0)
                    {
                        --counter;
                    }
                }

                end++;

                while (counter == 0)
                {
                    if (minLen > end - start)
                    {
                        minLen = end - start;
                        ans = s.Substring(start, end - start);
                    }

                    char sCh = s[start];

                    if (hm.ContainsKey(sCh))
                    {
                        int cnt = hm[sCh];
                        hm[sCh] = ++cnt;

                        if (cnt > 0)
                        {
                            ++counter;
                        }
                    }

                    start++;
                }
            }

            return ans;
        } 
        #endregion
    }
}
