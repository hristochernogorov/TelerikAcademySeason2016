//Compare arrays
//Description

//Write a program that reads two integer arrays of size N from the console and compares them element by element.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the first array will be given
//On the next N lines the numbers of the second array will be given
//Output

//Print Equal if the two arrays are the same and Not equal if they are not
//Constraints

//1 <= N <= 20
//N will always be a valid integer number
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//3                    3
//1                    1    
//2      Equal         1   Not Equal
//3                    1
//1                    2
//2                    2
//3	                 2



using System;

class CompareArrays
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] firstArray = new int[arraySize];
        int[] secondArray = new int[arraySize];
        int count = 0;
        int equalCount = 0;
        for (int i = 0; i < arraySize; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
            count++;
        }
        if (count == arraySize)
        {
            for (int j = 0; j < arraySize; j++)
            {
                secondArray[j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < arraySize; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                equalCount++;
                if (equalCount == arraySize)
                {
                    Console.WriteLine("Equal");
                }
            }
            else if (firstArray[i] != secondArray[i])
            {
                Console.WriteLine("Not equal");
                break;
            }
        }
    }
}

