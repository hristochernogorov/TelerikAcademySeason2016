//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the Nth Catalan number by given N
//Input
//On the only line, you will receive the number N
//Output
//Output a single number - the Nth Catalan number

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factN = 1;
        BigInteger factPlus = 1;
        BigInteger factProductN = 1;
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            factN *= i;
        }
        for (int j = 1; j <= n+1; j++)
        {
            factPlus *= j;
        }
        for (int k = 1; k <= 2*n; k++)
        {
            factProductN *= k;
        }
        result = (factProductN / (factPlus * factN));
        Console.WriteLine(result);
    }
}

