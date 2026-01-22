using System;

public class Entry
{
    public string _promptText;
    public string _entryText;
    public string _date;

    public Entry(string prompt, string entry, string date = "")
    {
        _promptText = prompt;
        _entryText = entry;
        _date = date == "" ? DateTime.Now.ToShortDateString() : date;
    }

public void Display()
{
    Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
    Console.WriteLine(_entryText);
}
}