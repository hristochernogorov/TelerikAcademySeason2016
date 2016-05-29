/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit
unsigned integer(read from the console).
Input
On the only input line you will receive the unsigned integer number whose bits you must exchange.
Output
On the only output line print the value of the integer with the exchanged bits.
*/

using System;

class BitExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        for (int i = 3; i <= 5; i++)
        {
            int bitOne = (int)(number >> i) & 1;
            int bitTwo = (int)(number >> (21 + i)) & 1;
            number = (uint)(number & (~(1 << (21 + i))) | (bitOne << (21 + i)));
            number = (uint)(number & (~(1 << i)) | (bitTwo << i));
        }
        Console.WriteLine(number);
    }
}


