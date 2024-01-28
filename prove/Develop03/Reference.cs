
using System.Dynamic;

class Reference
{
    public string Book {get; }
    public int Chapter {get; }
    public int StartVerse {get; }
    public int EndVerse {get; }

    public Reference(string book, int chapter, int startVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public void Display()
    {
        if (StartVerse == EndVerse)
        {
            Console.WriteLine($"{Book} {Chapter}:{StartVerse}");
        }
        else
        {
            Console.WriteLine($"{Book} {Chapter};{StartVerse}-{EndVerse}");
        }
    }
}