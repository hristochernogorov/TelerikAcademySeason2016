namespace HexToDec
{
    using System;

    class HexToDec
    {
        static void Main()
        {
            var hexNumber = Console.ReadLine();
            var decNumber = long.Parse(hexNumber, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(decNumber);
        }
    }
}
