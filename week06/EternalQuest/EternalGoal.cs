class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal goal event recorded for {this._shortName}");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[EternalGoal] {this._shortName} - {this._description} ({this._points} points)";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{this._shortName}|{this._description}|{this._points}";
    }
}

