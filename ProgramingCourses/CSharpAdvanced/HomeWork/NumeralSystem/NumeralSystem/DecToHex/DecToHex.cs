namespace DecToHex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DecToHex
    {
        static void Main()
        {
            var number =long.Parse(Console.ReadLine());
            var hexNumber = number.ToString("X");
            Console.WriteLine(hexNumber);
        }
    }
}
