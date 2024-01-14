using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            var entry = Entry.FromString(line);
            _entries.Add(entry);
        }
    }

        public void ClearAllEntries()
    {
        _entries.Clear();
        Console.WriteLine("All journal entries have been deleted.");
    }
}
