
public class ListingActivity : Activity
{
    private readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        // Add prompts here
    };

    public ListingActivity(int duration) : base(duration) {}

    public override void Start()
    {
        DisplayMessage("Listing Activity");
        DisplayMessage("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ");
        DisplayMessage($"Duration: {GetDuration()} seconds");
        DisplayMessage("Get ready to begin...");
        Thread.Sleep(3000);

        Random random = new Random();
        int count = 0;

        foreach (var prompt in prompts)
        {
            DisplayMessage(prompt);

            DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
            while (DateTime.Now < endTime)
            {
                string item = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(item))
                    break;

                count++;
            }
        }   

        DisplayCompletionMessage("Listing");
    }
}