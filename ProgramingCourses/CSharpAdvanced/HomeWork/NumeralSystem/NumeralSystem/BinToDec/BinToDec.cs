namespace BinToDec
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BinToDec
    {
        static void Main()
        {
            var binaryNumber = Console.ReadLine();
            var number = Convert.ToInt64(binaryNumber, 2);
            Console.WriteLine(number);
        }
    }
}
