//Description
//Write a program that shows the sign(+, - or 0) of the product of three real numbers,
//without calculating it.
//Use a sequence of if operators.
//Input
//On the first three lines, you will receive the three numbers, each on a separate line
//Output
//Output a single line - the sign of the product of the three numbers

using System;

class MultiplicationSign
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double result = firstNumber * secondNumber * thirdNumber;

        if (result < 0)
        {
            Console.WriteLine("-");
        }
        else if (result > 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine(0);
        }

    }
}

