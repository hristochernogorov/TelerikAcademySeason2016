//You are given N integers(given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to
//the product of the even elements.
//Elements are counted from 1 to N, so the first element is odd, the second is even, etc.
//Input
//On the first line you will receive the number N
//On the second line you will receive N numbers separated by a whitespace
//Output
//If the two products are equal, output a string in the format "yes PRODUCT_VALUE",
//otherwise write on the console "no ODD_PRODUCT_VALUE EVEN_PRODUCT_VALUE"

using System;

class OddEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string readNumbers =Console.ReadLine();
        string [] arrayOfNumbers = readNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        long evenProduct = 1;
        long oddProduct = 1;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(arrayOfNumbers[i]);
            
            if (i % 2 == 0)
            {
                evenProduct *= number;
            }
            else
            {
                oddProduct *= number;
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", evenProduct, oddProduct);
        }
    }
}

