public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points) {}

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation() => $"SimpleGoal,{_shortName},{_description},{_points},{_isComplete}";
}
