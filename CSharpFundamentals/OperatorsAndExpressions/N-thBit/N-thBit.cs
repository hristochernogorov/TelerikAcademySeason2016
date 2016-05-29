/*Write a program that reads from the console two integer numbers P and N 
and prints on the console the value of P's N-th bit.
Input
On the first line you will receive the number P. On the second line you will receive the number N.
Output
Output a single value - the value of the N-th bit in P.
*/
using System;

class Program
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        int bitP = int.Parse(Console.ReadLine());
        long mask = 1;
        if ((mask << bitP & N) == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("1");
        }
    }
}

