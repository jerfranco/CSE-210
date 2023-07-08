public abstract class Activity
{
    private string _date;
    public int _length;
    public double _distance;
    public double _speed;
    private string _activityType;
    public int _minutes;
    public double pace;

    // public Activity(string activityType, string date, int length, int distance, float speed)
    // {
    //     _activityType = activityType;
    //     _date = date;
    //     _length = length;
    //     _distance = distance;
    //     _speed = speed;
    // }

    public Activity(string activityType, string date, int minutes, int distance)
    {
        _activityType = activityType;
        _date = date;
        _minutes = minutes;
        _distance = distance;
    }
    
    public virtual double Distance()
    {
        return _distance;
    }

    public virtual double Speed()
    {
        return _speed;
    }
    public virtual double Pace()
    {
        pace = _minutes / _distance;
        return pace;
    }
    public string GetSummary()
    {
        return $"{_date} ({_minutes} min) - Distance {_distance}, Speed {_speed} mph, Pace: {pace} min per mile";
    }
}