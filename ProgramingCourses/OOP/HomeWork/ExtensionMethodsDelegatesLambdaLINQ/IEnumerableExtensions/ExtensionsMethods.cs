namespace IEnumerableExtensions
{
    using System;

    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public static class ExtensionsMethods
    {
        public static T MyExtentSum<T>(this IEnumerable<T> myColection) where T : struct
        {
            var result = (dynamic)0;

            foreach (var item in myColection)
            {
                result += item;
            }

            return result;
        }

        public static T MyExtentProduct<T>(this IEnumerable<T> myColection) where T : struct
        {
            var result = (dynamic)1;
            foreach (var item in myColection)
            {
                result *= item;
            }

            return result;
        }

        public static T MyExtentMin<T>(this IEnumerable<T> myColection) where T : struct
        {
            return myColection.Min();
        }

        public static T MyExtentMax<T>(this IEnumerable<T> myColection) where T : struct
        {
            return myColection.Max();
        }

        public static T MyExtentAverage<T>(this IEnumerable<T> myColection) where T : struct
        {
            return (dynamic)myColection.MyExtentSum() / myColection.Count();
        }
    }
}
