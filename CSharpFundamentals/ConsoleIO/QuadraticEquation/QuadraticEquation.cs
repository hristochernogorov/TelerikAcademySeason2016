//Description
//Write a program that reads the coefficients a, b and c of a quadratic
//equation ax2 + bx + c = 0 and solves it(prints its real roots).
//Input
//On the first three lines, you will receive the coefficients a, b, and c, each on
//a separate line in the same order
//Output
//If two different real roots exist, print them on two separate lines
//Print the smaller root on the first line
//If only one real root exists, print it on the only output line
//If no real root exists, print the string "no real roots"
//The roots, should they exist, must be printed with precision exactly two digits 
//after the floating point

using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double sqrtpart = b * b - 4 * a * c;
        double x, x1, x2;
        if (sqrtpart > 0)
        {
            x1 = (-b - Math.Sqrt(sqrtpart)) / (2 * a);
            x2 = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
            if (x1<=x2)
            {
                Console.WriteLine("{0:F2}\n{1:F2}", x1, x2);
            }
            else 
            {
                Console.WriteLine("{0:F2}\n{1:F2}", x2, x1);
            }

        }
        else if (sqrtpart == 0 )
        {
            x = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("{0:F2}", x);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}


