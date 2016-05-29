//Problem 13: Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
using System;

class ComparingFloads
{
    private static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secontNumber = double.Parse(Console.ReadLine());
        firstNumber = Math.Round(firstNumber, 6);
        secontNumber = Math.Round(secontNumber, 6);
        double equal = Math.Abs(firstNumber - secontNumber);
        if (equal < 0.000001)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}