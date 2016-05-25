//Random numbers
//Description
//Write a program that generates and prints to the console 10 random values
//in the range[100, 200].

using System;
class RandomNumbers
{
    static void Main()
    {
        Random randomNumber = new Random();
        int lenght = 10;
        for (int i = 0; i < lenght; i++)
        {
            Console.WriteLine(randomNumber.Next(100,200));
        }
    }
}

