namespace CodingChallenge;

public abstract class Observer
{
    public string Name { get; }
    protected Observer(string name)
    {
        Name = name;
    }
    public abstract void Update(string state, string from);
}