//Maximal sequence
//Description

//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.
//Input
//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output
//Print the length of the maximal sequence
//Constraints
//1 <= N <= 1024
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//10
//2
//1
//1          3
//2
//3
//3
//2
//2
//2
//1

using System;

class MaximalSequence
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        int currentSequence = 1;
        int longSeqence = 1;

        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                currentSequence++;
                if (currentSequence > longSeqence)
                {
                    longSeqence = currentSequence;
                }
            }
            else
            {
                currentSequence = 1;
            }

        }
        if (longSeqence < currentSequence)
        {
            Console.WriteLine(currentSequence);
        }
        else
        {
            Console.WriteLine(longSeqence);
        }

    }

}
