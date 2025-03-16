public abstract class Goal
{
    protected string name;
    protected int points;

    
    public int Points
    {
        get { return points; }
    }

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetails();
    public abstract string GetStringRepresentation();
}