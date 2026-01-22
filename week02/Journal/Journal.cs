using System;

public class Journal
{
    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        Console.WriteLine("salvandoo");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine( $"{e._date}||{e._promptText}||{e._entryText}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        _entries = [];
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("||");
            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            Entry e = new Entry(prompt, entry, date);
            _entries.Add(e);
        }
    }
}
