using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Task> tasks = new List<Task>();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nTask Manager");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task Complete");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("What type of task? (1: Work, 2: Personal)");
                string type = Console.ReadLine();

                Console.Write("Enter title: ");
                string title = Console.ReadLine();
                Console.Write("Enter description: ");
                string description = Console.ReadLine();
                Console.Write("Enter due date: ");
                string dueDate = Console.ReadLine();

                if (type == "1")
                {
                    Console.Write("Enter work project name: ");
                    string project = Console.ReadLine();
                    tasks.Add(new WorkTask(title, description, dueDate, project));
                }
                else if (type == "2")
                {
                    Console.Write("Enter category: ");
                    string category = Console.ReadLine();
                    tasks.Add(new PersonalTask(title, description, dueDate, category));
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nAll Tasks:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"Task #{i + 1}:");
                    tasks[i].DisplayTask();
                }
            }
            else if (choice == "3")
            {
                Console.Write("Enter the task number to mark as complete: ");
                int num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= tasks.Count)
                {
                    tasks[num - 1].MarkComplete();
                    Console.WriteLine("Task marked as complete.");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            else if (choice == "4")
            {
                isRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }

        Console.WriteLine("Goodbye!");
    }
}