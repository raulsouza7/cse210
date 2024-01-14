using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _random = new Random();
        _prompts = new List<string>
        {
            // Prompts here
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What lesson did I learn today?",
            "How did I contribute to my community or family today?",
            "What made me smile today?",
            "What am I grateful for right now?",
            "What's one thing I did today that I'm proud of?",
            "What challenge did I overcome today?",
            "How have I grown or changed recently?",
            "What's something new I tried or experienced today?",
            "What was a peaceful moment for me today?",
            "Is there something I'm looking forward to tomorrow?"
            // ... other prompts
        };
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
