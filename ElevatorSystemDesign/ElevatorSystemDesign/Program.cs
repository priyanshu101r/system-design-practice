

using ElevatorSystemDesign.Controller;
using ElevatorSystemDesign.Enums;
using ElevatorSystemDesign.Factory;
using ElevatorSystemDesign.Modal;

while (true)
{
    Console.WriteLine("Enter source floor (or -1 to exit):");
    int source = int.Parse(Console.ReadLine());

    if (source == -1) break;

    Console.WriteLine("Enter direction (UP/DOWN):");
    var direction = Enum.Parse<Direction>(Console.ReadLine(), true);




    SearchElevator searchObj = new SearchElevator
    {

        CurrentFloor = new Floor { FloorId = source },
        Direction = direction
    };

    IElevatorSystem elevatorSystem = ElevatorSystemFactory.Create();
    var elevator = elevatorSystem.RequestElevator(searchObj);
    Console.WriteLine("Your Request will be fullfield by Elevetor Id: " + elevator.Id);

    Console.WriteLine("Enter Destination floor (or -1 to exit):");
    int distionation = int.Parse(Console.ReadLine());
    if (distionation == -1) break;


    Console.WriteLine("Enter Elevtor E1/E2/E3/E4/E5:");
    string eleva = Convert.ToString(Console.ReadLine());


    elevatorSystem.HandleInternalRequest(new Elevator { Id = eleva }, new Floor { FloorId = distionation });
}




