namespace CodingChallenge;
public class Machine : Subject
{
    public string Name { get; }

    public Machine(string name)
    {
        Name = name;
        State = MachineState.Idle.ToString(); // directly set the initial state to Idle as this is initialization and not a change to be notifiedd.
    }
    public void SetState(MachineState state)
    {
        SetState(state.ToString());
    }
}