//Write a program that reads from the console a sequence of N integer numbers
//and returns the minimal, the maximal number, the sum and the average of all
//numbers(displayed with 2 digits after the decimal point).
//The input starts by the number N(alone in a line) followed by N lines,
//each holding an integer number.
//The output is like in the examples below.
//Input
//On the first line, you will receive the number N.
//On each of the next N lines, you will receive a single floating-point number.
//Output
//You output must always consist of exactly 4 lines - the minimal element on the first line,
//the maximal on the second, the sum on the third and the average on the fourth, in the following format:

using System;

class MMSANumbers
{
    static void Main()
    {

        int n = Convert.ToInt32(Console.ReadLine());
        double[] arrNumbers = new double[n];

        for (int i = 0; i < n; i++)
        {
            arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        double min = arrNumbers[0];
        double max = arrNumbers[0];
        double sum = 0;
        double average = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arrNumbers[i];
            if (min > arrNumbers[i])
                min = arrNumbers[i];
            if (max < arrNumbers[i])
                max = arrNumbers[i];
        }
        average = (double)sum / n;

        Console.WriteLine();
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", average);
    }
}




