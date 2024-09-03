namespace FactoryPatternPrac;

public class GooglePhone : IMobilePhone
{
    public int Number { get; set; }
    
    public void Call()
    {
        Console.WriteLine("Calling with a google phone...");
    }

    public void Text()
    {
        Console.WriteLine("Texting with a google phone...");
    }
}