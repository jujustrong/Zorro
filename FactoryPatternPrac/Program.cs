namespace FactoryPatternPrac;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What type of phone do you have?");
        var userInput = Console.ReadLine();
        var phone = PhoneFactory.BuildPhone(userInput);
        phone.Text();
        phone.Call();



    }
}