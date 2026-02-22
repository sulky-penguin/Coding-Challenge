namespace CodingChallenge;

class Employee : Observer
{
    public string Role { get; }
    public Employee(string name, string role) : base(name)
    {
        Role = role;
    }
    public override void Update(string state, string from)
    {
        Console.WriteLine($"My name is {Name} with role {Role} and I received update from {from}: {state}");
    }
}