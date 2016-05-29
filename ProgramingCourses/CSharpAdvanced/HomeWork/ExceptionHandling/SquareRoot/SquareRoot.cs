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
        static double SquareOfNumber(double number)
        {
            squareRoot = Math.Sqrt(number);
            return squareRoot;
        }
        static void Main()
        {

            try
            {
                var number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new FormatException();
                }
                SquareOfNumber(number);
                Console.WriteLine("{0:F3}", squareRoot);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
