using System;

namespace LibraryTracker
{
    public class LibraryItem
    {
        protected string Title { get; set; }
        protected string ItemType { get; set; }

        public LibraryItem(string title)
        {
            Title = title;
            ItemType = "Generic";
        }

        public virtual void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Type: {ItemType}");
        }
    }
}
