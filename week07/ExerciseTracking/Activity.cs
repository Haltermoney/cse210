public class Activity
{
    protected string _time;
    protected string _date;

    public Activity(string date, string time)
    {
        _date = date;
        _time = time;
    }

    public virtual string GetSummary()
    {
        return $"{_date} ({_time}min)";
    }
}