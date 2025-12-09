public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }

    public override string GetStringRepresentation()
    {
        if (IsComplete() == false)
        {
            return $"EternalGoal~~~{_shortName}~~~{_description}~~~{_points}";
        }
        else
        {
            return $"EternalGoal~~~{_shortName}~~~{_description}~~~{_points}";
        }
    }
}