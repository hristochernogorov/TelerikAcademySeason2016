//Description
//Write a program that, depending on the first line of the input, reads an int,
//double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends* at the end.
//Print the result at the console. Use switch statement.
//Input
//On the first line you will receive the type of input as string in the following form:
//integer for int
//real for double
//text for string
//On the second line you will be given the value of the variable.
//Output
//Write a single line on the console - the value transformed according to the rules from the description.
//Print all double variables with exactly 2-digits precision after the floating point. Example: 0.99

using System;

class IntDoubleString
{
    static void Main()
    {
        string type = Console.ReadLine();
        string value = Console.ReadLine();
        if (type == "integer")
        {
            Console.WriteLine("{0}", int.Parse(value) + 1);
        }
        else if (type == "real")
        {
            Console.WriteLine("{0:F2}",double.Parse(value)+ 1);
        }
        else if (type == "text")
        {
            Console.WriteLine("{0}*",value);
        }

    }
}

