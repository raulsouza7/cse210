using System;

namespace LibraryTracker
{
    public class Book : LibraryItem
    {
        private string Author { get; set; }

        public Book(string title, string author) : base(title)
        {
            Author = author;
            ItemType = "Book";
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Author: {Author}");
        }
    }
}
