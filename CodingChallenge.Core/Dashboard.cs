namespace CodingChallenge;

public class Dashboard : Observer
{
    public Dashboard(string name, string role) : base(name)
    {

    }
    public override void Update(string state, string from)
    {
        //Console.WriteLine($"My name is {Name} with role {Role} and I received update from {from}: {state}");
    }
}