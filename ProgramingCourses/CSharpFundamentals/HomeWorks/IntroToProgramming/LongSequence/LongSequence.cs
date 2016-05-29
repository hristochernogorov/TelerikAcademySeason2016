using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongSequence
{
    class LongSequence
    {
        static void Main()
        {
            int i;
            int j = 1;
            for (i = 0; i < 999; i += 2, j += 2, Console.WriteLine("{0}\n{1}", i, -j)) ;
        }
    }
}
