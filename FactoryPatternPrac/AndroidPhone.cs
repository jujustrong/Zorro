namespace FactoryPatternPrac;

public class AndroidPhone : IMobilePhone
{
    public int Number { get; set; }
    
    public void Call()
    {
        Console.WriteLine("Calling with an Android...");
    }

    public void Text()
    {
        Console.WriteLine("Texting with an Android...");
    }
}