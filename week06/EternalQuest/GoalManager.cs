class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        this._goals = new List<Goal>();
        this._score = 0;
    }

    public void Start()
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine();

            DisplayMenu();
            Console.WriteLine("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1) CreateGoal();
            else if (choice == 2) ListGoalNames();
            else if (choice == 3) SaveGoals();
            else if (choice == 4) LoadGoals();
            else if (choice == 5) RecordEvent();

            Console.WriteLine();
            DisplayPlayerInfo();
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {this._score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in this._goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in this._goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        DisplayGoalOptions();
        int goalType = int.Parse(Console.ReadLine());

        if (goalType < 1 || goalType > 3)
        {
            Console.WriteLine("Invalid goal type selected.");
            return;
        }

        Goal goal = null;

        Console.WriteLine("Goal Title: ");
        string goalName = Console.ReadLine();
        Console.WriteLine("Goal Description: ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("Goal Points: ");
        int goalPoints = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            goal = new SimpleGoal(goalName, goalDescription, goalPoints);
        }
        else if (goalType == 2)
        {
            goal = new EternalGoal(goalName, goalDescription, goalPoints);
        }
        else if (goalType == 3)
        {
            Console.WriteLine("Target : ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Bonus Points for total conclusion: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal(goalName, goalDescription, goalPoints, bonusPoints, target);
        }

        this._goals.Add(goal);
    }

    public void RecordEvent()
    {
        this.ListGoalNames();
        Console.WriteLine();
        Console.WriteLine("Enter the index of the goal to record an event: ");
        int goalIndex = int.Parse(Console.ReadLine());


        if (goalIndex >= 0 && goalIndex < this._goals.Count)
        {
            Goal goal = this._goals[goalIndex];
            
            if (goal.IsComplete())
            {
                Console.WriteLine("This goal is already complete.");
                return;
            }

            this._score += goal.RecordEvent();
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("File name to save goals: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(this._score);
            foreach (var goal in this._goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved to file: " + fileName);
    }

    public void LoadGoals()
    {
        Console.WriteLine("File name to load goals: ");
        string fileName = Console.ReadLine();

        this._goals.Clear();
        this._score = int.Parse(File.ReadAllLines(fileName)[0]);

        foreach (var line in File.ReadAllLines(fileName).Skip(1))
        {
            var parts = line.Split('|');
            var goalType = parts[0];
            Goal goal = null;

            if (goalType == "SimpleGoal")
            {
                goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
            }
            else if (goalType == "EternalGoal")
            {
                goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            }
            else if (goalType == "ChecklistGoal")
            {
                goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
            }

            if (goal != null)
            {
                this._goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded from file: " + fileName);

    }

    private void DisplayGoalOptions()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
    }

    private void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goas");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Exit");
    }
}