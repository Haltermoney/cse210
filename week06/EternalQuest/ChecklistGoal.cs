using System.Collections.Specialized;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, string points, int bonus, int target, int amountCompleted) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }

    public override string GetDetailsString()
    {
        if (_amountCompleted != _target)
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[X] {_shortName} ({_description})";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal~~~{_shortName}~~~{_description}~~~{_points}~~~{_bonus}~~~{_target}~~~{_amountCompleted}";
    }
}