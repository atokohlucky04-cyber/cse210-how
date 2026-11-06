
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int choice = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string response = Console.ReadLine();
            if (int.TryParse(response, out choice))
            {
                if (choice == 1)
                {
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string entryText = Console.ReadLine();

                    DateTime currentDateTime = DateTime.Now;
                    string dateText = currentDateTime.ToShortDateString();

                    Entry newEntry = new Entry();
                    newEntry._date = dateText;
                    newEntry._promptText = prompt;
                    newEntry._entryText = entryText;

                    theJournal.AddEntry(newEntry);
                }
                else if (choice == 2)
                {
                    theJournal.DisplayAll();
                }
                else if (choice == 3)
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    theJournal.SaveToFile(filename);
                }
                else if (choice == 4)
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    theJournal.LoadFromFile(filename);
                }
            }
        }
    }
}