using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            string word = Console.ReadLine();
            foreach (var letter in word)
            {
                Console.WriteLine(letter - 97);
            }
        }
    }
}
