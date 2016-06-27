namespace Shapes
{
    using System;

    public class Square : Shape
    {
        public Square(double side)
             : base(side, side)
        {

        }
        public double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
