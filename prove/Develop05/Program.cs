using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        int userPoints = 0;
        int option = 0;
        bool completedSimpleGoal = false;
        List<Goal> listOfGoals = new List<Goal>();


        while (option != 6)
        {

            Console.WriteLine();
            Console.WriteLine($"You have {userPoints} points.");
            Console.WriteLine();
            Console.WriteLine("[1] Create a New Goal");
            Console.WriteLine("[2] List Goals");
            Console.WriteLine("[3] Save Goals");
            Console.WriteLine("[4] Load Goals");
            Console.WriteLine("[5] Record Event");
            Console.WriteLine("[6] Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("The type of Goals are: ");
                    Console.WriteLine("[1] Simple Goal");
                    Console.WriteLine("[2] Eternal Goal ");
                    Console.WriteLine("[3] Checklist Goal ");
                    Console.Write("Which type of goal would you like to create? ");
                    int goalOption = int.Parse(Console.ReadLine());
                    switch (goalOption)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("What is the name of your goal? ");
                            string simpleGoalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string simpleGoalDescription = Console.ReadLine();
                            Console.Write("What is the amount assosiated to this goal? ");
                            int simpleGoalPoints = int.Parse(Console.ReadLine());
                            bool finished = false;
                            SimpleGoal simpleGoal = new(simpleGoalName, simpleGoalDescription, simpleGoalPoints, finished);
                            listOfGoals.Add(simpleGoal);
                            break;

                        case 2:
                            Console.Clear();
                            Console.Write("What is the name of your goal? ");
                            string eternalGoalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string eternalGoalDescription = Console.ReadLine();
                            Console.Write("What is the amount assosiated to this goal? ");
                            int eternalGoalPoints = int.Parse(Console.ReadLine());
                            EternalGoal eternalGoal = new(eternalGoalName, eternalGoalDescription, eternalGoalPoints);
                            listOfGoals.Add(eternalGoal);
                            break;
                        case 3:
                            Console.Clear();
                            Console.Write("What is the name of your goal? ");
                            string checklistGoalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string checklistGoalDescription = Console.ReadLine();
                            Console.Write("What is the amount assosiated to this goal? ");
                            int checklistGoalPoints = int.Parse(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int checklistVerificationCounter = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplish at that many times? ");
                            int checklistBonusGoalCompleted = int.Parse(Console.ReadLine());                        
                            int checkListCounter = 0;
                            CheckListGoal checklistGoal = new(checklistGoalName, checklistGoalDescription, checklistGoalPoints, checklistVerificationCounter, checklistBonusGoalCompleted, checkListCounter);
                            listOfGoals.Add(checklistGoal);
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Wrong. Please choose another option.");
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("The goals are: ");
                    Console.WriteLine();
                    int count = 1;
                    foreach (var goal in listOfGoals)
                    {
                        Console.WriteLine(count + ". " + goal.GetGoalInformation());
                        count++;
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.Write("What is the filename for the goal file? ");
                    string fileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine(userPoints);
                        foreach (var goal in listOfGoals)
                        {
                            outputFile.WriteLine(goal.GetStringRepresentation());
                        }
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("What is the filename for the goal file? ");
                    fileName = Console.ReadLine();
                    string[] linesInFile = System.IO.File.ReadAllLines(fileName);
                    string firstLine = linesInFile[0];
                    userPoints = int.Parse(firstLine);

                    List<Goal> tempList = new List<Goal>();
                    for (int i = 0; i < linesInFile.Length; i++)
                    {
                        if (i != 0)
                        {
                            var parts = linesInFile[i].Split(':')[1].Split(',');
                            if (linesInFile[i].StartsWith("SimpleGoal:"))
                            {
                                SimpleGoal simpleGoal = new(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
                                tempList.Add(simpleGoal);
                                if (!tempList.Any(goal => goal.GetGoalName() == simpleGoal.GetGoalName()))
                                {
                                    tempList.Add(simpleGoal);
                                }

                            }
                            else if (linesInFile[i].StartsWith("EternalGoal:"))
                            {
                                EternalGoal eternalGoal = new(parts[0], parts[1], int.Parse(parts[2]));

                                if (!tempList.Any(goal => goal.GetGoalName() == eternalGoal.GetGoalName()))
                                {
                                    tempList.Add(eternalGoal);
                                }
                            }
                            else if (linesInFile[i].StartsWith("CheckListGoal:"))
                            {
                                CheckListGoal checkListGoal = new(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                                tempList.Add(checkListGoal);
                                if (!tempList.Any(goal => goal.GetGoalName() == checkListGoal.GetGoalName()))
                                {
                                    tempList.Add(checkListGoal);
                                }
                            }
                        }

                    }
                    listOfGoals = tempList;
                    break;
                case 5:
                    Console.Clear();
                    Console.Write("Which is the goal you accomplish? ");
                    int numberToDelete = int.Parse(Console.ReadLine());
                    int indexToDelete = numberToDelete - 1;
                    if (indexToDelete >= 0 && indexToDelete < listOfGoals.Count)
                    {
                        Goal goalToDelete = listOfGoals[indexToDelete];
                        if (goalToDelete is SimpleGoal)
                        {
                            userPoints = ((SimpleGoal)goalToDelete).GetGoalCompleted(userPoints);
                            if (completedSimpleGoal == false)
                            {
                                Console.WriteLine($"Congratulations! You have earned {goalToDelete.GetGoalPoints()} points!");
                                Console.WriteLine($"You now have {userPoints} points.");
                                completedSimpleGoal = true;
                            }

                        }
                        if (goalToDelete is EternalGoal)
                        {
                            userPoints = ((EternalGoal)goalToDelete).GetGoalCompleted(userPoints);
                            Console.WriteLine($"Congratulations! You have earned {goalToDelete.GetGoalPoints()} points!");

                        }
                        if (goalToDelete is CheckListGoal)
                        {
                            userPoints = ((CheckListGoal)goalToDelete).GetGoalCompleted(userPoints);
                            if (!goalToDelete.GetGoalInformation().StartsWith("[X]"))
                            {
                                Console.WriteLine($"Congratulations! You have earned {goalToDelete.GetGoalPoints()} points!");
                                Console.WriteLine($"You now have {userPoints} points.");
                            }
                            else
                            {

                            }

                        }

                        listOfGoals.RemoveAt(indexToDelete);
                        listOfGoals.Insert(indexToDelete, goalToDelete);

                        Console.WriteLine();
                    }
                    break;
                case 6:
                    break; 
                default:
                    Console.Clear();
                    Console.WriteLine("Wrong. Please choose another option.");
                    break;
            }

        }
    }
}