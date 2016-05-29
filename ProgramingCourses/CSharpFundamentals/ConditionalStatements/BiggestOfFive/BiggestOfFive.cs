//Description
//Write a program that finds the biggest of 5 numbers that are read from the console,
//using only 5 if statements.
//Input
//On the first 5 lines you will receive the 5 numbers, each on a separate line
//Output
//On the only output line, write the biggest of the 5 numbers

using System;

class BiggestOfFive
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double fourthNumber = double.Parse(Console.ReadLine());
        double fifthNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber> thirdNumber &&
           firstNumber> fourthNumber && firstNumber > fifthNumber)
        {
            Console.WriteLine(firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber> thirdNumber&& 
            secondNumber> fourthNumber && secondNumber > fifthNumber)
        {
            Console.WriteLine(secondNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber &&
            thirdNumber > fourthNumber && thirdNumber > fifthNumber)
        {
            Console.WriteLine(thirdNumber);
        }
        else if (fourthNumber > firstNumber && fourthNumber > secondNumber &&
            fourthNumber > thirdNumber  && fourthNumber > fifthNumber)
        {
            Console.WriteLine(fourthNumber);
        }
        else 
        {
            Console.WriteLine(fifthNumber);
        }

    }
}

