namespace CodingChallenge;
public class Machine : Subject
{
    public string Name { get; }
    public Machine(string name)
    {
        Name = name;
    }
    public void ChangeState(string state)
    {
        NotifyAllObservers(state, Name);
    }
}