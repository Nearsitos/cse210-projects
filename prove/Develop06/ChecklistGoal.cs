class ChecklistGoal : Goal
{
    public int GoalCount { get; set; }
    public int TimesCompleted { get; private set; }
    public int Bonus { get; set; }

    public ChecklistGoal(string name, int points, int goalCount, int bonus) : base(name)
    {
        Points = points;
        GoalCount = goalCount;
        Bonus = bonus;
        TimesCompleted = 0;
    }

    public override void RecordGoal()
    {
        TimesCompleted++;
        int currentPoints = TimesCompleted * Points;
        if (TimesCompleted == GoalCount)
        {
            currentPoints += Bonus;
            Console.WriteLine($"You've completed all {GoalCount} steps of {Name} and earned a bonus of {Bonus} points! Total points: {currentPoints}");
        }
        else
        {
            Console.WriteLine($"You've completed step {TimesCompleted}/{GoalCount} of {Name} and earned {Points} points this time.");
        }
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{Name}: Completed {TimesCompleted}/{GoalCount} times. Total points: {TimesCompleted * Points + (TimesCompleted == GoalCount ? Bonus : 0)}");
    }
}
