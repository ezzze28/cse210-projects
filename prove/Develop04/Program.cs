using System;

class Program
{
    static void Main(string[] args)
    {

        void ShowSpinnerWithText(string text, string position = "left")
        {
            string activityName = text;
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            if (position == "left")
            {
                while (true)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("| " + activityName);

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write("/ " + activityName);

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write("— " + activityName);

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write("\\ " + activityName);

                    Thread.Sleep(500);

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

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write(activityName + " /");

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write(activityName + " —");

                    Thread.Sleep(500);

                    Console.SetCursorPosition(x, y);
                    Console.Write(activityName + " \\");

                    Thread.Sleep(500);

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

        bool quitProgramm = false;
        while (quitProgramm != true)

        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choise from the menu: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breatheActivity = new("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Final Message");
                    Console.WriteLine(breatheActivity.GetActivityNameDisplay());
                    Console.WriteLine();
                    Console.WriteLine(breatheActivity.GetActivityDescriptionDisplay());
                    Console.WriteLine();
                    string durationStringBreathe = breatheActivity.GetActivityDurationDisplay();
                    int durationNumberBreathe = int.Parse(durationStringBreathe);
                    int copyOfDurationBA = durationNumberBreathe;
                    Console.Clear();
                    breatheActivity.GetCooldownBreatheActivity(copyOfDurationBA);
                    breatheActivity.SetActivityDuration(durationNumberBreathe);
                    Console.WriteLine(breatheActivity.GetFinalActivityMessageDisplay());
                    ShowSpinnerWithText("");
                    Console.Clear();


                    break;

                case "2":
                    Console.Clear();
                    ReflectionActivity reflectionActivity = new("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Final Message");
                    ReflectionActivity phrasesReflectionList = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Final Message");
                    phrasesReflectionList.AddPhaseToList("Think of a time when you stood up for someone else.");
                    phrasesReflectionList.AddPhaseToList("Think of a time when you did something really difficult.");
                    phrasesReflectionList.AddPhaseToList("Think of a time when you helped someone in need.");
                    phrasesReflectionList.AddPhaseToList("Think of a time when you did something truly selfless.");
                    List<string> listaToUsePhrases = new List<string> { };
                    listaToUsePhrases.AddRange(phrasesReflectionList.GetAllReflectionPhases());
                    ReflectionActivity questionsReflectionList = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Final Message");
                    questionsReflectionList.AddPhaseToList("Why was this experience meaningful to you?");
                    questionsReflectionList.AddPhaseToList("Have you ever done anything like this before?");
                    questionsReflectionList.AddPhaseToList("How did you get started?");
                    questionsReflectionList.AddPhaseToList("How did you feel when it was complete?");
                    questionsReflectionList.AddPhaseToList("What made this time different than other times when you were not as successful?");
                    questionsReflectionList.AddPhaseToList("What is your favorite thing about this experience?");
                    questionsReflectionList.AddPhaseToList("What could you learn from this experience that applies to other situations?");
                    questionsReflectionList.AddPhaseToList("What did you learn about yourself through this experience?");
                    questionsReflectionList.AddPhaseToList("How can you keep this experience in mind in the future?");
                    List<string> listaToUseQuestions = new List<string> { };
                    listaToUseQuestions.AddRange(questionsReflectionList.GetAllReflectionPhases());
                    
                    Console.WriteLine(reflectionActivity.GetActivityNameDisplay());
                    Console.WriteLine();
                    Console.WriteLine(reflectionActivity.GetActivityDescriptionDisplay());
                    Console.WriteLine();
                    string durationStringReflection = reflectionActivity.GetActivityDurationDisplay();
                    int durationNumberReflection = int.Parse(durationStringReflection);
                    int copyOfDurationRA = durationNumberReflection;
                    reflectionActivity.GetCooldownReflectionActivity(copyOfDurationRA, listaToUsePhrases, listaToUseQuestions);
                    Console.WriteLine();
                    reflectionActivity.SetActivityDuration(durationNumberReflection);
                    Console.WriteLine(reflectionActivity.GetFinalActivityMessageDisplay());
                    ShowSpinnerWithText("");
                    Console.Clear();
                    break;

                case "3":
                    Console.Clear();
                    ListingActivity listingActivity = new("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Final Message");
                    ListingActivity listingGoodThingsPrompts = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Final Message");
                    listingGoodThingsPrompts.AddPhaseToGoodThingsList("Who are people that you appreciate? ");
                    listingGoodThingsPrompts.AddPhaseToGoodThingsList("What are personal strengths of yours? ");
                    listingGoodThingsPrompts.AddPhaseToGoodThingsList("Who are people that you have helped this week? ");
                    listingGoodThingsPrompts.AddPhaseToGoodThingsList("When have you felt the Holy Ghost this month? ");
                    listingGoodThingsPrompts.AddPhaseToGoodThingsList("Who are some of your personal heroes? ");
                    List<string> listaToUseQuestionPromps = new List<string> { };
                    listaToUseQuestionPromps.AddRange(listingGoodThingsPrompts.GetAllListingPrompts());

                    Console.WriteLine(listingActivity.GetActivityNameDisplay());
                    Console.WriteLine();
                    Console.WriteLine(listingActivity.GetActivityDescriptionDisplay());
                    Console.WriteLine();
                    string durationStringListing = listingActivity.GetActivityDurationDisplay();
                    int durationNumberListing = int.Parse(durationStringListing);
                    int copyOfDurationLA = durationNumberListing;
                    listingActivity.GetCooldownListingActivity(copyOfDurationLA, listaToUseQuestionPromps);
                    Console.WriteLine();
                    listingActivity.SetActivityDuration(durationNumberListing);
                    ShowSpinnerWithText("");
                    Console.WriteLine(listingActivity.GetFinalActivityMessageDisplay());
                    ShowSpinnerWithText("");
                    Console.Clear();
                    break;

                case "4":
                    quitProgramm = true;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Wrong. Please try again. ");
                    break;

            }
        }


    }
}