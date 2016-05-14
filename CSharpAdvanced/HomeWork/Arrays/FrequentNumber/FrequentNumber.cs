//Frequent number
//Description:
//Write a program that finds the most frequent number in an array of N elements.
//Input:
//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output:
//Print the most frequent number and how many time it is repeated
//Output should be REPEATING_NUMBER(REPEATED_TIMES times)
//Constraints:
//1 <= N <= 1024
//0 <= each number in the array <= 10000
//There will be only one most frequent number
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//13
//4
//1
//1
//4
//2      4 (5 times)
//3
//4
//4
//1
//2
//4
//9
//3	

using System;

class FrequentNumber
{
    static void Main()
    {
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLenght];
        int count = 1;
        int maxCount = 1;
        int countedNumber = 0;
        for (int i = 0; i < arrayLenght; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);

        for (int i = 0; i < arrayLenght - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > maxCount)
            {
                maxCount = count;
                countedNumber = array[i];
            }
        }
        if (maxCount > 1)
        {
            Console.WriteLine("{0} ({1} times)",countedNumber,maxCount);
        }

    }
}

