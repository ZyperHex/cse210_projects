using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a list of videos
        List<Video> videos = new List<Video>();


        //Create and add videos with comments:

        Video video1 = new Video("C# Tutorial", "John Doe", 300);
        video1.AddComment("Alice", "Great tutorial!");
        video1.AddComment("John", "Very Helpful, also you have my name!");
        video1.AddComment("Charlie", "Very Clear");
        videos.Add(video1);

        Video video2 = new Video("Python Basics", "Jane Smith", 450);
        video2.AddComment("David", "Awesome content!");
        video2.AddComment("Eve", "I learned a lot.");
        video2.AddComment("Frank", "Keep up the good work.");
        video2.AddComment("Grace","This is great!");
        videos.Add(video2);

        Video video3 = new Video("JavaScript Guide", "Mike Johnson", 600);
        video3.AddComment("Henry", "Excellent explanation.");
        video3.AddComment("Ivy", "This is useful.");
        video3.AddComment("Jack", "I have a question...");
        videos.Add(video3);

         Video video4 = new Video("React for beginners", "Mary Williams", 600);
        video4.AddComment("Karen", "Loved this");
        video4.AddComment("Liam", "Very usefull information");
        video4.AddComment("Mia", "Where can I find more?");
        videos.Add(video4);

        // Iterate through the list of videos and display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.CountComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(); // Add a blank line for separation
        }
    }
}