using System;

namespace LibraryTracker
{
    public class DVD : LibraryItem
    {
        private string Director { get; set; }

        public DVD(string title, string director) : base(title)
        {
            Director = director;
            ItemType = "DVD";
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Director: {Director}");
        }
    }
}
