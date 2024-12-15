class EternalGoal : Goal
{
    public int TimesCompleted { get; private set; }

    public EternalGoal(string name, int points) : base(name)
    {
        Points = points;
        TimesCompleted = 0;
    }

    public override void RecordGoal()
    {
        TimesCompleted++;
        Console.WriteLine($"You've recorded {TimesCompleted} completion(s) of {Name} and earned {Points} points each time!");
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{Name}: Completed {TimesCompleted} times. Total points: {TimesCompleted * Points}");
    }
}
