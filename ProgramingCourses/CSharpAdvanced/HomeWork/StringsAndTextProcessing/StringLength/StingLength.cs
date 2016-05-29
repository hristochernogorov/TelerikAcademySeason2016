namespace StringLength
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StingLength
    {
        static void Main()
        {
            var input = Console.ReadLine();
            input = input.Replace(@"\", string.Empty);
            Console.WriteLine(input.PadRight(20,'*'));
         
        }
    }
}
