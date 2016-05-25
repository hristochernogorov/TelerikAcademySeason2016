//Description
//Write a program that reads a string, reverses it and prints the result on the console.
//Input
//On the only line you will receive a string
//Output
//Print the string in reverse on a single line
//Constraints
//1 <= size of string <= 10000
//Time limit: 0.1s
//Memory limit: 16MB
//Sample       tests
//Input        Output
//sample       elpmas
//somestring   gnirtsemos

using System;

class ReverseString
{
    static string ReverseInputString(string input)
    {
        char[] array = input.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }

    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ReverseInputString(input));

    }
}

