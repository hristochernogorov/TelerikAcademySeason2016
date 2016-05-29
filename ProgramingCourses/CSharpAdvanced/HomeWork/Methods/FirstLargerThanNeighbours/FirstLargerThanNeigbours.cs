//Description
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, 
//if there is no such element.
//Input
//On the first line you will receive the number N - the size of the array
//On the second line you will receive N numbers sepated by spaces - the array
//Output
//Print the index of the first element that is larger than its neighbours or -1 if none are
//Constraints
//1 <= N <= 1024
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//6
//-26 -25 -28 31 2 27	1

using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    private static int count;
    private static int lenght;
    

    static int FirstLarger( int [] numbers)
    {
        count = 0;
        for (int i = 1; i < lenght - 1; i++)
        {
            int currentLarger = numbers[i];
            if (numbers[i-1] < currentLarger && currentLarger > numbers[i+1])
            {
                count++;
                break;
            }

        }
        
        return count;
    }
    static void Main()
    {
        lenght = int.Parse(Console.ReadLine());
        int [] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
        Console.WriteLine(FirstLarger(numbers));
    }
}

