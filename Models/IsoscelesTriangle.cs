namespace CirclePointFinder.Models
{
    class IsoscelesTriangle
    {
        private double _baseLength;
        private double _height;

        public IsoscelesTriangle(Point firstAnglePoint, Point secondAnglePoint, double edgeLength)
        {
            CheckValuesCorrectness(firstAnglePoint, secondAnglePoint, edgeLength); 

            FirstAnglePoint = firstAnglePoint;
            SecondAnglePoint = secondAnglePoint;
            EdgeLength = edgeLength;

            CalculateSizes();
        }

        public Point FirstAnglePoint { get; private set; }
        public Point SecondAnglePoint { get; private set; }
        public double EdgeLength { get; private set; }
        public Point VertexPoint { get; private set; }
        public double VertexAngle { get; private set; }

        private bool CheckValuesCorrectness(Point firstPoint, Point secondPoint, double radius)
        {
            int halfDevider = 2;

            if (firstPoint == secondPoint)
                throw new ArgumentException("Points must not to be equal.");

            if (radius <= 0)
                throw new ArgumentException("Radius must be greater then 0");

            if (Geometry.VectorLength(secondPoint, firstPoint) / halfDevider > radius)
                throw new ArgumentException("The radius must be equal or more than half distance between the points.");

            return true;
        }

        private void CalculateSizes()
        {
            CalculateBaseLength();
            CalculateHeight();
            CalculateVertexPoint();
            CalculateVertexAngle();
        }

        private void CalculateBaseLength() =>
            _baseLength = Geometry.VectorLength(FirstAnglePoint, SecondAnglePoint);

        private void CalculateHeight()
        {
            int edgeMathPower = 2;
            int baseDevider = 4;

            _height = Math.Sqrt(Math.Pow(EdgeLength, edgeMathPower) - Math.Pow(_baseLength, edgeMathPower) / baseDevider);
        }

        private void CalculateVertexPoint()
        {
            int rightAngle = 90;
            int lengthHalfDevider = 2;

            Point baseCenter = Geometry.VectorCenter(FirstAnglePoint, SecondAnglePoint);

            if (_baseLength / lengthHalfDevider == EdgeLength)
            {
                VertexPoint = baseCenter;
            }
            else
            {
                Point radiusRotatedVector = Geometry.RotateVector(baseCenter, FirstAnglePoint, rightAngle);

                VertexPoint = Geometry.NormalizedVector(baseCenter, radiusRotatedVector) * _height + baseCenter;
            }
        }

        private void CalculateVertexAngle()
        {
            double halfCircleAngle = 180;

            double cosA = _baseLength / (EdgeLength + EdgeLength);
            double edgeBaseAngle = Math.Acos(cosA);

            double angleInDegrees = Geometry.RadianToDegree(edgeBaseAngle);

            VertexAngle = halfCircleAngle - (angleInDegrees + angleInDegrees);
        }
    }
}