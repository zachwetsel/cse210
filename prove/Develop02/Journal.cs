
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

// Method to add a new entry
    public void AddEntry(string _promptText, string _entryText, string _date)
    {
        Entry entry = new Entry(_promptText, _entryText, _date);
        _entries.Add(entry);
    }

// Method to display all entries
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

// Method to save the journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

// Method to load the journal from a file
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string _date = parts[0];
                        string _promptText = parts[1];
                        string _entryText = parts[2];
                        _entries.Add(new Entry(_promptText, _entryText, _date));
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}