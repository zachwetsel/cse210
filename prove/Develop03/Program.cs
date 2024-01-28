using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(reference, scriptureText);

        do
        {
            scripture.Display();
            Console.WriteLine("Press Enter to contine or tupe 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Exiting program...");
                return;
            }

            scripture.HideRandomWords();
        } while (!scripture.AllWordsHidden());
    }
}