/*We are given an integer number N(read from the console),
a bit value v(read from the console as well) (v = 0 or 1) and a position P(read from the console). 
Write a sequence of operators (a few lines of C# code) that modifies N to hold the value v
at the position P from the binary representation of N while preserving all other bits in N.
Print the resulting number on the console.
Input
The input will consist of exactly 3 lines containing the following:
First line - the integer number N.
Second line - the position P.
Third line - the bit value v.
Output
Output a single line containing the value of the number N with the modified bit.
*/

using System;

class ModifyBit
{
    static void Main()
    {
        ulong N = ulong.Parse(Console.ReadLine());
        int bitP = int.Parse(Console.ReadLine());
        int valueOfBitP = int.Parse(Console.ReadLine());
        ulong mask = 1;
        ulong result;

        if (valueOfBitP == 1)
        {
            mask = mask << bitP;
            result = N | mask;
        }
        else
        {
            mask = ~(mask << bitP);
            result = N & mask;
        }

        Console.WriteLine(result);

    }
}

