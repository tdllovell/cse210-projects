using System;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> _journalEntries = new List<Entry>();
        FileMnger saver = new FileMnger();

        Console.WriteLine("Welcome to your digital journal!");
        int selectedOption = 0;
        while (selectedOption != 5)
        {
            Console.WriteLine();
            Console.WriteLine("You can:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. View all written entries");
            Console.WriteLine("3. Save your journal");
            Console.WriteLine("4. Load a journal");
            Console.WriteLine("5. Quit");
            Console.Write("Which do you choose? ");
            selectedOption = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (selectedOption == 1)
            {
                Entry newEntry = new Entry();
                newEntry.CreateJournalEntry();
                _journalEntries.Add(newEntry);
                Console.WriteLine("Entry created!");
            }
            else if (selectedOption == 2)
            {
                foreach (Entry entry in _journalEntries)
                {
                    entry.DisplayEntry();
                }
            }
            else if (selectedOption == 3)
            {
                saver.SaveEntries(_journalEntries);
            }
            else if (selectedOption == 4)
            {
                _journalEntries = saver.LoadEntries();
            }
            else if (selectedOption == 5) { }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                Console.WriteLine();
            }
        }
    }

}