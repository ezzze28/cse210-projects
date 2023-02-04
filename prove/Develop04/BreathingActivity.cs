using System;

public class BreathingActivity : Activity
{

    private DateTime _cooldownTime;
    public BreathingActivity(string activityName, string activityDescription, string activityFinalMessage) : base(activityName, activityDescription, activityFinalMessage) //base() are the propieties from Activity (base/father class)
    {
        DateTime startTime = DateTime.Now;
        _cooldownTime = startTime.AddSeconds(0);
    }
    public BreathingActivity(string activityName, string activityDescription, string activityFinalMessage, int cooldownTimeActivity) : base(activityName, activityDescription, activityFinalMessage) //base() are the propieties from Activity (base/father class)
    {
        string cooldownTimeString = cooldownTimeActivity.ToString().PadRight(3, '0');
        DateTime startTime = DateTime.Now;
        _cooldownTime = startTime.AddSeconds(int.Parse(cooldownTimeString));
    }

    public DateTime GetCooldown()
    {
        return _cooldownTime;
    }

    public void SetTitle(DateTime settedCooldown)
    {
        string cooldownTimeString = settedCooldown.ToString().PadRight(3, '0');
        DateTime startTime = DateTime.Now;
        _cooldownTime = startTime.AddSeconds(int.Parse(cooldownTimeString));

    }


    private void ShowSpinnerWithText(string text, string position = "left")
    {
        string activityName = text;
        int x = Console.CursorLeft;
        int y = Console.CursorTop;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(20000);

        DateTime currentTime = DateTime.Now;

        if (position == "left")
        {
            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("| " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("/ " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("— " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("\\ " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("| " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("/ " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("— " + activityName);

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write("\\ " + activityName);

                Thread.Sleep(400);

                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter || currentTime < futureTime)
                {
                    break;
                }

            }
        }
        if (position == "right")
        {
            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " |");

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " /");

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " —");

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " \\");

                Thread.Sleep(400);
                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " |");

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " /");

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " —");

                Thread.Sleep(400);

                Console.SetCursorPosition(x, y);
                Console.Write(activityName + " \\");

                Thread.Sleep(400);

                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter || currentTime < futureTime)
                {
                    break;
                }

            }
        }
    }

    public int GetCooldownBreatheActivity(int seconds)
    {
        int original = seconds;
        int copy = original;
        int remaining = seconds;
        bool toggle = true;
        string message = "Breathe in...";
        int countdown = 3;
        Console.WriteLine("Let's start...");
        ShowSpinnerWithText("");
        while (remaining > 0)
        {
            Console.Clear();

            while (countdown > 0 && remaining > 0)
            {
                Console.Clear();
                Console.WriteLine($"{message} {countdown}");

                Thread.Sleep(1000);

                countdown--;
                remaining--;

            }
            if (message == "Breathe in...")
            {
                countdown = 6;
                Console.Clear();
            }
            if (message == "Now Breathe out...")
            {
                countdown = 3;
                Console.Clear();
            }
            toggle = !toggle;
            message = toggle ? "Breathe in..." : "Now Breathe out...";
        }
        return original;
    }

}