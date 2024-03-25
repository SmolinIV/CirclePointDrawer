namespace CirclePointFinder.Views
{
    internal interface IPointsInCircle
    {
        string FirstPointPositionX { get; set; }
        string FirstPointPositionY { get; set; }
        string SecondPointPositionX { get; set;}
        string SecondPointPositionY { get; set; }
        string Radius { get; set; }
        string PointsCount { get; set; }
        bool IsSearchingCounterClockwise { get; set; }

        event Action<bool> SearchRequired;

        void ShowPoints(List<KeyValuePair<double, double>> points);

        void ShowMessegeBox(string message);
    }
}
