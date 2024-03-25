namespace CirclePointFinder.Models
{
    abstract class PointsFinder
    {
        private IsoscelesTriangle _baseTriangle;

        public PointsFinder(Point firstPoint, Point secondPoint, double radius)
        {
            _baseTriangle = new IsoscelesTriangle(firstPoint, secondPoint, radius);

            FindClockwiseSearchingAngle();
        }

        public double ClockwiseSearchingAngle { get; private set; }

        public List<Point> FindPoints(int pointsCount)
        {
            if (pointsCount <= 0)
                return null;

            List<Point> points = new List<Point>(pointsCount);

            double angleStep = GetAngleStep(pointsCount);

            points.Add(GetNextPoint(_baseTriangle.FirstAnglePoint, angleStep));

            for (int i = 0; i < pointsCount - 1; i++)
                points.Add(GetNextPoint(points[i], angleStep));

            return points;
        }

        protected virtual double GetAngleStep(int pointsCount)
        {
            int devidingSectionCount = ++pointsCount;

            return ClockwiseSearchingAngle / devidingSectionCount;
        }

        private Point GetNextPoint(Point startPoint, double angel)
        {
            return Geometry.RotateVector(_baseTriangle.VertexPoint, startPoint, angel);
        }

        private void FindClockwiseSearchingAngle()
        {
            double fullCircleAngel = 360;

            if (Geometry.RotateVector(_baseTriangle.VertexPoint, _baseTriangle.FirstAnglePoint, _baseTriangle.VertexAngle) == _baseTriangle.SecondAnglePoint)
                ClockwiseSearchingAngle = fullCircleAngel - _baseTriangle.VertexAngle;
            else
                ClockwiseSearchingAngle = _baseTriangle.VertexAngle;
        }
    }
}