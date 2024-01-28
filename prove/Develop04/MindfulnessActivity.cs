using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    public string ActivityName { get; protected set; }
    protected string _description;
    protected int _duration;

    protected MindfulnessActivity(string name, string description)
    {
        ActivityName = name;
        _description = description;
    }

    protected void StartActivity()
    {
        Console.WriteLine($"Activity: {ActivityName}");
        Console.WriteLine($"{_description}");
        Console.WriteLine("Enter the duration of the activity in seconds:");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3000); // Spinner for 3 seconds delay
    }

    protected void EndActivity()
    {
        Console.WriteLine("You have done a good job!");
        ShowSpinner(2000); // Spinner for 2 seconds delay
        Console.WriteLine($"You have completed the {ActivityName} for {_duration} seconds.");
        ShowSpinner(3000); // Spinner for 3 seconds delay
    }

    public abstract void RunActivity();

    protected void ShowSpinner(int durationInMilliseconds)
    {
        var spinner = new char[] { '|', '/', '-', '\\' };
        int spinnerIndex = 0;
        DateTime endTime = DateTime.Now.AddMilliseconds(durationInMilliseconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("\r" + spinner[spinnerIndex++]);
            spinnerIndex %= spinner.Length;
            Thread.Sleep(100);
        }
        Console.Write("\r "); // Clear the spinner after completion
    }
}



