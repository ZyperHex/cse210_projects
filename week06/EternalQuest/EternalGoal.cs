public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Has registrado el objetivo eterno \"{ShortName}\" y ganado {Points} puntos.");
    }

    public override bool IsComplete()
    {
        return false; // Never complete the eternal goal
    }

    public override string GetDetailsString()
    {
        return $"[∞] {ShortName} ({Description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{ShortName}|{Description}|{Points}";
    }
}