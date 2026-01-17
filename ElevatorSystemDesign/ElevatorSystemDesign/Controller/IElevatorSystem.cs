using ElevatorSystemDesign.Modal;

namespace ElevatorSystemDesign.Controller
{
    public interface IElevatorSystem
    {
        Elevator RequestElevator(SearchElevator searchObj);

        void HandleInternalRequest(Elevator elevator, Floor targetFloor);

    }
}
