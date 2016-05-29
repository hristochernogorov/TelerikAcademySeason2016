//Description
//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours(when such exist).
//Write program that reads an array of numbers and prints how many of them are larger than their neighbours.
//Input
//On the first line you will receive the number N - the size of the array
//On the second line you will receive N numbers separated by spaces - the array
//Output
//Print how many numbers in the array are larger than their neighbours
//Constraints
//1 <= N <= 1024
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//6
//-26 -25 -28 31 2 27	2
using System;
using System.Linq;

class LargerThanNeighbours

{
    private static int count;
    private static int lenght;

    static void Main()
    {

        lenght = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
        Console.WriteLine(LargerNumber(numbers));
    }
    static int LargerNumber(int[] numbers)

    {
        count = 0;

        for (int i = 1; i < lenght-1; i++)
        {
            int currentNumber = numbers[i];
            if (numbers[i-1] <currentNumber && currentNumber > numbers[i+1])
            {
                count++;
            }
            

        }
        return count;
    }
}

