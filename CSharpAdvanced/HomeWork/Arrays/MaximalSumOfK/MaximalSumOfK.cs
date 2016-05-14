//Maximal K sum
//Description:
//Write a program that reads two integer numbers N and K and an array of N elements from the console.Find the maximal sum of K elements in the array.
//Input:
//On the first line you will receive the number N
//On the second line you will receive the number K
//On the next N lines the numbers of the array will be given
//Output:
//Print the maximal sum of K elements in the array
//Constraints:
//1 <= N <= 1024
//1 <= K <= N
//Time limit: 0.1s
//Memory limit: 16MB

//Sample tests
//Input   Output
//8
//3
//3
//2        16
//3
//-2
//5
//4
//2
//7

using System;
using System.Collections;
class MaximalSumOfK
{
    static void Main()
    {
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLenght];
        int numberK = int.Parse(Console.ReadLine());
        int count = arrayLenght - numberK;
        int sum = 0;
        for (int i = 0; i < arrayLenght; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        for (int i = arrayLenght; i > count; i--)
        {
            sum += array[i - 1];
        }
        Console.WriteLine(sum);

    }
}

