/*Write a program that reads an integer N 
(which will always be less than 100 or equal) and uses an expression to check 
if given N is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
Input
On the only input line you will receive the number N.
Output
Output true if the number is prime and false otherwise.
*/
using System;

class PrimeCheck
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int result = checkPrime(N);
        if (result == 0)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
        Console.Read();
    }
    private static int checkPrime(int N)
    {
        int i;
        for (i = 2; i <= N - 1; i++)
        {
            if (N % i == 0)
            {
                return 0;
            }
        }
        if (i == N)
        {
            return 1;
        }
        return 0;
    }
}


