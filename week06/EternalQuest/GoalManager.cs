public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYour current score is: {_score} points.\n");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("What kind of goal do you want to create?");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Option: ");
        string choice = Console.ReadLine();

        Console.Write("Short Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Necessary amount to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Extra points for completed task: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }

        Console.WriteLine("Goal created successfully!\n");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you complete?");
        ListGoalNames();
        Console.Write("Number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            int prevScore = _score;

            if (goal is ChecklistGoal checklist)
            {
                checklist.RecordEvent();
                _score += checklist.GetEarnedPoints();
            }
            else
            {
                goal.RecordEvent();
                _score += goal.Points;
            }

            Console.WriteLine($"New Score is: {_score} points.\n");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Name of the file to save: ");
        string file = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Progress Saved.\n");
    }

    public void LoadGoals()
    {
        Console.Write("Name of the file to load: ");
        string file = Console.ReadLine();

        if (File.Exists(file))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(file);
            if (lines.Length > 0)
            {
                _score = int.Parse(lines[0]);
            }
            else
            {
                _score = 0;
            }

            for (int i = 1; i < lines.Length; i++)
            {
                try
                {
                    string[] parts = lines[i].Split(':');
                    string type = parts[0];
                    string[] data = parts[1].Split('|');

                    switch (type)
                    {
                        case "SimpleGoal":
                            SimpleGoal sg = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                            if (bool.Parse(data[3])) sg.MarkComplete();
                            _goals.Add(sg);
                            break;

                        case "EternalGoal":
                            _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                            break;

                        case "ChecklistGoal":
                            ChecklistGoal cg = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3]));
                            cg.SetAmountCompleted(int.Parse(data[5]));
                            _goals.Add(cg);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error loading line {i + 1}: {e.Message}");
                }
            }

            Console.WriteLine("Progress loaded.\n");
        }
        else
        {
            Console.WriteLine("Error, file not found.\n");
        }
    }
}