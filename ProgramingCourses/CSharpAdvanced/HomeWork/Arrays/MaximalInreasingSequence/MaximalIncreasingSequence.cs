//Maximal increasing sequence
//Description
//Write a program that finds the length of the maximal increasing sequence in an array of N integers.
//Input
//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output
//Print the length of the maximal increasing sequence
//Constraints
//1 <= N <= 1024
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//8
//7
//3
//2        3
//3
//4
//2
//2
//4

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        int currentSequence = 1;
        int maxIncreasingSequence = 1;
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrayLength - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                currentSequence++;
                if (currentSequence > maxIncreasingSequence)
                {
                    maxIncreasingSequence = currentSequence;
                }
            }
            else
            {
                currentSequence = 1;
            }
        }
        if (maxIncreasingSequence < currentSequence)
        {
            Console.WriteLine(currentSequence);
        }
        else
        {
            Console.WriteLine(maxIncreasingSequence);
        }
    }
}

