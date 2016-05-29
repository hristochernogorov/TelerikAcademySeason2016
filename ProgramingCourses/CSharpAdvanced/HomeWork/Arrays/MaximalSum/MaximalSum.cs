//Maximal sum
//Description:
//Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
//Can you do it with only one loop (with single scan through the elements of the array)?
//Input:
//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output:
//Print the maximal sum of consecutive numbers
//Constraints:
//1 <= N <= 1024
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//10
//2
//3
//-6
//-1      11
//2
//-1
//6
//4
//-8
//8	


using System;

class MaximalSum
{
    static void Main()
    {
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
           
        }

        int curSum = array[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempIndex = 0;
        int maxSum = array[0];
        for (int i = 0; i < arrayLenght; i++)
        {
            if (curSum <= 0)
            {
                startIndex = i;
                curSum = 0;
            }
            curSum += array[i];
            if (curSum > maxSum)
            {
                maxSum = curSum;
                tempIndex = startIndex;
                endIndex = i;
            }
           
  
        }
        Console.WriteLine(maxSum);
    }
}

