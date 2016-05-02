//Description
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Don’t use arrays and the built-in sorting functionality.
//Input
//On the first three lines, you will receive the three numbers, each on a separate line.
//Output
//Output a single line on the console - the sorted numbers, separated by a whitespace

using System;

class SortNumbers
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        if (firstNum == secondNum && secondNum == thirdNum)
        {
            Console.WriteLine("{0} {1} {2}", thirdNum, secondNum, firstNum);
        }

        if (firstNum > secondNum && firstNum > thirdNum || secondNum > firstNum && secondNum > thirdNum
            || thirdNum > firstNum && thirdNum > secondNum)
        {
            if (firstNum > secondNum && firstNum > thirdNum)
            {
                if (secondNum >= thirdNum)
                {
                    Console.WriteLine("{0} {1} {2}", firstNum, secondNum, thirdNum);
                }
                else if (thirdNum > secondNum)
                {
                    Console.WriteLine("{0} {1} {2}", firstNum, thirdNum, secondNum);
                }
            }

            if (secondNum > firstNum && secondNum > thirdNum)
            {
                if (firstNum >= thirdNum)
                {
                    Console.WriteLine("{0} {1} {2}", secondNum, firstNum, thirdNum);
                }
                else if (thirdNum > firstNum)
                {
                    Console.WriteLine("{0} {1} {2}", secondNum, thirdNum, firstNum);
                }

            }

            if (thirdNum > firstNum && thirdNum > secondNum)
            {
                if (firstNum >= secondNum)
                {
                    Console.WriteLine("{0} {1} {2}", thirdNum, firstNum, secondNum);
                }
                else if (secondNum > firstNum)
                {
                    Console.WriteLine("{0} {1} {2}", thirdNum, secondNum, firstNum);
                }
            }
        }
    }
}

