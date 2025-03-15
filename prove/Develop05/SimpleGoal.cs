public class SimpleGoal : Goal
{
    private bool completed;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        completed = false;
    }

    public override void RecordEvent()
    {
        completed = true;
    }

    public override bool IsComplete()
    {
        return completed;
    }

    public override string GetDetails()
    {
        return $"[ {(completed ? "X" : " ")} ] {name}";
    }

    public override string GetStringRepresentation()
    {
        return $"Simple:{name},{points},{completed}";
    }
}