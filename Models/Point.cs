namespace CirclePointFinder.Models
{
    struct Point
    {
        public Point(double x, double y) => (PositionX, PositionY) = (x, y);

        public double PositionX { get; set; }
        public double PositionY { get; set; }

        public static Point operator + (Point left, Point right)
        {
            return new Point(left.PositionX + right.PositionX, left.PositionY + right.PositionY);
        }

        public static Point operator - (Point left, Point right)
        {
            return new Point(left.PositionX - right.PositionX, left.PositionY - right.PositionY);
        }

        public static Point operator * (Point left, double multiplier)
        {
            return new Point(left.PositionX * multiplier, left.PositionY * multiplier);
        }

        public static bool operator ==(Point left, Point right)
        {
            double epsilon = 0.0001;

            return Math.Abs(left.PositionX - right.PositionX) < epsilon && Math.Abs(left.PositionY - right.PositionY) < epsilon;
        }

        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }
    }
}
