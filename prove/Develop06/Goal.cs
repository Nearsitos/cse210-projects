using System;

abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    
    public Goal(string name)
    {
        Name = name;
    }

    public abstract void RecordGoal();
    
    public abstract void DisplayStatus();
}
