using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.HashSet
{


    internal class _1832_Check_if_the_Sentence_Is_Pangram
    {
        public bool CheckIfPangram(string sentence)
        {

            // Create a set to store unique characters
            //if the goal is simply to check for the presence of duplicate elements in the array, using a HashSet<int> is more appropriate and efficient
            //Using a HashSet reduces the memory overhead compared to using a dictionary because it only stores the unique elements without any associated values.

            HashSet<char> seen = new HashSet<char>();

            // Convert sentence to lowercase and iterate over each character
            foreach (char currChar in sentence.ToLower().ToCharArray())
            {
                if (char.IsLetter(currChar))
                {
                    // Add the character to set
                    seen.Add(currChar);
                }
            }

            // Return true if set size is 26 (total number of alphabets)
            return seen.Count == 26;
        }
    }
}
