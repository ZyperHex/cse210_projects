class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=== Eternal Quest ===");
            manager.DisplayPlayerInfo();
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Show Goal Names");
            Console.WriteLine("2. Show Goal Details");
            Console.WriteLine("3. Create a New Goal");
            Console.WriteLine("4. Register Event");
            Console.WriteLine("5. Save Goal");
            Console.WriteLine("6. Load Goal");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.ListGoalNames();
                    break;
                case "2":
                    manager.ListGoalDetails();
                    break;
                case "3":
                    manager.CreateGoal();
                    break;
                case "4":
                    manager.RecordEvent();
                    break;
                case "5":
                    manager.SaveGoals();
                    break;
                case "6":
                    manager.LoadGoals();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }

        Console.WriteLine("Thanks for using ETERNAL QUEST!, Good luck with your quest!");
    }
}