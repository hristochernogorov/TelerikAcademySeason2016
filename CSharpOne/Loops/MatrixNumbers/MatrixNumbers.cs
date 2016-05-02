//Write a program that reads from the console a positive integer number N and 
//prints a matrix like in the examples below.Use two nested loops.
//Challenge: achieve the same effect without nested loops
//Input
//The input will always consist of a single line, which contains the number N
//Output
//See the examples.

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j <= n + i; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
     
        //for (int i = 0; i < n; i++)
        //{
        //    int j = i + 1;

        //    while (j <= n + i)
        //    {
        //        Console.Write(j + " ");
        //        j++;
               
        //    }
        //    Console.WriteLine();
            
        //}
        //Console.WriteLine();

    }
}

