using System;

public class Word
    {
        public void GetCompletePhase(string completePhase, List<string> list, bool condition, string reference)
        {
            Console.WriteLine($"The original phase: {completePhase}");

            while (list.Any(s => !s.All(c => c == '-')) && condition)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, list.Count);
                string word = list[index];

                Console.WriteLine("Please, press 'Enter' to continue or 'Exit' to quit.");
                string response = Console.ReadLine().ToLower();
                string newWord = "";
                for (int i = 0; i < word.Length; i++)
                {
                    newWord += "-";
                }

                list[index] = newWord;

                string ultimatePhase = string.Empty;
                for (int i = 0; i < list.Count; i++)
                {
                    ultimatePhase += list[i].ToString() + " ";
                }

                string completeQuote = $"The current phase: {reference} {ultimatePhase}";
                if (response != "exit")
                {
                    Console.Clear();
                    Console.WriteLine(completeQuote);
                }
                else
                {
                    Console.WriteLine("");
                }
                if (response == "exit")
                {
                    condition = false;
                }
            }
        }
    }