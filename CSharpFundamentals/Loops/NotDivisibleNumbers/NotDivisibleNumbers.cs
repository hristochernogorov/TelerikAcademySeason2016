﻿//Write a program that reads from the console a positive integer N and prints all the numbers
//from 1 to N not divisible by 3 or 7, on a single line, separated by a space.
//Input
//Will always consists of one valid integer number - the number N.
//Output
//Should always consists of the numbers from 1 to N, which are not divisible by 3 or 7,
//separated by a whitespace.

using System;

class NotDivisibleNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}

