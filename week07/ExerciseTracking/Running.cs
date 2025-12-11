public class Running : Activity
{
    private string _distance;

    public Running(string date, string time, string distance) : base(date, time)
    {
        _date = date;
        _time = time;
        _distance = distance;
    }

    public override string GetSummary()
    {
        double speed = double.Parse(_distance) / double.Parse(_time) * 60;
        double pace = double.Parse(_time) / double.Parse(_distance);
        return $"{_date} Running ({_time})- Distance {_distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }
}