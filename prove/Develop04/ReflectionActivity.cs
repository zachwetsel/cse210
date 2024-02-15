
public class ReflectionActivity : Activity
{
    private readonly string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        // Insert more prompts here
    };

    private readonly string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        // Insert more questions here
    };

    public ReflectionActivity(int duration) : base(duration) {}

    public override void Start()
    {
        DisplayMessage("Reflection Activity");
        DisplayMessage("This activity will help you reflect on times in your life when you have shown strength and resiliene.");
        DisplayMessage($"Duration: {GetDuration()} seconds");
        DisplayMessage("Get ready to begin...");
        Thread.Sleep(3000);

        Random random = new Random();

        foreach (var prompt in prompts)
        {
            DisplayMessage(prompt);

            foreach (var question in questions)
            {
                DisplayMessage(question);
                DisplayCountdown(5);
            }
        }

        DisplayCompletionMessage("Reflection");
    }
}