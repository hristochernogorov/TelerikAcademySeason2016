//You are given a text.Write a program that changes the text in all regions surrounded by the tags<upcase> and</upcase> to upper-case.
//Input
//On the only line you will receive a string - the text
//Output
//Print the changed string on one line
//Constraints
//The tags will not be nested.
//String length will be <= 10000
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input 
//We are living in a<upcase> yellow submarine</upcase>.We don't have <upcase>anything</upcase> else.
//Output
//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;




class ParseTags
{

    static void Main()
    {

        var input = Console.ReadLine().Split(new char[] { '<', '>' }).ToArray();
        var array = new string[input.Length];
        var toUpperStart = "upcase";
        var toUpperStop = "/upcase";
        var upper = false;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == toUpperStart)
            {
                upper = true;
                continue;
            }
            if (input[i] == toUpperStop)
            {
                upper = false;
                continue;
            }
            if (upper)
            {
                array[i] = input[i].ToUpper();
            }
            else
            {
                array[i] = input[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();

    }
}

