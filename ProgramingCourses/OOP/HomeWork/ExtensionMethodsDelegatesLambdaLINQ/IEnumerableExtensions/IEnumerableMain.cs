namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    public class IenumerableMain
    {

        public static void Main()
        {
            var myList = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine(myList.MyExtentMin());
            Console.WriteLine(myList.MyExtentMax());
            Console.WriteLine(myList.MyExtentSum());
            Console.WriteLine(myList.MyExtentProduct());
            Console.WriteLine(myList.MyExtentAverage());

        }
    }
}
