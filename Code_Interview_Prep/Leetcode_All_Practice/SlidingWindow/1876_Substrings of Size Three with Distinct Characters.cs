using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_All_Practice.SlidingWindow
{
    internal class _1876_Substrings_of_Size_Three_with_Distinct_Characters
    {
        public int CountGoodSubstrings(string s)
        {

            int slidingWindowSize = 3;

            if (s.Length < slidingWindowSize)
            {
                return 0;
            }

            Dictionary<char, int> dic = new Dictionary<char, int>();

            int windowStart = 0;
            int counter = 0;


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

                if (windowEnd >= slidingWindowSize - 1)
                {

                    if (dic.Count == slidingWindowSize)
                    {
                        counter++;
                    }

                    if (dic[s[windowStart]] == 1)
                    {
                        dic.Remove(s[windowStart]);
                    }
                    else
                    {
                        dic[s[windowStart]]--;
                    }

                    windowStart++;

                }

            }

            return counter;



        }
    }
}
