public abstract class Activity
{
    private int _date;
    public int _length;
    public int _distance;
    public float _speed;
    private string _activityType;
    private int speed;
    private int pace;

    public Activity(string activityType, int date, int length, int distance, float speed)
    {
        _activityType = activityType;
        _date = date;
        _length = length;
        _distance = distance;
        _speed = speed;
    }
    
    public virtual int Distance()
    {
        return _distance;
    }
    public virtual float Speed()
    {
        speed = (_distance / _length) * 60;
        return speed;
    }
    public virtual int Pace()
    {
        pace = _length / _distance;
        return pace;
    }
    public string GetSummary()
    {
        return $"{_date} ({_length} min) - Distance {_distance}, Speed {speed} mph, Pace: {pace} min per mile";
    }
}