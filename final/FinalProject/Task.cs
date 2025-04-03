using System;

public class Task
{
    private string _title;
    private string _description;
    private string _dueDate;
    private bool _isComplete;

    public Task(string title, string description, string dueDate)
    {
        _title = title;
        _description = description;
        _dueDate = dueDate;
        _isComplete = false;
    }

    public void MarkComplete()
    {
        _isComplete = true;
    }

    public virtual void DisplayTask()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Due Date: {_dueDate}");
        Console.WriteLine($"Completed: {_isComplete}\n");
    }
}