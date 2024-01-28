using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void RunActivity()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(4000); // Spinner for 4 seconds breathing in
            Console.WriteLine("Breathe out...");
            ShowSpinner(4000); // Spinner for 4 seconds breathing out
        }
        EndActivity();
    }
}


