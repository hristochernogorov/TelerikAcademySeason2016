namespace UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class UnicodeCharacters
    {
        static string UnicodeString(string text)
        {
            return Encoding.UTF8.GetString(Encoding.ASCII.GetBytes(text));
        }
        static void Main()
        {
           
            var input = Console.ReadLine().Split().ToArray();
            var array = new string[input.Length];

            
            for (int i = 0; i < input.Length; i++)
            {

                Console.Write(UnicodeString(input[i]));
            }
            Console.WriteLine();

        }
    }
}
