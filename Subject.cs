namespace CodingChallenge;

public abstract class Subject
{
    private List<Observer> _observers = new List<Observer>();
    public string State { get; protected set; } = "";

    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }
    public void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }
    public void SetState(string state)
    {
        State = state;
        NotifyAllObservers();
    }
    public void NotifyAllObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(State, this.GetType().Name);
        }
    }
}