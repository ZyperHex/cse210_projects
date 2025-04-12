public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {ShortName} ({Description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{ShortName}|{Description}|{Points}|{_isComplete}";
    }

    public void MarkComplete()
    {
        _isComplete = true;
    }
}