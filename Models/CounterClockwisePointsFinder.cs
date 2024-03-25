namespace CirclePointFinder.Models
{
    class CounterClockwisePointsFinder : PointsFinder
    {
        public CounterClockwisePointsFinder(Point firstPoint, Point secondPoint, double radius) :
            base(firstPoint, secondPoint, radius) { }

        protected override double GetAngleStep(int pointsCount)
        {
            int devidingSectionCount = ++pointsCount;
            double fullCircleAngle = 360;

            return (fullCircleAngle - ClockwiseSearchingAngle) / devidingSectionCount;
        }
    }
}