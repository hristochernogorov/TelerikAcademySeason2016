/*
Write a program first reads 3 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1}
with bits {q, q+1, …, q+k-1} of n. Print the resulting integer on the console.
Input
On the only four lines of the input you will receive the integers n, p, q and k in this order.
Output
Output a single value - the value of n after the bit swaps.
*/

using System;

class BitSwap
{
    static void Main()
    {
        uint n;
        uint number = uint.Parse(Console.ReadLine());
        int bitP = int.Parse(Console.ReadLine());
        int bitQ = int.Parse(Console.ReadLine());
        int bitK = int.Parse(Console.ReadLine());

        if ((bitP + bitK) < 31 && (bitQ + bitK) < 31 && (Math.Abs(bitP - bitQ) >= bitK))
        {
            if (bitP > bitQ)
            {
                int temp = bitQ;
                bitQ = bitP;
                bitP = temp;
            }

            n = ((~(((uint)Math.Pow(2, bitK) - 1) << bitQ | ((uint)Math.Pow(2, bitK) - 1) << bitP)) & number) | (((number & (((uint)Math.Pow(2, bitK) - 1) << bitP)) << (Math.Abs(bitP - bitQ))) | ((number & (((uint)Math.Pow(2, bitK) - 1) << bitQ)) >> (Math.Abs(bitP - bitQ))));
            Console.WriteLine(n);
        }

    }
}

