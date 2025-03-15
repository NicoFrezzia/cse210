using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("\nEternal Quest Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n4. Negative Goal");
                Console.Write("Choose goal type: ");
                string goalType = Console.ReadLine();
                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();
                Console.Write("Enter points: ");
                int points = int.Parse(Console.ReadLine());

                if (goalType == "1")
                {
                    manager.AddGoal(new SimpleGoal(name, points));
                }
                else if (goalType == "2")
                {
                    manager.AddGoal(new EternalGoal(name, points));
                }
                else if (goalType == "3")
                {
                    Console.Write("Enter number of times to complete: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.AddGoal(new ChecklistGoal(name, points, target, bonus));
                }
                else if (goalType == "4")
                {
                    manager.AddGoal(new NegativeGoal(name, points));
                }
            }
            else if (choice == "2")
            {
                manager.ShowGoals();
            }
            else if (choice == "3")
            {
                manager.ShowGoals();
                Console.Write("Enter goal number to record: ");
                int num = int.Parse(Console.ReadLine());
                manager.RecordEvent(num - 1);
            }
            else if (choice == "4")
            {
                manager.SaveGoals("goals.txt");
                Console.WriteLine("Goals saved.");
            }
            else if (choice == "5")
            {
                manager.LoadGoals("goals.txt");
                Console.WriteLine("Goals loaded.");
            }
        }
    }
}