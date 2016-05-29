//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Input
//You will receive exactly one line containing an integer number representation in binary
//Output
//On the only output line write the decimal representation of the number

using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumbers = Console.ReadLine();
        Console.WriteLine(Convert.ToInt32(binaryNumbers, 2).ToString());
    }
}

