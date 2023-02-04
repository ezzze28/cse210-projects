using System;

public class ListingActivity : Activity
{
    private List<string> _goodThingsList = new List<string>();
    private Random _random = new Random();
    public ListingActivity(string activityName, string activityDescription, string activityFinalMessage) : base(activityName, activityDescription, activityFinalMessage) //base() are the propieties from Activity (base/father class)
    {
        _goodThingsList = new List<string>();
        _random = new Random();
    }
    public List<string> GetAllListingPrompts()
    {
        return _goodThingsList;
    }
    public void SetAllReflectionPhasesList(List<string> goodThingsPrompts)
    {
        _goodThingsList = goodThingsPrompts;
    }

    public void AddPhaseToGoodThingsList(string goodThingsPrompts)
    {
        _goodThingsList.Add(goodThingsPrompts);
    }

    public string GetRandomChoosenGoodThingsPrompts()
    {
        int indexOfList = _random.Next(_goodThingsList.Count);
        return _goodThingsList[indexOfList];
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

                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(x + activityName.Length, y);
                    Console.Write("   ");
                    Console.WriteLine();
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

                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(x + activityName.Length, y);
                    Console.Write("   ");
                    Console.WriteLine();
                    break;
                }

            }
        }
    }
    public int GetCooldownListingActivity(int seconds, List<string> listToUsePhrases )
    {
        _goodThingsList = listToUsePhrases;
        int original = seconds;
        int copy = original;
        int counter = 0;
        DateTime newTime = DateTime.Now.AddSeconds(copy);
        int remaining = seconds;
        string message = "You may begin in: ";
        Console.WriteLine("Let's start...");
        ShowSpinnerWithText("");
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine();

        Random rand = new Random();
        int index = rand.Next(0, listToUsePhrases.Count);
        Console.WriteLine($"---- {listToUsePhrases[index]} ----");
        Console.WriteLine();


        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        List<string> listOfUserInput = new List<string>();

        for (int i = 3; i > 0; i--)
        {

            Console.SetCursorPosition(x, y);
            Console.Write($"\r{message}" + i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("");
        Console.WriteLine("");

        while (DateTime.Now <= newTime)
        {
            Console.Write("");
            string input = Console.ReadLine();
            listOfUserInput.Add(input);
            counter = counter + 1;

            if (DateTime.Now >= newTime)
            {
                break;
            }

        }

        foreach (var item in listOfUserInput)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("");
        Console.WriteLine($"You listed {counter} items! ");

        return original;
    }

}