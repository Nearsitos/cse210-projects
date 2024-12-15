using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        goals.Add(new SimpleGoal("Run a Marathon", 1000));
        goals.Add(new EternalGoal("Read Scriptures", 100));
        goals.Add(new ChecklistGoal("Attend the Temple", 50, 10, 500));

        Console.WriteLine("Welcome to Eternal Quest!");
        
        Console.WriteLine("\nCurrent Goal Status:");
        foreach (var goal in goals)
        {
            goal.DisplayStatus();
        }

        Console.WriteLine("\nRecording goals progress...");
        goals[1].RecordGoal();
        goals[2].RecordGoal();
        goals[2].RecordGoal();
        
        Console.WriteLine("\nUpdated Goal Status:");
        foreach (var goal in goals)
        {
            goal.DisplayStatus();
        }
    }
}