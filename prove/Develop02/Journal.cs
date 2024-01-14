using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

    public void SearchEntries(string searchTerm)
    {
        var foundEntries = _entries.Where(entry => entry.Contains(searchTerm)).ToList();

        if (foundEntries.Any())
        {
            foreach (var entry in foundEntries)
            {
                entry.Display();
            }
        }
        else
        {
            Console.WriteLine("No entries found matching the search term.");
        }
    }
}
