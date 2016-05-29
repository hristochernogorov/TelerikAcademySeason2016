using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLenght];
            int count = 0;
            for (int i = 0; i < arrayLenght; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            int userNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i < arrayLenght; i++)
            {
                count++;
                if (array[i] == userNumber)
                {
                    Console.WriteLine(count);
                    break;

                }
               
                
            }
          
        }
    }
}
