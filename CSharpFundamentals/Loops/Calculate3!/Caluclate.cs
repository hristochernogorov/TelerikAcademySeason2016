//In combinatorics, the number of ways to choose N different members out of a group 
//of N different elements(also known as the number of combinations) is calculated 
//by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards 
//out of a standard deck of 52 cards.Your task is to write a program that 
//calculates N! / (K! * (N - K)!) for given N and K.
//Try to use only two loops.
//Input
//On the first line, there will be only one number - N
//On the second line, there will also be only one number - K
//Output
//On the only output line, write the result of the calculation for the provided N and K

using System;
using System.Numerics;
class Calculate

{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        BigInteger facturialN = 1;
        BigInteger facturialK = 1;
        BigInteger facturialBetweenNK = 1;
        BigInteger result = 1;
        for (int i = 1, j = 1; i <= N; j++, i++)
        {
            facturialN *= i;
            if (j <= K)
            {
                facturialK *= j;
            }
        }
        for (int i = 1; i <= N - K; i++)
        {
            facturialBetweenNK *= i;
        }
        // Formula result =  N! / (K!*(N - K)!) 
        result = facturialN / (facturialK * facturialBetweenNK);
        Console.WriteLine(result);
    }
}

