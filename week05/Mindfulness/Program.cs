
using System;

class Program
{
    static void Main(string[] args)
    {
        Progress progress = Progress.LoadFromFile("progress.json");
        Menu menu = new Menu(progress);
        menu.Run();
        progress.SaveToFile("progress.json");
    }
}
