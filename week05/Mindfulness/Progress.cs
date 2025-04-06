using System;
using System.IO;
using System.Text.Json;

public class Progress
{
    public int BreathingSessions { get; set; }
    public int ReflectingSessions { get; set; }
    public int ListingSessions { get; set; }
    public int TotalTimeSeconds { get; set; }

    public void SaveToFile(string filePath)
    {
        string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public static Progress LoadFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Progress>(json);
        }
        else
        {
            return new Progress();
        }
    }

    public void Show()
    {
        Console.WriteLine("\n--- Progress Summary ---");
        Console.WriteLine($"Breathing Sessions: {BreathingSessions}");
        Console.WriteLine($"Reflecting Sessions: {ReflectingSessions}");
        Console.WriteLine($"Listing Sessions: {ListingSessions}");
        Console.WriteLine($"Total Time Spent: {TotalTimeSeconds} seconds\n");
    }
}