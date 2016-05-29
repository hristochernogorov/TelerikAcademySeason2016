//Description
//Classical play cards use the following signs to designate the card face:
//2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.Write a program that
//enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign or
//"no CONTENT_OF_STRING" otherwise.
//Input
//On the only line you will receive a single string.
//Output
//Output "yes CONTENT_OF_STRING" if the string is a card sign, otherwise print "no CONTENT_OF_STRING".

using System;

class CheckPlayCard
{

    static void Main()
    {
        string card = Console.ReadLine();
        string[] playCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        int count = 0;
        foreach (var cards in playCards)
        {

            if (card == cards)
            {
                Console.WriteLine("yes {0}", cards.ToString());
                break;
            }
            else if (card != cards && count == playCards.Length - 1)
            {

                Console.WriteLine("no {0}", card);
                break;
            }
            count++;
        }

    }
}

