using System;
using System.Collections.Generic;
using System.Text;

namespace CtCI_6th_Edition_C_sharp.Ch_01._Arrays_and_Strings.Q1_01_Is_Unique
{
    public class QuestionA
    {

        // string has all unique charater 
        public static bool isUniqueChars(string str)
        {
            // 128 checking because ASCII table has total 128 character and any string can have charcater from  128 only
            if (str.Length > 128)
            {
                return false;
            }

            bool[] char_set = new bool[128];

            for (int i = 0; i < str.Length; i++)
            {
                // take descimal value from string character 
                int val = str[i];

                // if that decimal value already true in array then  string charcater is not unique
                if (char_set[val])
                {
                    return false;
                }

                // step 1 se charcater decimal to true so that when 
                char_set[val] = true;
            }

            return true;
        }

        public static void driver()
        {
            string[] words = { "abcde", "hello", "apple", "kite", "padle" };

            foreach (string word in words)
            {
                Console.WriteLine(word + ": " + isUniqueChars(word));
            }
        }
    }
}
