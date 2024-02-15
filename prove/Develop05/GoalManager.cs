
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's Score: {_score}");
    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            string completionString = "";
            if (goal.IsComplete())
            {
                completionString = "Completed";
            }
            else if (goal.IsChecklistGoal())
            {
                completionString = ((ChecklistGoal)goal).GetAmountCompleted() + "/" + ((ChecklistGoal)goal).GetTarget();
            }
            else
            {
                completionString = "Not Completed";
            }
            
            Console.WriteLine($"Name: {goal.GetShortName()}, Description: {goal.GetDescription()}, Points: {goal.GetPoints()}, Completion Rate: {completionString}" + (goal.IsChecklistGoal() ? $", Target: {goal.GetTarget()}, Bonus: {goal.GetBonus()}" : ""));
        }
    }
    public void CreateGoal(string name, string description, int points, bool eternal, int target = 0, int bonus = 0)
    {
        if (target == 0 || bonus == 0)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (eternal == true)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else
        {
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }
    public void RecordEvent(string name)
    {
        Goal goal = _goals.FirstOrDefault(g => g.GetShortName() == name);
        if (goal != null)
        {
            goal.RecordEvent();
            _score += goal.GetPoints();
        }
        else
        {
            Console.WriteLine("Goal not found");
        }
    }
   public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                string representation = goal.GetStringRepresentation();
                Console.WriteLine("Saving goal: " + representation); // Debugging output
                writer.WriteLine(representation);
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 3)
                {
                    string shortName = parts[0].Split(':')[1].Trim();
                    string description = parts[1].Split(':')[1].Trim();
                    int points = int.Parse(parts[2].Split(':')[1].Trim());
                    int amountCompleted = 0;
                    int target = 0;
                    int bonus = 0;
                    if (parts.Length > 3)
                    {
                        string[] completionParts = parts[3].Split(':')[1].Trim().Split('/');
                        if (completionParts.Length == 2)
                        {
                            amountCompleted = int.Parse(completionParts[0]);
                            target = int.Parse(completionParts[1]);
                        }
                    }
                    if (parts.Length > 4)
                    {
                        bonus = int.Parse(parts[4].Split(':')[1].Trim());
                    }
                    if (target == 0)
                    {
                        _goals.Add(new SimpleGoal(shortName, description, points));
                    }
                    else if (bonus == 0)
                    {
                        _goals.Add(new EternalGoal(shortName, description, points));
                    }
                    else
                    {
                        _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
                    }
                }
                else
                {
                    // Handle invalid line format
                    Console.WriteLine("Invalid line format: " + line);
                }
            }
        }
    }
}