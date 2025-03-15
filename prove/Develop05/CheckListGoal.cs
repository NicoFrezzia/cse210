public class ChecklistGoal : Goal
{
    private int target;
    private int current;
    private int bonus;

    public ChecklistGoal(string name, int points, int target, int bonus) : base(name, points)
    {
        this.target = target;
        this.current = 0;
        this.bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (current < target) current++;
    }

    public override bool IsComplete()
    {
        return current >= target;
    }

    public override string GetDetails()
    {
        string status = IsComplete() ? "X" : " ";
        return $"[ {status} ] {name} ({current}/{target})";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist:{name},{points},{current},{target},{bonus}";
    }
}