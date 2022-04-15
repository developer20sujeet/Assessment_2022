using System;
using System.Collections.Generic;
using System.Text;

namespace CtCI_6th_Edition_C_sharp.Q1_02_Check_Permutation
{
    //A permutation of a string S iis another string that contains the same characters, 
    //only the order of characters can be different. For example, “abcd” and “dabc” are permutations of each other
    public class QuestionA
    {
        public static string sort(string s1)
        {
            char[] arr1 = s1.ToCharArray();
            System.Array.Sort(arr1);

            return new string(arr1);
        }
        public static bool permutation(string s1, string s2)
        {
            if (s1.Length != s1.Length) // Permutations must be same length
            return false;

            return sort(s1).Equals(sort(s2));
            
        }
        public static void driver()
        {
            bool a = permutation("apple", "papel");
            bool a1 = permutation("hello", "llloh");

            //string [][] pairs = { { "apple", "papel" }, { "carrot", "tarroc" }, { "hello", "llloh" } };

            //for (string[] pair : pairs)
            //{
            //    String word1 = pair[0];
            //    String word2 = pair[1];
            //    boolean anagram = permutation(word1, word2);
            //    System.out.println(word1 + ", " + word2 + ": " + anagram);
            //}
        }
    }
}
