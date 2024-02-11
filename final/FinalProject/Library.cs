using System;
using System.Collections.Generic;

namespace LibraryTracker
{
    public class Library
    {
        private List<LibraryItem> Items { get; }
        private List<Patron> Patrons { get; }
        private List<Transaction> Transactions { get; }

        public Library()
        {
            Items = new List<LibraryItem>();
            Patrons = new List<Patron>();
            Transactions = new List<Transaction>();
        }

        public void AddItem(LibraryItem item)
        {
            Items.Add(item);
        }

        public void AddPatron(Patron patron)
        {
            Patrons.Add(patron);
        }

        public void CheckOut(LibraryItem item, Patron patron)
        {
            Transactions.Add(new Transaction(item, patron));
        }

        public void DisplayTransactions()
        {
            foreach (var transaction in Transactions)
            {
                transaction.Display();
                Console.WriteLine();
            }
        }
    }
}
