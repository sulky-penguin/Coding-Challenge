namespace CodingChallenge;

public abstract class Subject
{
    private List<Observer> _observers = new List<Observer>();
    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }
    public void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }
    public void NotifyAllObservers(string state, string from)
    {
        foreach (var observer in _observers)
        {
            observer.Update(state, from);
        }
    }
}