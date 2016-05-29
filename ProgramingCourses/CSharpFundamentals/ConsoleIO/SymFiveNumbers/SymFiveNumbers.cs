//Description
//Write a program that reads 5 integer numbers from the console and prints their sum.
//Input
//You will receive 5 numbers on five separate lines.
//Output
//Your output should consist only of a single line - the sum of the 5 numbers.

using System;
class Program
{
    static void Main()
    {
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            int[] array = new int[5];
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
        }
        Console.WriteLine(sum);
    }
}

