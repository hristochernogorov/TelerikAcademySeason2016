//Get largest number
//Description
//Write a method GetMax() with two parameters that returns the larger of two integers.Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
//Input
//On the first line you will receive 3 integers separated by spaces
//Output
//Print the largest of them
//Constraints
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//8 3 6	8
//7 19 19	19

using System;
using System.Linq;

class GetLargestNumber
{

    static int GetMax(int firstNumber, int secondNumber)
    {
        int biggerNumber = Math.Max(firstNumber, secondNumber);
        return biggerNumber;
    }

    static void Main()
    {
        int [] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
        Console.WriteLine(GetMax(numbers[0],GetMax(numbers[1],numbers[2])));

    }
}

