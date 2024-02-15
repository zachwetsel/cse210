using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event (accomplished goal)");
            Console.WriteLine("3. Display player's information");
            Console.WriteLine("4. List all goal names");
            Console.WriteLine("5. List details of all goals");
            Console.WriteLine("6. Save goals to a file");
            Console.WriteLine("7. Load goals from a file");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter goal short name: ");
                    string shortName = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points;
                    if (!int.TryParse(Console.ReadLine(), out points))
                    {
                        Console.WriteLine("Invalid points! Please enter a number.");
                        break;
                    }
                    Console.Write("Is this an eternal goal (Y/N)? Eternal goals are those that are never completed such as reading every day.");
                    bool eternal = false;
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        eternal = true;
                    }
                    Console.Write("Enter target for Checklist Goal. 0 if other goal.): ");
                    int target;
                    if (!int.TryParse(Console.ReadLine(), out target))
                    {
                        Console.WriteLine("Invalid target! Please enter a number.");
                        break;
                    }
                    Console.Write("Enter bonus (0 if not applicable): ");
                    int bonus;
                    if (!int.TryParse(Console.ReadLine(), out bonus))
                    {
                        Console.WriteLine("Invalid bonus! Please enter a number.");
                        break;
                    }
                    goalManager.CreateGoal(shortName, description, points, eternal, target, bonus);
                    Console.WriteLine("Goal created successfully.");
                    break;
                case 2:
                    Console.Write("Enter goal short name: ");
                    string eventShortName = Console.ReadLine();
                    goalManager.RecordEvent(eventShortName);
                    Console.WriteLine("Event recorded successfully.");
                    break;
                case 3:
                    goalManager.DisplayPlayerInfo();
                    break;
                case 4:
                    goalManager.ListGoalNames();
                    break;
                case 5:
                    goalManager.ListGoalDetails();
                    break;
                case 6:
                    Console.Write("Enter filename to save goals: ");
                    string saveFilename = Console.ReadLine();
                    goalManager.SaveGoals(saveFilename);
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case 7:
                    Console.Write("Enter filename to load goals: ");
                    string loadFilename = Console.ReadLine();
                    goalManager.LoadGoals(loadFilename);
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case 8:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 8.");
                    break;
                        
            }
        }
    }
}