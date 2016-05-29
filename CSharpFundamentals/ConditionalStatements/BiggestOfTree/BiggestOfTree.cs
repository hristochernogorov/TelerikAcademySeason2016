//Description
//Write a program that finds the biggest of three numbers that are read from the console.
//Input
//On the first three lines you will receive the three numbers, each on a separate line.
//Output
//On the only output line, write the biggest of the three numbers.

using System;

class BiggestOfTree
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());
        double result = Math.Max(firstNum, secondNum);
        result = Math.Max(result, thirdNum);

        Console.WriteLine(result);

    }
}

