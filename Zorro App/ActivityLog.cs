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

    public void DeleteActivity()
    {
        if (activities.Count == 0) { Console.WriteLine("No activities logged yet!"); return;}
        
        ViewActivities();
        Console.Write("Enter the number of the activity you want to delete: ");
        var choiceSuccess = int.TryParse(Console.ReadLine(), out var activityChoice);
        Console.Clear();
        
        while (!choiceSuccess && activityChoice !> 0 && activityChoice > activities.Count)
        {
            Console.WriteLine("Data Entry Error // Please enter a number in range..."); 
            choiceSuccess = int.TryParse(Console.ReadLine(), out activityChoice);
            Console.Clear();
        }
        
        activities.RemoveAt(activityChoice - 1);
        Console.WriteLine("Activity deleted successfully");
        Console.Clear();
    }
    

}    