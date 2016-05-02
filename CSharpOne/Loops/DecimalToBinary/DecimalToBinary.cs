//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Input
//On the only input line you will receive the decimal integer number.
//Output
//Output a single string - the representation of the input decimal number in it's binary representation.

using System;

class Program
{
    static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(decimalNumber,2));
    }
}

