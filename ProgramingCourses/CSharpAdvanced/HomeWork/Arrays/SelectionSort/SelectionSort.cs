//Selection sort
//Description:
//Sorting an array means to arrange its elements in increasing order.Write a program to sort an array. Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
//Input:
//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output:
//Print the sorted array
//Each number should be on a new line
//Constraints:
//1 <= N <= 1024
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//6        1                 
//3        2
//4        3
//1        6
//5        5
//2        6 
//6	

using System;

class SelectionSort
{
    static void Main()
    {
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrayLenght -1; i++)
        {
            for (int j = i+1; j < arrayLenght; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        for (int i = 0; i < arrayLenght; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

