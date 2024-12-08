using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    protected override void StartActivity()
    {
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(3); // Pause for 3 seconds
            Console.WriteLine("Breathe out...");
            Pause(3); // Pause for 3 seconds
        }
    }
}