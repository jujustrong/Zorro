namespace Zorro_App;

public class App
{
    public static void RunApp()
    {
        var running = true;
        while (running == true)
        {
            Console.Write("Would you like to use the Zorro App? (Y/N) ");
            var start = Console.ReadLine();
            Console.Clear();
            while (start.ToLower() != "y" && start.ToLower() != "n")
            {
                Console.WriteLine("Sorry that is not an option");
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write("Would you like to use the Zorro App? (Y/N) ");
                start = Console.ReadLine();
            }

            if (start.ToLower() == "n")
            {
                Console.WriteLine("Thanks for using the app, we will see you soon!"); 
                running = false;
            }
            else { Dialogue.SelectionMenu(); }
            
            
            






        }
        
        
    }
    
    
    
    
}