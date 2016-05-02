//Write a program that enters from the console a positive integer n and prints
//all the numbers from 1 to N inclusive, on a single line, separated by a whitespace.
//Input
//The input will consist of a single line - the number N
//Output
//The output should consist of a single line - the numbers from 1 to N, separated by a whitespace

using System;

class NumberOneToN
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.Write("{0} ",i);
        }
    }
}

