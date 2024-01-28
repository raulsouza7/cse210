using System;

class Program
{
    static void Main(string[] args)
    {
        // Main program loop
        while (true)
        {
            // Display menu options to the user
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Choose an activity: \n1. Breathing \n2. Reflection \n3. Listing \n4. Gratitude \n5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            MindfulnessActivity activity;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    activity.RunActivity();
                    ActivityLog.RecordActivity(activity.ActivityName);
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    activity.RunActivity();
                    ActivityLog.RecordActivity(activity.ActivityName);
                    break;
                case 3:
                    activity = new ListingActivity();
                    activity.RunActivity();
                    ActivityLog.RecordActivity(activity.ActivityName);
                    break;
                case 4:
                    activity = new GratitudeActivity();
                    activity.RunActivity();
                    ActivityLog.RecordActivity(activity.ActivityName);
                    break;
                case 5:
                    return; // Exit option
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    // Extra feature: Activity logging implemented, Spinner animation and Gratitude Activity added
}