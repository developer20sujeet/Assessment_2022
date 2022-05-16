using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Assessment.String
{
   public class clsRemoveDuplicateExceptVowels
    {
        public static string RemoveDuplicateExceptVowels(string input)
        {
            string result = "";
            if (input == null)
                return "";
            for (int i = 0; i < input.Length; i++)
            {
                char val = input[i];

                if(IsVowels(val))
                {
                    result = result + val;
                }
                else
                {
                    if( !result.Contains(val))
                    {
                        result = result + val;
                    }
                }
            }
            return result;
        }
        private static bool IsVowels(char val)
        {
            return  (val == 'a' || val == 'e' || val == 'i' || val == 'o' || val == 'u') ;
        }
    }
}
