namespace CirclePointFinder.Models
{
    class ClockwisePointsFinder : PointsFinder
    {
        public ClockwisePointsFinder(Point firstPoint, Point secondPoint, double radius) :
            base(firstPoint, secondPoint, radius) { }

        protected override double GetAngleStep(int pointsCount)
        {
            int clockwiseChanger = -1;

            return base.GetAngleStep(pointsCount) * clockwiseChanger;
        }
    }
}