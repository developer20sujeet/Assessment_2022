using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace String_Simple_Operation
{
    internal class StringMathOperation
    {

        public static void Get_ASCIINumeric_value_of_character()
        {
            // way 1 
            char chr = 'A';

            int charNumericValue = (int)chr;

            Console.WriteLine(charNumericValue);

            // way 2 




        }

        public static void Get_ASCIINumeric_value_of_string_using_Byte()
        {
            string str = "ABCDEFGHI";

            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(str);

            foreach (var value in ASCIIvalues)
            {
                Console.WriteLine(value);
            }

        }

        

        public static void Convert_ASCIINumeric_value_into_character()
        {
            int charNumericValue = 65;

            char chr = (char)charNumericValue;

            Console.WriteLine(chr);

        }

        public static void Convert_digit_character_into_respective_integer_value()
        {
            // example charcater 9 to numeric 9 

            //Way 1 - '0'
            char charValue = '9';

            //subtracting '0' from this character will give you the corresponding integer value.
            //value of '9' (which is 57 in ASCII) and subtract 48 (the ASCII value of '0') to get the value 9. 
            int intVal = (int)charValue - '0';

            Console.WriteLine(intVal);



            //way 2 - char GetNumericValue()
            //If the method is applied on a char variable with numeric value enclosed in single quotes, that number is returned, else -1 is returned.
            int result = (int)Char.GetNumericValue('9');
            Console.WriteLine(result); // Output: "8"
            Console.WriteLine(Char.GetNumericValue('X')); // Output: "-1"
            Console.WriteLine($"way2 - {result}");



            //way 3 //Convert.ToInt32() Method to Convert
            char c = '3';
            // Need to convert to string 
            Console.WriteLine(Convert.ToInt32(c.ToString())); // Output: "3"

            //If the char data type is passed as an argument into the Convert.Tolnt32() method, the ASCII equivalent is returned.
            Console.WriteLine(Convert.ToInt32(c)); // Output: "51"



            // way 4 -Int32.Parse()
            //Int32.Parse() method converts the string representation of a number to its 32-bit signed integer equivalent
            //The downside of this method is that a numeric value must be passed as the string argument.
            char c1 = '3';
            char s = 'x';
            string str = c1.ToString();
            string ex = s.ToString();

            Console.WriteLine(Int32.Parse(str));
            //Console.WriteLine(Int32.Parse(ex)); // Output: "ThrowEx"




        }

        public static void stringToInteger(string s)
        {
            //978
            double result = 0;

            //for (int i = 0; i < s.Length; i++)
            //{
            //    // why -1 = it is  because string is Zero-0 based but lenght give counting starting from 1 example - "235" - lenght =3 but programe think as 0,1,2 so max we can go is index 2 so -1 added
            //    // Why -i = doing -1 will give last character of string only but if we want each character from last so -i 
            //    // Why '0' = Convert_digit_character_into_respective_integer_value
            //    // Here we are getting numeric value from string starting from last 
            //    int NumberValue = s[s.Length - i - 1] - '0';

            //    // why Math.Pow = 
            //    result = result+ Math.Pow(10, i) * NumberValue;
            //}

            foreach (char c in s)
            {
                //multiply the previous number by 10 and add the current character's value as numeric 
                result = result * 10 + (c - '0');
            }

            Console.WriteLine(result);
        }
    
        public static void stringToChar_VisVersa()
        {
            string strVal = "katar";

            // to char 
            char[] arr = strVal.ToCharArray();


            // direct string to char 
            foreach (char c in strVal)
            {
                Console.WriteLine(c);
            }
        }
    
    }
}
