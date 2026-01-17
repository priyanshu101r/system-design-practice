using ElevatorSystemDesign.Modal;
using ElevatorSystemDesign.Schedular;



namespace ElevatorSystemDesign.Controller
{
    public class ElevatorController
    {
        // private readonly IElevatorRepository elevatorRepository;
        private Dispatcher dispatcher;

        public ElevatorController(Dispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
        }

        public Elevator HandleExternalRequest(SearchElevator searchElevator)
        {
            var elevator = dispatcher.Dispatch(searchElevator);
            if (elevator.CurrentFloor.FloorId == searchElevator.CurrentFloor.FloorId && elevator.Directon == Enums.Direction.UP)
            {
                elevator.TargetFloor = new Floor { FloorId = 5 };
            }
            else if (elevator.CurrentFloor.FloorId == searchElevator.CurrentFloor.FloorId && elevator.Directon == Enums.Direction.Down)
            {
                elevator.TargetFloor = new Floor { FloorId = 1 };
            }
            else
            {
                elevator.TargetFloor = searchElevator.CurrentFloor;
            }
            StartElevator(elevator);
            return elevator;
        }

        public Elevator HandleInternalRequest(Elevator elevator, Floor targetFloor)
        {
            elevator.TargetFloor = targetFloor;
            StartElevator(elevator);
            return elevator;
        }
        public void StartElevator(Elevator elevator)
        {
            if (elevator.CurrentFloor.FloorId < elevator.TargetFloor.FloorId && elevator.Directon == Enums.Direction.UP)
            {
                for (int i = elevator.CurrentFloor.FloorId; i < elevator.TargetFloor.FloorId; i++)
                {
                    Console.WriteLine("Elevator is at Floor: " + i);
                }

                Console.WriteLine("Elevator has reached at Floor: " + elevator.TargetFloor.FloorId);
                OpenDoor();
                CloseDoor();
            }
            if (elevator.CurrentFloor.FloorId > elevator.TargetFloor.FloorId && elevator.Directon == Enums.Direction.Down)
            {
                for (int i = elevator.CurrentFloor.FloorId; i > elevator.TargetFloor.FloorId; i--)
                {
                    Console.WriteLine("Elevator is at Floor: " + i);

                }
                Console.WriteLine("Elevator has reached at Floor: " + elevator.TargetFloor.FloorId);
                OpenDoor();
                CloseDoor();
            }

        }

        public void OpenDoor()
        {
            Console.WriteLine("Dor has Opend");
        }
        public void CloseDoor()
        {
            Console.WriteLine("Door going to be closed, please be away from the door");
        }

    }
}
