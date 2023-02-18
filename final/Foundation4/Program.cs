using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities =  new List<Activity>();
        activities.Add(new Running("03 Feb 2023",4.8,30));
        activities.Add(new Cycling("05 Feb 2023",9.6,30));
        activities.Add(new Swimming("08 Feb 2023",96,30));
        int i = 1;
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\nFor activity number {i}:\n{activity.GetSummary()}");
            i++;
        }
        Console.WriteLine();
    }
}