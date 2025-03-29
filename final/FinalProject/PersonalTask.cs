using System;

public class PersonalTask : Task
{
    private string _category;

    public PersonalTask(string title, string description, string dueDate, string category)
        : base(title, description, dueDate)
    {
        _category = category;
    }

    public override void DisplayTask()
    {
        base.DisplayTask();
        Console.WriteLine($"Category: {_category}");
        Console.WriteLine();
    }
}