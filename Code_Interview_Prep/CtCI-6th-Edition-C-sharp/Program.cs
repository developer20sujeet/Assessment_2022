using System;
using System.Linq;

namespace CtCI_6th_Edition_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //CtCI_6th_Edition_C_sharp.Q1_02_Check_Permutation.QuestionA.driver();

            //string s2 = "eidboaoo";
            //string s1 = "ab";

            char a = 'a';

            int a1 = a;

            char aa = (char)a1;

            bool s = CheckInclusion("ab", "eidbaoo");
           

        }

       
        public static string sort(string s1)
        {
            char[] arr1 = s1.ToCharArray();
            System.Array.Sort(arr1);

            return new string(arr1);
        }
        public static bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            int[] s1Hash = new int[26];
            int[] s2Hash = new int[26];

            for (int i = 0; i < s1.Length; i++)
            {
                s1Hash[s1[i] - 97]++;
                s2Hash[s2[i] - 97]++;
            }

            if (s1Hash.SequenceEqual(s2Hash))
                return true;
            for (int i = s1.Length; i < s2.Length; i++)
            {
                s2Hash[s2[i] - 97]++;
                s2Hash[s2[i - s1.Length] - 97]--;

                if (s1Hash.SequenceEqual(s2Hash))
                    return true;
            }
            return false;
        }
    }
}
