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
    public void SetState(string state, string name)
    {
        // Was not specifically mentioned in the requirements but it seems logical to only notify observers if the state has actually changed.
        if (State == state)
            return; 
            
        State = state;
        NotifyAllObservers(name);
    }
    public void NotifyAllObservers(string name) 
    {
        foreach (var observer in _observers)
        {
            observer.Update(State, name);
        }
    }
}