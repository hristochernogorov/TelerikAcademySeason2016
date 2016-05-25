//Description
//Write a program that finds how many times a sub-string is contained in a given text(perform case insensitive search).
//Input
//On the first line you will receive a string - the pattern
//On the second line you will receive a string - the text
//Output
//Print a number on a single line
//The number of occurrences
//Constraints
//The length of the two strings will be <= 4096
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//in
//We are living in an yellow submarine.We don't have anything else. inside the submarine is very tight.
//as So we are drinking all the day. We will move out of it in 5 days.	9

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class SubStringInText
{
    static void Main()
    {
        string keyword = Console.ReadLine();
        string input = Console.ReadLine();
        int index = 0;
        int found = 0;
        int count = 0;
        while (true)
        {

            found = input.ToLower().IndexOf(keyword.ToLower(), index);
            if (found < 0)
            {
                break;
            }
            index = found + 1;
            count++;
        }
        Console.WriteLine(count);
    }

}

