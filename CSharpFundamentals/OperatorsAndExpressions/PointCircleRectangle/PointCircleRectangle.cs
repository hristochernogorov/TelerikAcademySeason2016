/*Write a program that reads a pair of coordinates x and y and uses an expression to checks for
given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle 
R(top=1, left=-1, width=6, height=2).
Input
You will receive the pair of coordinates on the two lines of the input - on the first line you will find x,
and on the second - y.
Output
Print inside circle if the point is inside the circle and outside circle if it's outside.
Then print a single whitespace followed by inside rectangle if the point is inside the rectangle 
and outside rectangle otherwise. See the sample tests for a visual description.
*/

using System;
class PointCircleRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 1.5;
        bool isInCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= radius * radius);
        bool isInRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
        if (isInCircle && isInRectangle)
        {
            Console.WriteLine("inside circle inside rectangle");
        }
        else if (!isInCircle && !isInRectangle)
        {
            Console.WriteLine("outside circle outside rectangle");
        }
        else if (!isInCircle && isInRectangle)
        {
            Console.WriteLine("outside circle inside rectangle");
        }
        else
        {
            Console.WriteLine("inside circle outside rectangle");
        }

    }
}

