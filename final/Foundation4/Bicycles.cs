public class Bicycles : Activity
{

    public Bicycles(string activityType, int speed, int date, int length, int distance) : base(activityType, speed, date, length, distance)
    {
    }


    public override int Distance()
    {
        return _distance;
    }

    public override float Speed()
    {
        _speed = _distance / _length;
        return _speed;
    }

    public override int Pace()
    {
        throw new NotImplementedException();
    }

}