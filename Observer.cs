namespace CodingChallenge;

public class Observer
{
    public string Name { get; }
    protected Observer(string name)
    {
        Name = name;
    }
}