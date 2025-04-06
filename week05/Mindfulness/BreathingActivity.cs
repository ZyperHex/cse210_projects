public class BreathingActivity : Activity
{
    public BreathingActivity(Progress progress) : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", progress) { }

    public void Run()
    {
        StartActivity();
        int breathCycles = _duration / 8;
        for (int i = 0; i < breathCycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
        }
        _progress.BreathingSessions++;
        EndActivity();
    }
}
