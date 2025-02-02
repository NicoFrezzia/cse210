using System;

class Entry
{
    public string Date { get; }
    public string Prompt { get; }
    public string Response { get; }
    public string Mood { get; } // New field to store user's mood

    public Entry(string prompt, string response, string mood)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    public override string ToString()
    {
        return $"{Date},{Prompt},{Response},{Mood}";
    }
}