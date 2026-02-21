class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        Console.WriteLine("Points earned: " + this._points);
        return this._points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {this._name} ({this._description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{this._name}|{this._description}|{this._points}";
    }
}

