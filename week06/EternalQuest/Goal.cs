using System.Security.Cryptography.X509Certificates;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        if (IsComplete() == false)
        {
            return $"[ ] {_shortName} ({_description})";
        }
        else
        {
            return $"[X] {_shortName} ({_description})";
        }
    }

    public virtual string GetStringRepresentation()
    {
        return _shortName;
    }
}