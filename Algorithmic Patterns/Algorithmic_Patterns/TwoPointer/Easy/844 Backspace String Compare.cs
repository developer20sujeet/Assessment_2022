using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithmic_Patterns.TwoPointer.Easy
{
    /*
     
        Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.

        Note that after backspacing an empty text, the text will continue empty.

 

        Example 1:

        Input: s = "ab#c", t = "ad#c"
        Output: true
        Explanation: Both s and t become "ac".
        Example 2:

        Input: s = "ab##", t = "c#d#"
        Output: true
        Explanation: Both s and t become "".
     */
    internal class _844_Backspace_String_Compare
    {      

        public bool BackspaceCompare(string s, string t)
        {
            int i = s.Length - 1, j = t.Length - 1, sCounter = 0, tCounter = 0;

            while (i >= 0 || j >= 0)
            {

                while (i >= 0 && (s[i] == '#' || sCounter > 0))
                {

                    if (s[i] == '#') ++sCounter;
                    else --sCounter;
                    --i;
                }

                while (j >= 0 && (t[j] == '#' || tCounter > 0))
                {
                    if (t[j] == '#') ++tCounter;
                    else --tCounter;
                    --j;
                }

                if (i >= 0 && j >= 0 && s[i] == t[j])
                {
                    --i;
                    --j;
                }
                else
                {
                    break;
                }
            }

            return i < 0 && j < 0;
        }

        #region Final Solution - second best 

        /// <summary>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// Algorithm used: Two Pointer
        /// Algorithmic coding pattern: Two Pointer
        /// Data structure used: String
        /// Company name: Commonly asked in various companies
        /// Important Tips and Tricks: Handle backspace counts for each string independently.
        /// Lessons Learned: Always consider edge cases where one string may end before the other.
        /// 
        /// Centrail Idea 
        ///     1. traverse from the end : The effect of backspaces can be easily accounted for by traversing from the end.
        ///     2. 
        /// </summary>
        public bool BackspaceCompareV2(string S, string T)
        {
            // Step 1: Initialize pointers and backspace counters for each string
            // Reason: We will traverse each string from right to left, accounting for backspaces.
            int pointerS = S.Length - 1;
            int pointerT = T.Length - 1;


            int backspaceCountS = 0, backspaceCountT = 0;

            // Step 2: Start comparing the strings from the end
            // Reason: The effect of backspaces can be easily accounted for by traversing from the end.
            while (pointerS >= 0 || pointerT >= 0)
            {
                // Step 2.1: Move the pointerS position, accounting for backspaces in string S
                // Reason: To find the next valid character in string S after applying backspaces.
                // (S[pointerS] == '#' || backspaceCountS > 0) : both because to increments and decrements -backspaceCountS
                // If backspaceCountS > 0, it means we need to apply a backspace, skipping the current character and decrementing backspaceCountS.
                while (pointerS >= 0 && (S[pointerS] == '#' || backspaceCountS > 0))
                {
                    if (S[pointerS] == '#')
                        backspaceCountS++;
                    else
                        backspaceCountS--;

                    pointerS--;
                }

                // Step 2.2: Move the pointerT position, accounting for backspaces in string T
                // Reason: To find the next valid character in string T after applying backspaces.
                while (pointerT >= 0 && (T[pointerT] == '#' || backspaceCountT > 0))
                {
                    if (T[pointerT] == '#') backspaceCountT++; else backspaceCountT--;
                    pointerT--;
                }


                // Step 2.3: Compare the valid characters found in both strings
                // Reason: If the valid characters differ, then the strings are not equivalent.
                //          For S[pointerS] != T[pointerT]:
                //              At this point in the code, these pointers should be at valid characters, as they have already been adjusted for any backspace ('#') characters.
                //              This comparison is crucial for the algorithm because it quickly identifies if the two strings can be the same after applying the backspaces
                // Test this condition on S = ("a#b", "a#c") or  
                if (pointerS >= 0 && pointerT >= 0 && S[pointerS] != T[pointerT])
                    return false;


                // Step 2.4: Check if one pointer is out of bounds while the other is not
                // Reason: This implies one string has additional valid characters, making the strings unequal.
                //          If one string is 'used up' and the other still has characters left to consider, then the two strings cannot be the same.
                //          This condition checks if one of the strings has reached its beginning while the other has not
                // Test this condition on  :S = "a##"  T = "a#b"
                // One String Ended, the Other Didn't
                if ((pointerS >= 0) != (pointerT >= 0))
                    return false;

                // Step 2.5: Move both pointers one position backwards for the next iteration
                // Reason: Prepares for the next round of comparison.
                // Helping input : Needed if input is such as - S = "ab#c" && T = "ad#c"
                pointerS--;// 
                pointerT--;
            }

            // Step 3: Return true as all valid characters matched
            // Reason: If we've exited the loop, it means all comparisons were successful.
            return true;
        }
        #endregion

        #region Option 2 and way 2 to do 
        /// <summary>
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// Algorithm used: Two Pointer
        /// Algorithmic coding pattern: Two Pointer
        /// Data structure used: String
        /// Company name: Commonly asked in various companies
        /// </summary>
        public bool BackspaceCompare_Way2(string S, string T)
        {
            // Step 1: Initialize pointers for both strings
            // Reason: We need two pointers to traverse both strings from the end towards the beginning. 
            //         This allows us to take into account the effect of backspace characters.
            int pointerS = S.Length - 1;
            int pointerT = T.Length - 1;

            // Step 2: Loop until pointers are within range
            // Reason: To continue the comparison until all characters are processed. 
            //         This allows us to determine if the strings are equivalent after applying the backspace effect.
            while (pointerS >= 0 || pointerT >= 0)
            {
                // Step 2.1: Move pointers based on backspace character '#' for S
                // Reason: To find the next character in S that has not been erased by backspaces. 
                //         This ensures that only the characters that remain after applying backspaces are compared.
                pointerS = MovePointer(S, pointerS);

                // Step 2.2: Move pointers based on backspace character '#' for T
                // Reason: To find the next character in T that has not been erased by backspaces. 
                //         This mirrors the movement of pointerS for a consistent comparison.
                pointerT = MovePointer(T, pointerT);

                // Step 2.3: Compare characters if pointers are in range
                // Reason: To compare the non-erased characters in both strings. 
                //         If they don't match at any point, the strings are not equivalent.
                if (pointerS >= 0 && pointerT >= 0 && S[pointerS] != T[pointerT])
                    return false;

                // Step 2.4: If one pointer is out of range and the other is not, strings do not match
                // Reason: It means one string has remaining non-erased characters, while the other does not. 
                //         This indicates that the strings are not equivalent.
                if ((pointerS >= 0) != (pointerT >= 0))
                    return false;

                pointerS--; // Move to the previous character in S
                pointerT--; // Move to the previous character in T
            }

            // Step 3: Return true if strings match after applying backspaces
            // Reason: All non-erased characters have been compared and match. 
            //         This confirms that the strings are equivalent after accounting for backspaces.
            return true;
        }

        /// <summary>
        /// Helper function to move the pointer based on backspace character '#'
        /// </summary>
        private int MovePointer(string str, int pointer)
        {
            // Step 1: Keep track of the number of backspaces to apply
            // Reason: We need to keep track of consecutive backspaces.
            int backspaceCount = 0;

            // Step 2: Loop through the string, applying backspaces and finding the next valid character to compare
            // Reason: Continue moving the pointer to the left until a valid character to compare is found.
            // backspaceCount > 0- This condition checks if there are any backspace characters left to be applied. If the backspace count is greater than 0, it means there are characters to be erased, and this condition evaluates to true
            while (pointer >= 0 && (str[pointer] == '#' || backspaceCount > 0))
            {
                // Step 2.1: Handle backspace characters and normal characters
                // Reason: Increment the backspace count if a backspace character is found. Decrement the count if a normal character is found, as it would be erased.
                if (str[pointer] == '#') backspaceCount++; else backspaceCount--;

                // Step 2.2: Move to the previous character
                // Reason: Move the pointer to the preceding character to continue the search for the next valid character.
                pointer--;
            }

            // Step 3: Return the updated pointer position after applying backspaces
            // Reason: Returns the valid character's position or -1 if all characters were skipped, allowing the comparison to proceed.
            return pointer;
        }


        #endregion


        #region BackspaceCompare_stackWay

        /// <summary>
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// Algorithm used: Stack
        /// Algorithmic coding pattern: Stack
        /// Data structure used: Stack
        /// Company name: Commonly asked in various companies
        /// </summary>
        public bool BackspaceCompare_stackWay(string S, string T)
        {
            // Step 1: Process both strings with backspaces
            string processedS = ProcessString(S);
            string processedT = ProcessString(T);

            // Step 2: Compare the processed strings
            return processedS == processedT;
        }

        /// <summary>
        /// Helper function to process the string with backspaces
        /// </summary>
        private string ProcessString(string str)
        {
            // Step 1: Initialize a stack to hold characters
            Stack<char> stack = new Stack<char>();

            // Step 2: Iterate through the string
            for (int i = 0; i < str.Length; i++)
            {
                // Step 2.1: Push character into stack if it's not a backspace
                if (str[i] != '#')
                {
                    stack.Push(str[i]);
                }
                // Step 2.2: Pop character from stack if it's a backspace and stack is not empty
                else if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            // Step 3: Return the processed string
            return new string(stack.ToArray().Reverse().ToArray());
        }

        #endregion

    }
}