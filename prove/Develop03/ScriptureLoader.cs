using System;
using System.Collections.Generic;
using System.IO;

public static class ScriptureLoader
{
    public static List<Scripture> LoadScriptures(string filePath)
    {
        // Use a relative path from the project's root directory
        string projectRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        string fullFilePath = Path.Combine(projectRoot, filePath);

        var scriptures = new List<Scripture>();
        var lines = File.ReadAllLines(fullFilePath);

        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length == 2)
            {
                scriptures.Add(new Scripture(parts[0], parts[1]));
            }
        }

        return scriptures;
    }
}



