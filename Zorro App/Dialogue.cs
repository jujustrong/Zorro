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
        var dateSuccess = DateTime.TryParse(Console.ReadLine(), out var date );
        while (!dateSuccess)
        {
            Console.Write("Date Entry Error // Please use the correct format (MM-DD-YYYY): ");
            dateSuccess = DateTime.TryParse(Console.ReadLine(), out date );
            Console.WriteLine();
        }

        Console.Write("Enter the location: ");
        var location = Console.ReadLine();

        Console.Write("Enter the distance in miles: ");
        var mileageSuccess = double.TryParse(Console.ReadLine(), out var mileage);
        while (!mileageSuccess)
        {
            Console.Write("Data Entry Error // Please enter a number: ");
            mileageSuccess = double.TryParse(Console.ReadLine(), out mileage );
            Console.WriteLine();
        }

        Console.Write("Enter the elevation gain in feet: ");
        var eleSuccess = double.TryParse(Console.ReadLine(), out var elevation);
        while (!eleSuccess)
        {
            Console.Write("Data Entry Error // Please enter numbers only: ");
            eleSuccess = double.TryParse(Console.ReadLine(), out elevation);
            Console.WriteLine();
        }

        Console.Write("Enter the total time in minutes: ");
        var minutesSuccess = double.TryParse(Console.ReadLine(), out var minutes);
        while (!mileageSuccess)
        {
            Console.Write("Data Entry Error // Please enter numbers only: ");
            mileageSuccess = double.TryParse(Console.ReadLine(), out minutes);
            Console.WriteLine();
        }

        var pace = minutes / mileage;

        return new Activity(type, date, location, mileage, minutes, elevation, pace);
    }
    
    public static void PressEnter()
    {
        Console.WriteLine("(Press ENTER to continue)");
        Console.ReadKey();
        Console.WriteLine();
    }

}