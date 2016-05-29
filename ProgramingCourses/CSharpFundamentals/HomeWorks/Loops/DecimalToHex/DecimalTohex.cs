//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Input
//On the first and only line you will receive an integer in the decimal numeral system.
//Output
//On the only output line write the hexadecimal representation of the read number.

using System;

    class DecimalTohex
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(number.ToString("X"));
    }
}

