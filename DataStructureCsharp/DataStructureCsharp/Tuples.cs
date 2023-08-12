using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCsharp
{
    internal class Tuples
    {

        public (int , int ) GetTuplesData()
        {

            (int, int) tuples = new(0,0);


            tuples.Item1= 15;
            tuples.Item2= 105;

            return tuples;
        }
    }
}
