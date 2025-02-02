using System;
using System.Collections.Generic;

class PromptManager
{
    private static readonly List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public static string GetRandomPrompt()
    {
        Random random = new Random();
        return prompts[random.Next(prompts.Count)];
    }
}
