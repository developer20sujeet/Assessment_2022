using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Simple_Operation
{
    /*
     Note : 
      Equal - compare the value of a string
      
     * 
     */
    internal class SimpleStringOperation
    {
        /// <summary>
        ///  Output : 
        ///  Ordinal ignore case: <Sujeet> and <sujeet> are equal.
        ///  Ordinal static ignore case: <Sujeet> and<sujeet> are equal.
        ///  <Sujeet> and <sujeet> are equivalent in order
        /// </summary>
        public static void EqualOperation_OrdinalIgnoreCase()
        {

            string root = "Sujeet"; // upper case S
            string root2 = "sujeet";// lower case s

            //Ordinal Ignore Case
            bool result = root.Equals(root2, StringComparison.OrdinalIgnoreCase); // true 

            //Ordinal Ignore Case
            bool areEqual = String.Equals(root, root2, StringComparison.OrdinalIgnoreCase);// True 

            //Ordinal Ignore Case
            int comparison = String.Compare(root, root2, comparisonType: StringComparison.OrdinalIgnoreCase); //   value 0 -  Equal

            Console.WriteLine($"Ordinal ignore case: <{root}> and <{root2}> are {(result ? "equal." : "not equal.")}");

            Console.WriteLine($"Ordinal static ignore case: <{root}> and <{root2}> are {(areEqual ? "equal." : "not equal.")}");

            if (comparison < 0)
                Console.WriteLine($"<{root}> is less than <{root2}>");
            else if (comparison > 0)
                Console.WriteLine($"<{root}> is greater than <{root2}>");
            else
                Console.WriteLine($"<{root}> and <{root2}> are equivalent in order");


        }
        public static void EqualOperation_OrdinalNotIgnoreCase()
        {

            string root = "Sujeet"; // upper case S
            string root2 = "sujeet"; // lower case s

            //Ordinal Ignore Case
            bool result = root.Equals(root2); // true 

            //Ordinal Ignore Case
            bool areEqual = String.Equals(root, root2);// True 

            //Ordinal Ignore Case
            int comparison = String.Compare(root, root2); //   value 0 -  Equal

            Console.WriteLine($"Ordinal ignore case: <{root}> and <{root2}> are {(result ? "equal." : "not equal.")}");

            Console.WriteLine($"Ordinal static ignore case: <{root}> and <{root2}> are {(areEqual ? "equal." : "not equal.")}");

            if (comparison < 0)
                Console.WriteLine($"<{root}> is less than <{root2}>");
            else if (comparison > 0)
                Console.WriteLine($"<{root}> is greater than <{root2}>");
            else
                Console.WriteLine($"<{root}> and <{root2}> are equivalent in order");


        }

    }
}
