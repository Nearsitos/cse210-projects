using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
        );

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input?.ToLower() == "quit") break;
            scripture.HideWords();
        }

        Console.Clear();
        Console.WriteLine("Scripture memorization complete!");
        scripture.Display();
    }
}
