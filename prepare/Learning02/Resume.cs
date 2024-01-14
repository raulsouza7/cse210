using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _personName;
    public List<Job> _jobs;

    // Constructor
    public Resume()
    {
        _jobs = new List<Job>();
    }

    // Method to display resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}
