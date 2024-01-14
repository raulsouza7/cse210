using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
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
            Console.WriteLine("7. Search entries");
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
                case 7:
                    Console.Write("Enter search term: ");
                    string searchTerm = Console.ReadLine();
                    myJournal.SearchEntries(searchTerm);
                    break;      
                case 6:
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

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
}
