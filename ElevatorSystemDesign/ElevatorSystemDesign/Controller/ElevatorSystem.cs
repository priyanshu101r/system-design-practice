using ElevatorSystemDesign.Modal;

namespace ElevatorSystemDesign.Controller
{
    public class ElevatorSystem : IElevatorSystem
    {
        public readonly ElevatorController controller;
        public ElevatorSystem(ElevatorController controller)
        {
            this.controller = controller;
        }

        public Elevator RequestElevator(SearchElevator searchObj)
        {
            return controller.HandleExternalRequest(searchObj);
        }
        public void HandleInternalRequest(Elevator elevator, Floor targetFloor)
        {
            controller.HandleInternalRequest(elevator, targetFloor);
        }
    }
}
