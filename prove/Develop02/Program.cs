using System;
using System.Net;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option number: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Enter your Journal Entry: ");
                string entry = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                journal.AddEntry(prompt, entry, date);
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string saveFilename = Console.ReadLine();
                journal.SaveToFile(saveFilename);
                Console.WriteLine("Journal saved. ");
            }

            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string loadFilename = Console.ReadLine();
                journal.LoadFromFile(loadFilename);
                Console.WriteLine("Journal loaded. ");
            }

            else if (choice == "5")
            {
                Console.WriteLine("Exiting program...");
                return;
            }

            else
            {
                Console.WriteLine("Invalid option. Please try again. ");
            }
        }
    }
}