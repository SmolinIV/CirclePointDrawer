using CirclePointFinder.Models;
using CirclePointFinder.Views;

namespace CirclePointFinder.Presenter
{
    internal class PointsOnCirclePresenter
    {
        private IPointsInCircle _circlePointsView;

        public PointsOnCirclePresenter(IPointsInCircle circlePointsView)
        {
            _circlePointsView = circlePointsView;

            _circlePointsView.SearchRequired += FindPoints;      
        }

        ~PointsOnCirclePresenter()
        {
            _circlePointsView.SearchRequired -= FindPoints;
        }

        private void FindPoints(bool isCounterClockwise)
        {
            BringValuesToValidForm(out Models.Point firstPoint, out Models.Point secondPoint, out double radius, out int pointsCount);

            PointsFinder pointsFinder;

            try
            {
                if (isCounterClockwise)
                    pointsFinder = new ClockwisePointsFinder(firstPoint, secondPoint, radius);
                else
                    pointsFinder = new CounterClockwisePointsFinder(firstPoint, secondPoint, radius);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            List<Models.Point> points = pointsFinder.FindPoints(pointsCount);

            if (points == null)
            {
                _circlePointsView.ShowMessegeBox("Input values is incorrect.");
                return;
            }

            List<KeyValuePair<double, double>> restructuredPoints = new List<KeyValuePair<double, double>>(points.Count);

            foreach (Models.Point point in points)
                restructuredPoints.Add(new KeyValuePair<double, double>(point.PositionX, point.PositionY));

            _circlePointsView.ShowPoints(restructuredPoints);
        }

        private void BringValuesToValidForm(out Models.Point firstPoint, out Models.Point secondPoint, out double radius, out int pointsCount)
        {
            firstPoint = new Models.Point(double.Parse(_circlePointsView.FirstPointPositionX), double.Parse(_circlePointsView.FirstPointPositionY));
            secondPoint = new Models.Point(double.Parse(_circlePointsView.SecondPointPositionX), double.Parse(_circlePointsView.SecondPointPositionY));
            radius = double.Parse(_circlePointsView.Radius);
            pointsCount = int.Parse(_circlePointsView.PointsCount);
        }
    }
}
