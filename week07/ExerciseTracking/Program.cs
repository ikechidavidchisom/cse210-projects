using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Oct 2025", 30, 4.8));
        activities.Add(new Cycling("04 Oct 2025", 45, 20.0));
        activities.Add(new Swimming("05 Oct 2025", 40, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
