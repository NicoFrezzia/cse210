using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;
    private int level = 1;
    private int completedGoals = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
            score += goals[index].Points; 
            if (goals[index].IsComplete()) completedGoals++;

            LevelUp();
        }
    }

    private void LevelUp()
    {
        if (score >= level * 1000)
        {
            level++;
            Console.WriteLine($"🎉 You leveled up to Level {level}!");
        }

        if (completedGoals >= 5)
        {
            Console.WriteLine("🏅 You've earned the 'Goal Master' badge!");
        }
    }

    public void ShowGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
        }
        Console.WriteLine($"Score: {score} | Level: {level}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(score);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            score = int.Parse(lines[0]);

            goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(":");
                string type = parts[0];
                string[] data = parts[1].Split(",");

                switch (type)
                {
                    case "Simple":
                        SimpleGoal sg = new SimpleGoal(data[0], int.Parse(data[1]));
                        if (bool.Parse(data[2])) sg.RecordEvent();
                        goals.Add(sg);
                        break;
                    case "Eternal":
                        goals.Add(new EternalGoal(data[0], int.Parse(data[1])));
                        break;
                    case "Checklist":
                        ChecklistGoal cg = new ChecklistGoal(data[0], int.Parse(data[1]), int.Parse(data[3]), int.Parse(data[4]));
                        for (int j = 0; j < int.Parse(data[2]); j++) cg.RecordEvent();
                        goals.Add(cg);
                        break;
                    case "Negative":
                        goals.Add(new NegativeGoal(data[0], int.Parse(data[1])));
                        break;
                }
            }
        }
    }
}