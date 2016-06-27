namespace Shapes
{
    public class Rectangle
    {
        public virtual double SurfaceRectangle(double height, double width)
        {
            var surface = (height * width);
            return surface;
        }
    }
}
