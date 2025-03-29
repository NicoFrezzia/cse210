using System;

public class WorkTask : Task
{
    private string _workProject;

    public WorkTask(string title, string description, string dueDate, string workProject)
        : base(title, description, dueDate)
    {
        _workProject = workProject;
    }

    public override void DisplayTask()
    {
        base.DisplayTask();
        Console.WriteLine($"Project: {_workProject}");
        Console.WriteLine();
    }
}