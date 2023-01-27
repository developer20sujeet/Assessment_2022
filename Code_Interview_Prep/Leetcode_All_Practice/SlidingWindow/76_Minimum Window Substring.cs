using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_All_Practice.SlidingWindow
{
    internal class _76_Minimum_Window_Substring
    {

        public string MinWindow(string s, string t)
        {
            if (t.Length > s.Length)
            {
                return "";
            }

            // Make a frequency map of t - the string that need to be searched 
            Dictionary<char, int > dict_t = new Dictionary<char, int>();
            foreach (var item in t)
            {
                if (dict_t.ContainsKey(item))
                {
                    dict_t[item]++;
                }
                else
                {
                    dict_t[item] = 1;

                }
            }

            int match = 0;
            int minLeanth = int.MaxValue;
            int windowStart = 0;
            int minStart=0;
            

            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                // check if s string chracter exist in t frequecy map
                if (dict_t.ContainsKey(s[windowEnd]))
                {
                    dict_t[s[windowEnd]]--;

                    // s string has all character in t frequency map
                    if(dict_t[s[windowEnd]]==0)
                    {
                        // we found match
                        match++; 

                    }
                }

                // we found one eligible match 
                if(match == dict_t.Count)
                {

                    // used to return substring 
                    if( windowEnd-windowStart+1 < minLeanth)
                    {
                        minLeanth = windowEnd - windowStart + 1;
                        minStart= windowStart;
                    }


                    if (dict_t.ContainsKey(s[windowStart]))
                    {
                        // time to shrink 
                        if (dict_t[s[windowStart]] == 0)
                        {
                            match--;
                            
                        }
                        dict_t[s[windowStart]]++;
                    }
                    windowStart++;

                }


            }

            if (minLeanth == int.MaxValue)
                return "";

            return s.Substring(minStart, minLeanth);


        }
    }
}
