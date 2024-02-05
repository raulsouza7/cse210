public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _points += _bonus;
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString() => base.GetDetailsString() + $" Completed {_amountCompleted}/{_target} times";

    public override string GetStringRepresentation() => $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
}
