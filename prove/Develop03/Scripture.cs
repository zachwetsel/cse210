
class Scripture
{
    private List<Word> words;
    private Reference reference;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        InititializeWords(text);
    }

    private void InititializeWords(string text)
    {
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        reference.Display();
        foreach (var word in words)
        {
            word.Display();
        }
        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordToHide = Math.Max(words.Count(w => !w.Hidden) / 3, 1);

        for (int i = 0; i< wordToHide; i++)
        {
            int index = random.Next(words.Count);
            while (words[index].Hidden)
            {
                index = random.Next(words.Count);
            }
            words[index].Hide();
        }
    }
    public bool AllWordsHidden()
    {
        return words.All(w => w.Hidden);
    }
}