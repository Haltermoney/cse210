using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running("10 Dec 2025", "30", "2.5");
        activities.Add(running);
        StationaryBike stationaryBike = new StationaryBike("11 Dec 2025", "45", "10");
        activities.Add(stationaryBike);
        Swimming swimming = new Swimming("12 Dec 2025", "20", "10");
        activities.Add(swimming);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}