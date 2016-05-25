//Triangle surface by three sides
//Description
//Write program that calculates the surface of a triangle by given its three sides.
//Input
//On the first line you will receive the length of the first side of the triangle
//On the second line you will receive the length of the second side of the triangle
//On the third line you will receive the length of the third side of the triangle
//Output
//Print the surface of the rectangle with two digits of precision
//Constraints
//Input data describes a valid triangle
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//11
//12
//13	     61.48

using System;

class TriangleSurfaceByTreeSide
{
    private static double surface;
    private static double firstSide;
    private static double secondSide;
    private static double thirdSide;

    static double CalculateSurface(double firstSide, double secondSide, double thirdSide)
    {
        double perimeter = (firstSide + secondSide + thirdSide) / 2;
        surface = (Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide)));
        return surface;
    }
    static void Main()
    {
        firstSide = double.Parse(Console.ReadLine());
        secondSide = double.Parse(Console.ReadLine());
        thirdSide = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}", CalculateSurface(firstSide, secondSide, thirdSide));
    }
}

