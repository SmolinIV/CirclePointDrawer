namespace CirclePointFinder.Models
{
    class Geometry
    {
        public static Point VectorCenter(Point vectorBegin, Point vectorEnd)
        {
            double halfDevidingRatio = 0.5d;

            return (vectorBegin + vectorEnd) * halfDevidingRatio;
        }

        public static double VectorLength(Point vectorBegin, Point vectorEnd)
        {
            int mathPower = 2;

            Point vector = vectorEnd - vectorBegin;

            return Math.Sqrt(Math.Pow(vector.PositionX, mathPower) + Math.Pow(vector.PositionY, mathPower));
        }

        public static Point NormalizedVector(Point vectorBegin, Point vectorEnd)
        {
            double lenth = VectorLength(vectorBegin, vectorEnd);

            Point vector = vectorEnd - vectorBegin;

            return new Point(vector.PositionX / lenth, vector.PositionY / lenth);
        }

        public static Point RotateVector(Point vectorBegin, Point vectorEnd, double angleInDegrees)
        {
            double angle = DegreeToRadian(angleInDegrees);

            Point NormalizedVector = Geometry.NormalizedVector(vectorBegin, vectorEnd);

            double rotatedPointX = NormalizedVector.PositionX * Math.Cos(angle) - NormalizedVector.PositionY * Math.Sin(angle);
            double rotatedPointY = NormalizedVector.PositionX * Math.Sin(angle) + NormalizedVector.PositionY * Math.Cos(angle);

            return new Point(rotatedPointX, rotatedPointY) * VectorLength(vectorBegin, vectorEnd) + vectorBegin;
        }


        public static double RadianToDegree(double angleInRadian)
        {
            double halfCirlceAngle = 180;

            return angleInRadian * halfCirlceAngle / Math.PI;
        }

        public static double DegreeToRadian(double angleInDegrees)
        {
            double halfCirlceAngle = 180;

            return angleInDegrees * (Math.PI / halfCirlceAngle);
        }
    }
}
