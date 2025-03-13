public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear(); 

        if (File.Exists(file))
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry();
                        entry._date = parts[0];
                        entry._promptText = parts[1];
                        entry._entryText = parts[2];
                        _entries.Add(entry);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}