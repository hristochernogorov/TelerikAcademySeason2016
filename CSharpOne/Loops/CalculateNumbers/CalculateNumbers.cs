//Write a program that, for a given two integer numbers N and x, calculates
//the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.
//Use only one loop.Print the result with 5 digits after the decimal point.
//Input
//On the first line you will receive one number - N.
//On the second line you will receive another number - x.
//Output
//Output only one number - the sum of the sequence for the given N and x.

using System;

class CalculateNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double factorialN = 1;
        double numXPowerN = 1;
        double sumOfSequence = 1;
        for (int i = 1; i <= N; i++)
        {
            factorialN *= i;
            numXPowerN *= x;
            sumOfSequence += (factorialN / numXPowerN);
        }
        Console.WriteLine("{0:F5} ",
            sumOfSequence);

    }
}

