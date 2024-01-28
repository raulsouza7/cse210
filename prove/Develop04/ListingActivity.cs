using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "List the people that you appreciate.",
        "List your personal strengths.",
        "List the people you have helped this week.",
        "List the times you felt joy this month."
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life.")
    {
    }

    public override void RunActivity()
    {
        StartActivity();
        Random rnd = new Random();
        int promptIndex = rnd.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptIndex]);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Enter an item:");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                count++;
            }
        }

        Console.WriteLine($"Total items listed: {count}");
        EndActivity();
    }
}


