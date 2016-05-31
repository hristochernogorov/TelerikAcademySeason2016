namespace HexToBin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class HexToBin
    {
        static void Main()
        {
            var hexNumber = Console.ReadLine();
            var binNumber = Convert.ToString(Convert.ToInt64(hexNumber, 16), 2);
            Console.WriteLine(binNumber);
        }
    }
}
