public class Bicycles : Activity
{

    int _speed1;
    public Bicycles(string activityType, string date, int minutes, int distance, int speed) : base(activityType, date, minutes, distance)
    {
        _speed1 = speed;
    }

    public override double Speed()
    {
        _speed = _distance / _minutes;
        return _speed;
    }
}