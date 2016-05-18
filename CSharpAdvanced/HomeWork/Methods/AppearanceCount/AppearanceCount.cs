//Description
//Write a method that counts how many times given number appears in a given array.
//Write a test program to check if the method is working correctly.
//Input
//On the first line you will receive a number N - the size of the array
//On the second line you will receive N numbers separated by spaces - the numbers in the array
//On the third line you will receive a number X
//Output
//Print how many times the number X appears in the array
//Constraints
//1 <= N <= 1024
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//8
//28 6 21 6 -7856 73 73 -56
//73	2

using System;
using System.Linq;

class AppearanceCount
{
    private static int length;
    private static int currentNumber;
    private static int count;
    static void Main()
    {
        length = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
        currentNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(AppearanceSize(numbers, currentNumber));

    }
    static int AppearanceSize(int[] numbers, int currentNumber)
    {
        count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (currentNumber == numbers[i])
            {
                count++;
            }
        }
        return count;
    }


}

