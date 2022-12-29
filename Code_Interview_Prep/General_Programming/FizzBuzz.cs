using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Programming
{
    /// <summary>
    /// https://algolab.so/courses/algorithms-and-data-structure-video-course/lectures/43998975
    /// </summary>
    internal class FizzBuzz
    {

        static string[] GetFizzBuzzArray(int n)
        {
            List<string> result = new List<string>();
            
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result.ToArray();
        }
    }
}
