//Description
//Write a program that read a digit(0-9) from the console, and depending on the input,
//shows the digit as a word(in English).
//Print "not a digit" in case of invalid input.
//Use a switch statement.
//Input
//The input consists of one line only, which contains the digit.
//Output
//Output a single line - should the input be a valid digits, 
//print the english word for the digits.Otherwise, print "not a digit"

using System;

class DigitAsWord
{
    static void Main()
    {
        string input = Console.ReadLine();

        if (input == "0" || input == "1" || input == "2" || input == "3" || input == "4" ||
            input == "5" || input == "6" || input == "7" || input == "8" || input == "9")
        {
            switch (input)
            {
                default:
                    Console.WriteLine("zero");
                    break;

                case "1":
                    Console.WriteLine("one");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "3":
                    Console.WriteLine("three");
                    break;
                case "4":
                    Console.WriteLine("four");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;
                case "6":
                    Console.WriteLine("six");
                    break;
                case "7":
                    Console.WriteLine("seven");
                    break;
                case "8":
                    Console.WriteLine("eight");
                    break;
                case "9":
                    Console.WriteLine("nine");
                    break;
            }
        }
        else
        {
            Console.WriteLine("not a digit");
        }




    }
}

