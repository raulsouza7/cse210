using System;
using System.Collections.Generic;
using System.Threading;

public class GratitudeActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a person you are grateful for.",
        "Recall a happy memory you are grateful for.",
        "Consider a skill or ability you are grateful to have.",
        "Reflect on a challenge you faced and overcame."
    };

    public GratitudeActivity() : base("Gratitude Activity", "This activity will help you reflect on what you are grateful for in your life.")
    {
    }

    public override void RunActivity()
    {
        StartActivity();
        Random rnd = new Random();
        int promptIndex = rnd.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptIndex]);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            // Pause for reflection, allowing user time to think
            Thread.Sleep(5000); // Pause for 5 seconds for reflection
            Console.WriteLine("Reflect on another aspect of gratitude...");
        }

        EndActivity();
    }
}

