public class Swimming : Activity
{
    private string _laps;

    public Swimming(string date, string time, string laps) : base(date, time)
    {
        _date = date;
        _time = time;
        _laps = laps;
    }

    public override string GetSummary()
    {
        double dist = double.Parse(_laps) * 50 / 1000 * 0.62;
        string distance = dist.ToString("F2");
        double spee = dist / double.Parse(_time) * 60;
        string speed = spee.ToString("F2");
        double pac = 60 / spee;
        string pace = pac.ToString("F2");
        return $"{_date} Stationary Bike ({_time})- Distance {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }
}