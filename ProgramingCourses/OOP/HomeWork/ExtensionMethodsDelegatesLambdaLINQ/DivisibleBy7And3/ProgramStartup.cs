namespace DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProgramStartup
    {
        public static void Main()
        {
            var array = new int[] { 34, 21, 49, 42, 63, 84, 11, 7 };
            // with lamba extension
            var result = array.Where(n => n % 7 == 0 && n % 3 == 0);
            Console.WriteLine(string.Join(", ", result));
            // with LINQ extension
            var secondResult =
                from number in array
                where number % 3 == 0 && number % 7 == 0
                select number;
            Console.WriteLine(string.Join(", ", secondResult));
        }
    }
}
