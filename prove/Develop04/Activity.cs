
public abstract class Activity
{
    private int _duration;

    public Activity(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public abstract void Start();
    protected void DisplayMessage(string message)
    {
        Console.WriteLine(message);
        Thread.Sleep(2000);
    }
    protected void DisplayCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i}");
            Thread.Sleep(1000);
        }
    }
    protected virtual void DisplayCompletionMessage(string Activity)
    {
        Console.WriteLine($"Good job! You have completed the {Activity} activity.");
    }
}