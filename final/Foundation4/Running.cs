public class Running : Activity
{
    private double _distance;

    public Running(string activityType, string date, int minutes, int distance) : base(activityType, date, minutes, distance)
    {
        _distance = distance;
    }
}