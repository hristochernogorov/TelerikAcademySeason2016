//Description
//Write a program that reads two positive integer numbers N and M
//and prints how many numbers exist between them such that the reminder of the division by 5 is 0.
//Input
//On the first two lines you will receive two integers - N on the first and M on the second.
//Output
//Output a single value - the amount of numbers divisible by 5 without remainder.

using System;

    class Interval
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = N; i <= M; i++)
        {
            if (N<i && i<M)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);

    }
}

