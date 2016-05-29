//Write a program that calculates the greatest common divisor(GCD) of given two integers A and B.
//Use the Euclidean algorithm(find it in Internet).
//Input
//On the first and only line of the input you will receive the 2 integers A and B,
//separated by a whitespace.
//Output
//Output a single number - the GCD of the numbers A and B.

using System;

class GCD
{

    static int GCDAlgorithm(int a, int b)
    {
        int remainder;
        while (b != 0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }
    static void Main()
    {
        string  number = Console.ReadLine() ;
        string [] numbers = number.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int x;
        int y;
        x = int.Parse(numbers[0]);
        y = int.Parse(numbers[1]);
        Console.WriteLine("{0}", GCDAlgorithm(x, y));
    }
}

