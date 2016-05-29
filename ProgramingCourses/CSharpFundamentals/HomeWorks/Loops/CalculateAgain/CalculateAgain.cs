//Write a program that calculates N! / K! for given N and K.
//Use only one loop.
//Input
//On the first line, there will be only one number - N
//On the second line, there will be only one number - K
//Output
//Output a single line, consisting of the result from the calculation described above.

using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        BigInteger facturialN = 1;
        BigInteger facturialK = 1;
        BigInteger result = 1;
        for (int i = 1, j = 1; i <= N;j++, i++)
        {
            facturialN *= i;
            if (j <= K)
            {
                facturialK *= j;
            }
            
        }

        result = facturialN / facturialK;
        Console.WriteLine(result);
    }
}

