using System;

class Program
{
    static void Main(string[] args)
    {
        Task task1 = new WorkTask("Finish report", "Complete the quarterly report", "March 30", "Marketing");
        Task task2 = new PersonalTask("Go for a run", "Run 5km around the park", "March 28", "Health");

        task1.DisplayTask();
        task2.DisplayTask();
    }
}