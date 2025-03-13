class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        promptGenerator promptGenerator = new promptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, promptGenerator);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    SaveJournal(journal);
                    break;
                case "4":
                    LoadJournal(journal);
                    break;
                case "5":
                    return; 
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal, promptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); 
        newEntry._promptText = prompt;
        newEntry._entryText = response;

        journal.AddEntry(newEntry);
        Console.WriteLine("Entry added.");
    }

    static void SaveJournal(Journal journal)
    {
        Console.WriteLine("Enter filename to save:");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved.");
    }

    static void LoadJournal(Journal journal)
    {
        Console.WriteLine("Enter filename to load:");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded.");
    }
}