using System;
using System.Threading;

namespace Age
{
    class Age
    {
        static void Main()
        {
           
            DateTime birthDay = DateTime.Parse(Console.ReadLine());

            int years = DateTime.Now.Year - birthDay.Year;

            if (DateTime.Now.Month < birthDay.Month)
            {
                Console.WriteLine(years - 1);
                int firstAge = years - 1;
                Console.WriteLine(firstAge + 10);
            }
            else
            {
                Console.WriteLine( years);
                Console.WriteLine(years + 10);
            }
        }
    }
}
