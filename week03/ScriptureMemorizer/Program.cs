class Program
{
    static void Main(string[] args)
    {
        
        List<Scripture> scriptures = new()
        {
            // Instancia 1: John 3:16
            new Scripture(new Reference("John", 3, 16), 
                "For God so loved the world \nthat he gave his one and only Son, \nthat whoever believes in him shall not perish but have eternal life."),

            // Instancia 2: Proverbs 3:5-6
            new Scripture(new Reference("Proverbs", 3, 5, 6), 
                "Trust in the Lord with all your heart and lean not on your own understanding; \nin all your ways submit to him, and he will make your paths straight."),

            // Instancia 3: Psalm 23:1
            new Scripture(new Reference("Psalm", 23, 1), 
                "The Lord is my shepherd, I lack nothing."),

            // Instancia 4: Matthew 5:14-16
            new Scripture(new Reference("Matthew", 5, 14, 16), 
                "You are the light of the world. A town built on a hill cannot be hidden. \nNeither do people light a lamp and put it under a bowl. Instead they put it on its stand, and it gives light to everyone in the house. \nIn the same way, let your light shine before others, that they may see your good deeds and glorify your Father in heaven."),

            // Instancia 5: 1 Corinthians 13:4-7
            new Scripture(new Reference("1 Corinthians", 13, 4, 7), 
                "Love is patient, love is kind. It does not envy, it does not boast, it is not proud. \nIt does not dishonor others, it is not self-seeking, it is not easily angered, it keeps no record of wrongs. \nLove does not delight in evil but rejoices with the truth. It always protects, always trusts, always hopes, always perseveres.")
        };

        // Select a random scripture
        Random random = new();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Main program loop with improved formatting
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to hide words or type 'quit' to exit");

            string choice = Console.ReadLine().ToLower();

            if (choice == "quit")
            {
                Console.WriteLine("\nBye!");
                break;
            }
            
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden!");
                break;
            }
            
            scripture.HideRandomWords(3);
        }
    }
}