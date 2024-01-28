using System;
using System.IO;

public static class ActivityLog
{
    private static string _logFilePath = "ActivityLog.txt";

    public static void RecordActivity(string activityName)
    {
        try
        {
            using (StreamWriter sw = File.AppendText(_logFilePath))
            {
                sw.WriteLine($"{DateTime.Now} - Completed: {activityName}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error writing to log: {e.Message}");
        }
    }
}



