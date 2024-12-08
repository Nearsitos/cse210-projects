using System;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?"
    };

    protected override void StartActivity()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life.");
        Console.WriteLine("You will list as many things as you can in a certain area.");

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {prompt}");

        Console.WriteLine("Take a moment to think about your answer...");
        Pause(3);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            count++;
            Console.WriteLine($"You have listed {count} items so far.");
        }

        Console.WriteLine($"You listed {count} items during this activity.");
    }
}