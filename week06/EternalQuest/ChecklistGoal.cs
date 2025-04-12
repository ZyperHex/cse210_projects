public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int AmountCompleted
    {
        get { return _amountCompleted; }
        set { _amountCompleted = value; }
    }

    public int Target
    {
        get { return _target; }
        set { _target = value; }
    }

    public int Bonus
    {
        get { return _bonus; }
        set { _bonus = value; }
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {ShortName} ({Description}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{ShortName}|{Description}|{Points}|{_bonus}|{_target}|{_amountCompleted}";
    }

    public int GetEarnedPoints()
    {
        if (IsComplete() && _amountCompleted == _target)
        {
            return Points + Bonus;
        }
        return Points;
    }

    
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
}