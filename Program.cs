using CodingChallenge;


var machine = new Machine("Roberto");
var employee1 = new Employee("Alice", "Engineer");

machine.Attach(employee1);
machine.SetState(MachineState.Producing);

