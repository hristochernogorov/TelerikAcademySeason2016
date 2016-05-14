//Fill the matrix
//Description:
//Write a program that fills and prints a matrix of size(n, n) as shown below.
//Input:
//On the first line you will receive the number N
//On the second line you will receive a character (a, b, c, d*) which determines how to fill the matrix
//Output:
//Print the matrix
//Numbers on a row must be separated by a single spacebar
//Each row must be on a new line
//Constraints:
//1 <= N <= 128
//Time limit: 0.1s
//Memory limit: 16MB

using System;
class FillMatrix
{
    static void Main()
    {
        int matrixSize = int.Parse(Console.ReadLine());
        char matrixModel = char.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];
        int count = 1;
        //MODEL A
        if (matrixModel == 'a')
        {
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[col, row] = count;
                    count++;
                }

            }

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (col == matrixSize - 1)
                    {
                        Console.Write("{0}", matrix[row, col]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }

                }
                Console.WriteLine();
            }
        }
        //MODEL B
        else if (matrixModel == 'b')
        {
            for (int col = 0; col < matrixSize; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrixSize; row++)
                    {
                        matrix[col, row] = count;
                        count++;
                    }
                }
                else
                {
                    for (int row = matrixSize - 1; row >= 0; row--)
                    {
                        matrix[col, row] = count;
                        count++;
                    }
                }
            }

            for (int col = 0; col < matrixSize; col++)
            {
                for (int row = 0; row < matrixSize; row++)
                {
                    if (row == matrixSize - 1)
                    {
                        Console.Write("{0}", matrix[row, col]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
        //MODEL C
        else if (matrixModel == 'c')
        {
            int rows = 0;
            int cols = 0;
            int value = 1;
            for (int i = matrixSize - 1; i >= 0; i--)
            {
                rows = i;
                cols = 0;
                while (rows < matrixSize && cols < matrixSize)
                {
                    matrix[rows++, cols++] = value++;
                }
            }
            for (int j = 1; j < matrixSize; j++)
            {
                rows = j;
                cols = 0;
                while (rows < matrixSize && cols < matrixSize)
                {
                    matrix[cols++, rows++] = value++;
                }
            }

            for (int m = 0; m < matrixSize; m++)
            {
                for (int n = 0; n < matrixSize; n++)
                {
                    if (n == matrixSize - 1)
                    {
                        Console.Write("{0}", matrix[m, n]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[m, n]);
                    }
                }
                Console.WriteLine();
            }
        }
        //MODEL D
        else if (matrixModel == 'd')
        {
            int digit = 1;
            int offset = 0;
            int row = 0;
            int col = 0;
            while (digit <= matrixSize * matrixSize)
            {
                for (row = offset; row < matrixSize - offset; row++)
                {
                    col = offset;
                    matrix[row, col] = digit;
                    digit++;
                }
                for (col = 1 + offset; col < matrixSize - offset; col++)
                {
                    row = matrixSize - 1 - offset;
                    matrix[row, col] = digit;
                    digit++;
                }
                for (row = matrixSize - 2 - offset; row >= offset; row--)
                {
                    col = matrixSize - 1 - offset;
                    matrix[row, col] = digit;
                    digit++;
                }
                for (col = matrixSize - 2 - offset; col >= offset + 1; col--)
                {
                    row = offset;
                    matrix[row, col] = digit;
                    digit++;
                }
                offset++;
            }
            for (int irow = 0; irow < matrixSize; irow++)
            {
                for (int column = 0; column < matrixSize; column++)
                {
                    if (column == matrixSize - 1)
                    {
                        Console.Write("{0}", matrix[irow, column]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[irow, column]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

