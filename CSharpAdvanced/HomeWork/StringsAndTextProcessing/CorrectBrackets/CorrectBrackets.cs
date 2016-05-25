//Description
//Write a program to check if in a given expression the(and ) brackets are put correctly.
//Input
//On the only line you will receive an expression
//Output
//Print Correct if the brackets are correct
//Incorrect otherwise
//Constraints
//1 <= length of expression <= 10000
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input              Output
//((a+b)/5-d)	       Correct
//)(a+b))         	Incorrect

using System;
class CorrectBrackets
{
    static string CorrectExpresion(string expression)
    {
        int leftBracket = 0;
        int rightBracket = 0;
        string answer = "";
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                leftBracket++;
            }
            else if (expression[i]== ')')
            {
                rightBracket++;
            }
        }
        if (leftBracket == rightBracket)
        {
           answer = "Correct";
        }
        else if (leftBracket!=rightBracket)
        {
            answer = "Incorrect";
        }
        return answer;
    } 
    static void Main()
    {
        string expression = Console.ReadLine();
        Console.WriteLine(CorrectExpresion(expression));

    }
}


