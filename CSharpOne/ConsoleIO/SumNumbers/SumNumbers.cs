//Write a program that reads 3 real numbers from the console and prints their sum.
//Input
//On the first line, you will receive the number a
//On the second line, you will receive the number b
//On the third line, you will receive the number c
//Output
//Your output should consist only of a single line - the sum of the three numbers.

using System;

class SumNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine(sum);
    }
}

