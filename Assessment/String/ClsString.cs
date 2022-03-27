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
