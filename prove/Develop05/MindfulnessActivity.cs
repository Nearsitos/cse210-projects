using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected int duration;

    public void Start()
    {
        // Common starting message
        Console.WriteLine("Welcome to the activity!");
        Console.WriteLine("You will perform the activity for a certain duration.");
        Console.Write("Please enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare yourself... Press Enter to begin.");
        Console.ReadLine();
        StartActivity();
        End();
    }

    protected abstract void StartActivity();

    private void End()
    {
        // Common ending message
        Console.WriteLine("Well done! You have completed the activity.");
        Console.WriteLine($"You spent {duration} seconds on this activity.");
        Console.WriteLine("Take a moment to reflect on your experience.");
        Pause(3); // Pauses for 3 seconds
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}