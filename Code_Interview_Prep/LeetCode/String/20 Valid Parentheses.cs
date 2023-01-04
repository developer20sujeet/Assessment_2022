using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.String
{
    class _20_Valid_Parentheses
    {
        //https://leetcode.com/problems/valid-parentheses/
        /// <summary>
        /// Runtime: 73 ms, faster than 84.60% of C# online submissions for Valid Parentheses.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsValid(string input)
        {
            Stack<char> buffer = new Stack<char>();
            bool isValid = true;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '(':
                    case '{':
                    case '[':
                        // if opening bracket, just add it to the stack
                        buffer.Push(input[i]);
                        break;
                    case ')':
                        // if the stack has elements, pop the top; if matches the closing continue to next char; if doesn't match, it's not - the parenthesis are not matching
                        isValid = buffer.Count > 0 && buffer.Pop() == '(';
                        break;
                    case '}':
                        // if the stack has elements, pop the top; if matches the closing continue to next char; if doesn't match, it's not - the parenthesis are not matching
                        isValid = buffer.Count > 0 && buffer.Pop() == '{';
                        break;
                    case ']':
                        // if the stack has elements, pop the top; if matches the closing continue to next char; if doesn't match, it's not - the parenthesis are not matching
                        isValid = buffer.Count > 0 && buffer.Pop() == '[';
                        break;
                    default:
                        break;
                }
                if (!isValid) break; // if found non-matching brackets already, just leave
            }
            return isValid && buffer.Count == 0; // all brackets were found and there are no pending brackets in the stack
        }
    }
}
