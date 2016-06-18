namespace Point
{
    using System;

    public class PointMain
    {
        public static void Main()
        {

            var point = new Point3D(1, 2, 3);

            var dist = CalculateDistance.Calculate(point, Point3D.O);
            Console.WriteLine(point);
            Console.WriteLine(Point3D.O);
            Console.WriteLine(dist);
            var path = new Path();
            for (int i = 0; i < 11; i++)
            {
                path.AddPoint(new Point3D() { X = i, Y = i * 2, Z = i + 3 });
            }

            string pathStr = "../../Path.txt";
            PathStorage.SavePath(path, pathStr);
            var pathFromFile = PathStorage.LoadPath(pathStr);

            foreach (var p in pathFromFile)
            {
                Console.WriteLine(p);
            }
        }
    }
}
