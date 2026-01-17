using ElevatorSystemDesign.Enums;

namespace ElevatorSystemDesign.Modal
{
    public class Elevator
    {

        public string Id { get; set; }
        public int Cpacity { get; set; }
        public Direction Directon { get; set; }
        public Status Status { get; set; }
        public Floor CurrentFloor { get; set; } = new Floor { FloorId = 1 };
        public Floor TargetFloor { get; set; }
        public int Speed { get; set; }
        public DoorStatus DoorStatus { get; set; }

    }
}
