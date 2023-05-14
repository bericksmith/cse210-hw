using System;

public class BreathingActivity : Activity
{
    private string _userMessage1 = "Breathe in...";
    private string _userMessage2 = "Now breathe out...";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }

    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

 public void Breathing(int seconds)
    {
        Console.WriteLine();
        int timer = 0;
        while (timer < seconds)
        {
            Console.WriteLine();
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_userMessage1}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_userMessage1.Length + 2));
                Console.Write(blank);
                timer += 1;
            }
            Console.WriteLine($"{_userMessage1}  ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_userMessage2}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_userMessage2.Length + 2));
                Console.Write(blank);
                timer += 1;
            }
            Console.WriteLine($"{_userMessage2}  "); 
        }
    }
}
