public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    public override string ToString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromString(string data)
    {
        var parts = data.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);
    }
        public bool Contains(string searchTerm)
    {
        return _entryText.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) || 
               _promptText.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);
    }
}
