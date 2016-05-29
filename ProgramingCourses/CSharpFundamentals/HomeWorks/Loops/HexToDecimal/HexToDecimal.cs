﻿//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Input
//The input will consists of a single line containing a single hexadecimal number as string.
//Output
//The output should consist of a single line - the decimal representation of the number as string.

using System;

class HexToDecimal
{
    static void Main()
    {
        string numberHex = Console.ReadLine();
        Console.WriteLine(Convert.ToUInt64(numberHex,16));
    }
}

