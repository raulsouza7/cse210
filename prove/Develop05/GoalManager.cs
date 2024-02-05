using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Goal Tracker");
            Console.WriteLine("1. List Goals");
            Console.WriteLine("2. Add Goal");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ListGoals();
                    break;
                case "2":
                    AddGoal();
                    break;
                case "3":
                    RecordGoalEvent();
                    break;
                case "4":
                    DisplayScore();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("\nCurrent Goals:");
        int index = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index++}. {goal.GetDetailsString()}");
        }
    }

    private void AddGoal()
    {
        Console.WriteLine("\nAdd New Goal");
        Console.Write("Enter goal type (Simple, Eternal, Checklist): ");
        string type = Console.ReadLine().ToLower();
        Console.Write("Short Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

        switch (type)
        {
            case "simple":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "eternal":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "checklist":
                Console.Write("Target: ");
                int target = int.TryParse(Console.ReadLine(), out result) ? result : 0;
                Console.Write("Bonus: ");
                int bonus = int.TryParse(Console.ReadLine(), out result) ? result : 0;
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        Console.WriteLine("Goal added successfully.");
    }

    private void RecordGoalEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }

        ListGoals();
        Console.Write("Select a goal by entering its index: ");
        int index = int.TryParse(Console.ReadLine(), out int result) ? result - 1 : -1;
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index].Points; // Adjusted to use the public property
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private void DisplayScore()
    {
        Console.WriteLine($"\nCurrent Score: {_score}");
    }

    private void SaveGoals()
    {
        using (StreamWriter file = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
            Console.WriteLine("Goals saved successfully.");
        }
    }

    private void LoadGoals()
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                    break;
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}
