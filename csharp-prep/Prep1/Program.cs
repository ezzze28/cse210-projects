using System;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {name} {last}.");
    }
}