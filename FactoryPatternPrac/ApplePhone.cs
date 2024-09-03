namespace FactoryPatternPrac;

public class ApplePhone : IMobilePhone
{
    public int Number { get; set; }
    
    public void Call()
    {
        Console.WriteLine("Calling with an IPhone...");
    }

    public void Text()
    {
        Console.WriteLine("Texting with an IPhone...");
    }
}