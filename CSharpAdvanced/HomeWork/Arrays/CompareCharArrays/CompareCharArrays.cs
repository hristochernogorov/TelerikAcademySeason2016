//Compare char arrays
//Write a program that compares two char arrays lexicographically(letter by letter).
//Input
//On the first line you will receive the first char array as a string
//On the second line you will receive the second char array as a string
//Output
//Print "<" if the first array is lexicographically smaller
//Print ">" if the second array is lexicographically smaller
//Print "=" if the arrays are equal
//Constraints
//1 <= size of arrays <= 128
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//hello
//halo	     >
//food
//food       =

using System;

class CompareCharArrays
{
    static void Main()
    {
        string[] firstArray = { Console.ReadLine() };
        string[] secondArray = { Console.ReadLine() };
        for (int i = 0, j = 0; i < firstArray.Length; j++, i++)
        {
            if (firstArray[i] != firstArray[j] ^ firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("<");
            }
            else if (secondArray[j] != firstArray[i] ^ secondArray.Length > firstArray.Length)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("=");
            }

        }
    }
}
