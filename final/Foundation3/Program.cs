using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        Lecture lect1 = new Lecture("Tony Hawcin", 100, "Lecture", "SkatePark Show", "Tony Hawk teaches how to do an ollie", "10-10-2022", "10:00AM", "Flores Skate Park");
        Console.WriteLine(lect1.GetStandardDetails());
        Console.WriteLine(lect1.GetFullDetails());
        Console.WriteLine(lect1.GetShortDescription());

        Reception rec1 = new Reception("Required", "Reception", "Jose and Cecilia Reception", "Celebrating the Robles Salazar Wedding", "21-02-1995", "18:00PM", "Calle 127 Autopista North");
        Console.WriteLine(rec1.GetStandardDetails());
        Console.WriteLine(rec1.GetFullDetails());
        Console.WriteLine(rec1.GetShortDescription());

        OutdoorGathering out1 = new OutdoorGathering("High near 80F. Winds ENE at 5 to 10 mph. Chance of rain 70%. Variably cloudy with scattered thunderstorms.", "Outdoor Gathering", "FMS 11 Jornada", "Final FMS Colombia", "12-02-2023", "16:30PM", "Parque del Valle de Aburra");
        Console.WriteLine(out1.GetStandardDetails());
        Console.WriteLine(out1.GetFullDetails());
        Console.WriteLine(out1.GetShortDescription());

        List<Event> events = new List<Event>();
        events.Add(lect1);
        events.Add(rec1);
        events.Add(out1);

    }
}