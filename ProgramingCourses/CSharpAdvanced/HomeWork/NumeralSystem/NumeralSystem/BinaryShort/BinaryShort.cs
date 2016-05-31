namespace BinaryShort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BinaryShort
    {
        static void Main()
        {
            var number = short.Parse(Console.ReadLine());
            var binNumber = Convert.ToString(number, 2).PadLeft(16,'0');
            Console.WriteLine(binNumber);

        }
    }
}
