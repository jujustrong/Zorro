namespace Zorro_App;

public class ActivityLog
{
    
    private List<Activity> activities = new List<Activity>();

    public void LogActivity(Activity activity)
    {
        activities.Add(activity);
        Console.WriteLine($"{activity.Type} logged successfully.");
    }

    public void ViewActivities()
    {
        if (activities.Count == 0) { Console.WriteLine("No activities logged yet!"); }
        else
        {
            Console.WriteLine("Logged activities:");
            foreach (var i in activities)
            {
                Console.WriteLine(i);
            }
        }
        
        
    }

    // public void DeleteActivity()
    // {
    //     if (activities.Count == 0) { Console.WriteLine("No activities logged yet!"); return;}
    //     
    //     ViewActivities();
    //     Console.WriteLine("Enter the number of the activity you want to delete: ");
    //     if (int.TryParse(Console.ReadLine(), out var activityChoice) && activityChoice > 0 && activityChoice <= activities.Count)
    //     {
    //         activities.RemoveAt(activityChoice - 1);
    //         Console.WriteLine("Activity deleted successully");
    //     }
    // }

}    