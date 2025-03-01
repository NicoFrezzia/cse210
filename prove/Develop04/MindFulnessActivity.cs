using System;
using System.Threading;

abstract class MindfulnessActivity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public MindfulnessActivity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_activityName}");
        Console.WriteLine(_description);
        Console.Write("Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        ExecuteActivity();
        End();
    }

    protected abstract void ExecuteActivity();

    private void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {_activityName} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|\b"); Thread.Sleep(250);
            Console.Write("/\b"); Thread.Sleep(250);
            Console.Write("-\b"); Thread.Sleep(250);
            Console.Write("\\\b"); Thread.Sleep(250);
        }
        Console.WriteLine();
    }
}