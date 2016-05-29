namespace UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class UnicodeCharacters
    {

        static void Main()
        {

            var input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                string escape = "\\u" + ((int)input[i]).ToString("X").PadLeft(4, '0');
                Console.Write(escape);
            }
            Console.WriteLine();
        }
    }
}
