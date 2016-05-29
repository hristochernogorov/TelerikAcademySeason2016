//Problem 2: Which of the following values can be assigned to a variable of type float and which to a variable of type double:
//34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        float floatNumber = 12.345f;
        float secondNumber = 3456.091f;
        double doubleNumber = 34.567839023;
        double secondDoubleNumber = 8923.1234857;
        Console.WriteLine(" floatNumber: {0}\n secondNumber: {1}\n doubleNumber: {2}\n secondDoubleNumber: {3} ", floatNumber,secondNumber,doubleNumber,secondDoubleNumber);

    }
}

