class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name)
    {
        Points = points;
    }

    public override void RecordGoal()
    {
        Console.WriteLine($"You've completed the goal: {Name} and earned {Points} points!");
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{Name}: Completed! Earned {Points} points.");
    }
}
