//Description
//Write a program that reads a number N and prints on the console the first N members 
//of the Fibonacci sequence(at a single line, separated by comma and space - ", ") :
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Input
//On the only line you will receive the number N
//Output
//On the only line you should print the first N numbers of the sequence,
//separated by ", " (comma and space)


using System;

class FibonacciNumbers
{
    static void Main()
    {
        long left = -1;
        long right = 1;
        int fibonacciSequence;
        fibonacciSequence = int.Parse(Console.ReadLine());
        for (int i = 0; i < fibonacciSequence; i++)
        {

            long middle = right + left;
            left = right;
            right = middle;
            if (i == fibonacciSequence - 1)
            {
                Console.WriteLine(right);
            }
            else
            {
                Console.Write(right + ", ");
            }
        }

        Console.WriteLine();
    }
}



