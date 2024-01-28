
class Word{
    public string Text {get; private set; }
    public bool Hidden { get; private set; }

    public Word(string text, bool hidden = false)
    {
        Text = text;
        Hidden = hidden;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public void Display()
    {
        if (Hidden)
        {
            Console.Write("_____ ");
        }
        else
        {
            Console.Write($"{Text} ");
        }
    }
}