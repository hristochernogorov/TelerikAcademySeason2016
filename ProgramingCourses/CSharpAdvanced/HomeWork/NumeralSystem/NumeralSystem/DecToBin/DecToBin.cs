namespace DecToBin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DecToBin
    {
        static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var binary = Convert.ToString(number, 2);
            Console.WriteLine(binary);
        }
    }
}
