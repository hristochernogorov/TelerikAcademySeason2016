﻿//Problem 3: Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
//Use Windows Calculator to find its hexadecimal representation.
//Print the variable and ensure that the result is 254.

using System;

class VariableHexademical
{
    static void Main()
    {
        int intValue = 254;
        string hexValue = intValue.ToString("X");
        Console.WriteLine(hexValue);
    }
}

