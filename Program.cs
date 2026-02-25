using System.Reflection.Metadata.Ecma335;
using System.Net.WebSockets;
using CodingChallenge;


// var machine = new Machine("Flexo");
// var machine2 = new Machine("Bender");
// var employee1 = new Employee("Alice", "Technician");
// var employee2 = new Employee("Bobert", "Manager");
// var employee3 = new Employee("Charlie", "Technician");


var machines = new List<Machine>()
{
    new Machine("Flexo"),
    new Machine("Bender"),
    new Machine("Roberto")
};

var employees = new List<Employee>()
{
    new Employee("Alice", "Technician"),
    new Employee("Bobert", "Manager"),
    new Employee("Charlie", "Technician")

};


machines[0].Attach(employees[0]); // Alice is interested in updates from Flexo
machines[0].Attach(employees[1]); // Bobert is interested in updates from Flexo
machines[1].Attach(employees[2]); // Charlie is interested in updates from Bender


machines[0].SetState(MachineState.Producing);
machines[0].SetState(MachineState.Starved);
machines[1].SetState(MachineState.Producing);
machines[1].SetState(MachineState.Producing);








