using System;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            int i;
            int j = 1;
            for (i = 0; i < 10; i += 2, j += 2, Console.WriteLine("{0}\n{1}", i, -j));
        }
    }
}
