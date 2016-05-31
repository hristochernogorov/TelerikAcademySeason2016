namespace BinToHex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BinToHex
    {
        static void Main()
        {
            var binNumber = Console.ReadLine();
            var hexNumber = Convert.ToUInt64(binNumber, 2).ToString("X");
            Console.WriteLine(hexNumber);
        }
    }
}
