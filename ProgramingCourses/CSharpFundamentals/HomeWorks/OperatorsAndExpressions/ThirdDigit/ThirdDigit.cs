//Write a program that reads an integer N from the console and prints true if the third digit of the N is 7, 
//or "false THIRD_DIGIT", where you should print the third digits of N.
//The counting is done from right to left, meaning 123456's third digit is 4.
//Input
//The input will always consist of exactly one line, containing the number N.
//Output
//The output should be a single line - print whether the third digit is 7, following the format described above.

using System;

class ThirdDigit
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        if (N.ToString().Length >= 3 && N.ToString()[N.ToString().Length - 3] == '7')
        {
            Console.WriteLine("true");
        }
        else if (N.ToString().Length <= 3 || N.ToString().Length >= 3)
        {
            if (N.ToString().Length > 3 && N.ToString()[N.ToString().Length - 3] != '7')
            {
                Console.WriteLine("false {0}", N.ToString()[N.ToString().Length - 3]);
            }
            else
            {
                Console.WriteLine("false 0");
            }
        }

    }
}

