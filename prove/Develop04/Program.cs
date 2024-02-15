using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Activities:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunActivity(new BreathingActivity(GetDuration()));
                    break;
                case "2":
                    RunActivity(new ReflectionActivity(GetDuration()));
                    break;
                case "3":
                    RunActivity(new ListingActivity(GetDuration()));
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void RunActivity(Activity activity)
    {
        activity.Start();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }

    private static int GetDuration()
    {
        Console.Write("Enter duration (in seconds): ");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine("Invalid duration. Please enter a positive integer.");
            Console.Write("Ender duration (in seconds): ");
        }
        return duration;
    }
}