
using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace LeetCode.Number
{
    internal class _7_Reverse_Integer
    {
        /// <summary>
        /// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Reverse(int x)
        {
            try
            {
                var sign = Math.Sign(x);
                x = Math.Abs(x);

                StringBuilder sb = new StringBuilder();

                for (int i = x.ToString().Length - 1; i >= 0; i--)
                {
                    sb.Append(x.ToString()[i]);

                }


                return checked(int.Parse(sb.ToString()) * sign);
            }
            catch (Exception e)
            {
                return 0;
            }

        }
    }
}

