namespace EnterNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class EnterNumbers
    {
        public static int[] numbers = new int[12];
        public static bool isIncreasing = true;
        static int[] ReadNumbers()
        {
            numbers[0] = 1;
            numbers[11] = 100;
            int smallest = numbers[0];
            int start = 0;
            int end = 100;

            for (int i = 1; i < numbers.Length - 1; i++)
            {

                numbers[i] = int.Parse(Console.ReadLine());

                if (smallest < numbers[i] && numbers[i] < end && numbers[i] > start)
                {
                    smallest = numbers[i];
                    isIncreasing = true;
                    continue;
                }
                else if (smallest >= numbers[i])
                {
                    isIncreasing = false;
                    break;
                }
            }

            return numbers;
        }

        static void Main()
        {
            ReadNumbers();

            if (isIncreasing)
            {
                Console.WriteLine(string.Join(" < ", numbers));

            }
            if (!isIncreasing)
            {
                Console.WriteLine("Exception");
            }

        }
    }
}
