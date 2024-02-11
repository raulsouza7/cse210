using System;

namespace LibraryTracker
{
    public class Transaction
    {
        private LibraryItem Item { get; set; }
        private Patron Patron { get; set; }
        private DateTime TransactionDate { get; set; }

        public Transaction(LibraryItem item, Patron patron)
        {
            Item = item;
            Patron = patron;
            TransactionDate = DateTime.Now;
        }

        public void Display()
        {
            Console.WriteLine($"Transaction Date: {TransactionDate}");
            Item.Display();
            Patron.Display();
        }
    }
}
