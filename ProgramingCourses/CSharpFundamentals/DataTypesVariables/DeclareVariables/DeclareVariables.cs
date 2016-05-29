//Problem 1: Declare five variables choosing for each of them the most appropriate of the types:
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class DeclareVariables
{
    static void Main()
    {
        byte a = 97;
        sbyte b = -115;
        short c = -10000;
        ushort d = 52130;
        int e = 4825932;
        Console.WriteLine(" a:{0}\n b:{1}\n c:{2}\n d:{3}\n e:{4}", a,b,c,d,e);

    }
}

