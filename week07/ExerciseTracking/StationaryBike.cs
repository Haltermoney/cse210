public class StationaryBike : Activity
{
    private string _speed;

    public StationaryBike(string date, string time, string speed) : base(date, time)
    {
        _date = date;
        _time = time;
        _speed = speed;
    }

    public override string GetSummary()
    {
        double pace = 60 / double.Parse(_speed);
        double distance = pace / 60 * double.Parse(_time);
        return $"{_date} Stationary Bike ({_time})- Distance {distance} miles, Speed: {_speed} mph, Pace: {pace} min per mile";
    }
}