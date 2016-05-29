//Description
//Write a program that enters a number N and after that enters more N numbers
//and calculates and prints their sum.
//Note: You may need to use a for-loop.
//Input
//On the first line, you will receive the number N
//On each of the next N lines, you will receive a floating-point number
//Output
//On must output only one number - the sum of the N numbers

using System;

class SymOfNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double sum = 0.0;

        for (int i = 0; i < number; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}

