using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.String
{
    public class ClsString
    {

        //https://www.interviewbit.com/c-sharp-interview-questions/#reverse-a-string-in-csharp

        #region ReverseString
        public static void ReverseString_m2(string str)
        {

            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
        public static void ReverseString_m1(string str)
        {

            char[] charArray = str.ToCharArray();

            char[] Temp = new char[charArray.Length];

            int counter = charArray.Length;

            for (int i = 0; i < charArray.Length; i++)
            {
                counter--;
                Temp[i] = charArray[counter];

            }
            string reversedstring = new string(Temp);
            Console.WriteLine(reversedstring);
        }

        public static void ReverseString_m3(string input)
        {
            string str = input, nstr = "";
            char ch;

            for (int i = 0; i < str.Length; i++)
            {
                ch = str[i]; //extracts each character
                nstr = ch + nstr; //adds each character in front of the existing string
            }
            Console.WriteLine("Reversed word: " + nstr);
        }


        public static string Reverse(string input, int index)
        {
            char[] inputChar = input.ToCharArray();
            int len = inputChar.Length;
            if (index > len / 2)
            {
                char c = inputChar[index];
                inputChar[index] = inputChar[len - index - 1];
                inputChar[len - index - 1] = c;
                index--;
                return Reverse(new string(inputChar), index);
            }
            else
            {
                return new string(inputChar);
            }


        }
        #endregion


        //Input = "Sujeet"
        //output = S Su Suj Suje Sujee Sujeet
        internal static void findallsubstring(string str)
        {
            StringBuilder subString = new StringBuilder();

            for (int j = 0; j < str.Length; j++)
            {
                subString.Append(str[j]);
                Console.Write(subString + " ");
            }

        }
    }
}
