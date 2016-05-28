namespace SquareRoot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SquareRoot
    {

       public static double squareRoot;
        static double SquareOfNumber(int number)
        {
            squareRoot = Math.Sqrt(number);
            return squareRoot;
        }
        static void Main()
        {
           
            try
            {
                var number = int.Parse(Console.ReadLine());
                SquareOfNumber(number);
                Console.WriteLine("{0:F3}", squareRoot);
                Console.WriteLine("Good bye");

            }
            catch
            {
                Console.WriteLine("Invalid number");
                Console.WriteLine("Good bye");

            }

        }
    }
}
