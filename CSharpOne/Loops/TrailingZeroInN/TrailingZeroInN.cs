//Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
//Your program should work well for very big numbers, e.g.N = 100000.
//Input
//On the only input line, you will receive a single integer - the number N
//Output
//Output a single number - the count of trailing zeroes for the N!

using System;
using System.Numerics;


class TrailingZeroInN
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int zeroCount = 1;
        int zero = 0;
        while (number / Math.Pow(5, zeroCount) >= 1)
        {
            zero += number / (int)(Math.Pow(5, zeroCount));
            zeroCount++;
        }
        Console.WriteLine(zero);
    }
}

