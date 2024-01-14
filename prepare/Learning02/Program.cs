#define RESUME // Change this to JOURNAL or RESUME

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
#if JOURNAL
        // Journal Assignment Code
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("Journal Application");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Delete all entries");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    WriteNewEntry(myJournal, promptGenerator);
                    break;
                case 2:
                    myJournal.DisplayAll();
                    break;
                case 3:
                    SaveJournal(myJournal);
                    break;
                case 4:
                    LoadJournal(myJournal);
                    break;
                case 5:
                    myJournal.ClearAllEntries();
                    break;    
                case 6:
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

#elif RESUME
        // Resume Assignment Code
        Job job1 = new Job { _company = "Microsoft", _jobTitle = "Software Engineer", _startYear = 2019, _endYear = 2022 };
        Job job2 = new Job { _company = "Apple", _jobTitle = "Manager", _startYear = 2022, _endYear = 2023 };

        Resume resume = new Resume { _personName = "Allison Rose" };
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
#endif
    }

#if JOURNAL
    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Today's prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry(date, prompt, response);
        journal.AddEntry(newEntry);
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved.");
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded.");
    }
#endif
}
