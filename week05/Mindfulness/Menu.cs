using System;

public class Menu
{
    private Progress _progress;

    public Menu(Progress progress)
    {
        _progress = progress;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Show progress");
        Console.WriteLine("5. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void Run()
    {
        while (true)
        {
            DisplayMenu();
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        new BreathingActivity(_progress).Run();
                        break;
                    case 2:
                        new ReflectingActivity(_progress).Run();
                        break;
                    case 3:
                        new ListingActivity(_progress).Run();
                        break;
                    case 4:
                        _progress.Show();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
