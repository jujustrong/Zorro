namespace FactoryPatternPrac;

public interface IMobilePhone
{
    public int Number { get; set; }

    public void Call();
    public void Text();


}