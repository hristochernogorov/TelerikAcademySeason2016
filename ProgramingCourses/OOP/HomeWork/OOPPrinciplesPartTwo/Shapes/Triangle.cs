namespace Shapes
{
    public class Triangle
    {
       

        public virtual double SurfaceTriangle(double height,double width)
        {
            var surface = (height * width) / 2;
            return surface;
        }
    }
}
