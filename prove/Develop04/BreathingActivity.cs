
public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) {}

    public override void Start()
    {
        DisplayMessage("Breathing Activity");
        DisplayMessage("This activity will help you relax by guiding you through deep breathing exercises.");
        DisplayMessage($"Duration: {GetDuration()} seconds");
        DisplayMessage("Get ready to begin...");
        Thread.Sleep(3000);

        for (int i = 0; i < GetDuration(); i++)
        {
            if (i % 2 == 0)
                DisplayMessage("Breathe in...");
            else
                DisplayMessage("Breathe out...");
            DisplayCountdown(3);
        }

        DisplayCompletionMessage("Breathing");
    }
}