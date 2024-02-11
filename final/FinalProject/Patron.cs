using System;

namespace LibraryTracker
{
    public class Patron
    {
        private string Name { get; set; }

        public Patron(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Patron Name: {Name}");
        }
    }
}
