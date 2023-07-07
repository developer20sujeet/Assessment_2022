global using RercusrionBasedProblem;

namespace RercusrionBasedProblem
{
    public class Factorial
    {
        /// <summary>
        /// Visualization of code 
        /// FactorialNumber(4)
              //-> 4 * FactorialNumber(3)
              //      -> 3 * FactorialNumber(2)
              //            -> 2 * FactorialNumber(1)
              //                  -> 1 * FactorialNumber(0)
              //                        -> returns 1
              //                  -> returns 1 * 1 = 1
              //            -> returns 2 * 1 = 2
              //      -> returns 3 * 2 = 6
              //-> returns 4 * 6 = 24
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int FactorialNumber(int num) {

            // base case of 0
            if (num == 0)
            {
                return 1;
            }

            return num * FactorialNumber(num - 1);
        }

    }
}
