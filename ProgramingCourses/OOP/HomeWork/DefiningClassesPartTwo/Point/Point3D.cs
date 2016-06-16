namespace Point
{
    public struct Point3D
    {
        private static readonly Point3D o =
            new Point3D(){ X = 0, Y = 0, Z = 0 };

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static Point3D O
        {
            get
            {
                return o;
            }

        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", this.X, this.Y, this.Z);
        }
    }
}
