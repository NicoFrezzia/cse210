using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response, string mood)
    {
        entries.Add(new Entry(prompt, response, mood));
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        File.WriteAllLines(filename, entries.ConvertAll(e => e.ToString()));
        Console.WriteLine("Journal saved in CSV format.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        entries.Clear();
        foreach (var line in File.ReadLines(filename))
        {
            var parts = line.Split(',');
            if (parts.Length == 4)
                entries.Add(new Entry(parts[1], parts[2], parts[3]));
        }
        Console.WriteLine("Journal loaded from CSV.");
    }
}