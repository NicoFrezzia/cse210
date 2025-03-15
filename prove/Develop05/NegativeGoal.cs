public class NegativeGoal : Goal
{
    public NegativeGoal(string name, int points) : base(name, -points) { }

    public override void RecordEvent() { }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetails()
    {
        return $"[Bad Habit] {name}";
    }

    public override string GetStringRepresentation()
    {
        return $"Negative:{name},{points}";
    }
}