using System.Threading.Channels;

namespace Zorro_App;

public class Dialogue
{
    public static void SelectionMenu()
    {
        var newLog = new ActivityLog();
        var i = true;
        while (i == true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. LOG ACTIVITY");
            Console.WriteLine("2. VIEW ACTIVITIES");
            Console.WriteLine("3. EXIT ACTIVITY MENU");
            Console.WriteLine("(Enter 1, 2, or 3)");
        
            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.Clear();
                    Console.Write("What type of activity would you like to log? ");
                    var userActivity = Console.ReadLine();
                    newLog.LogActivity(CreateActivity(userActivity));
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
                
                case "2":
                    Console.Clear();
                    newLog.ViewActivities();
                    PressEnter();
                    Console.Clear();
                    break;
                
                case "3":
                    Console.Clear();
                    Console.WriteLine("Exiting Activity Menu...");
                    Thread.Sleep(2000);
                    i = false;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter 1, 2, or 3");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
            }
        }
        
    }

    static Activity CreateActivity(string type)
    {
        Console.Write("Enter the date of the activity (MM-dd-yyyy): ");
        var date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the location: ");
        var location = Console.ReadLine();

        Console.Write("Enter the distance in miles: ");
        var miles = double.Parse(Console.ReadLine());

        Console.Write("Enter the elevation gain in feet: ");
        var elevation = int.Parse(Console.ReadLine());

        Console.Write("Enter the total time in minutes: ");
        var minutes = int.Parse(Console.ReadLine());

        var pace = minutes / miles;

        return new Activity(type, date, location, miles, minutes, elevation, pace);
    }
    
    public static void PressEnter()
    {
        Console.WriteLine("(Press ENTER to continue.)");
        Console.ReadKey();
        Console.WriteLine();
    }

}