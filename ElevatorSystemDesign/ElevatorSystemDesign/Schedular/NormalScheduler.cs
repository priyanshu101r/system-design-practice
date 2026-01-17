using ElevatorSystemDesign.ElevatorRepository;
using ElevatorSystemDesign.Enums;
using ElevatorSystemDesign.Modal;

namespace ElevatorSystemDesign.Schedular
{
    public class NormalScheduler : IScheduler
    {
        private readonly IElevatorRepository elevatorRepository;
        public NormalScheduler(IElevatorRepository elevatorRepository)
        {
            this.elevatorRepository = elevatorRepository;
        }
        public Elevator GetBestElevator(SearchElevator searchObj)
        {
            //need to write algo for return best suited elevator
            var elevators = this.elevatorRepository.GetAall();

            // 1️⃣ Prefer IDLE elevators
            var idleElevator = elevators
                .Where(e => e.Status == Enums.Status.IDLE)
                .OrderBy(e => Math.Abs(e.CurrentFloor.FloorId - searchObj.CurrentFloor.FloorId))
                .FirstOrDefault();

            if (idleElevator != null)
            {
                return idleElevator;
            }

            // 2️⃣ Same direction & on the way
            var sameDirectionElevator = elevators
                .Where(e => e.Directon == searchObj.Direction)
                .Where(e => IsOnTheWay(e, searchObj))
                .OrderBy(e => Math.Abs(e.CurrentFloor.FloorId - searchObj.CurrentFloor.FloorId))
                .FirstOrDefault();

            if (sameDirectionElevator != null)
            {
                return sameDirectionElevator;
            }

            // 3️⃣ Fallback → nearest elevator
            var nearestElevator = elevators
                .OrderBy(e => Math.Abs(e.CurrentFloor.FloorId - searchObj.CurrentFloor.FloorId))
                .FirstOrDefault();

            return nearestElevator;
        }
        private bool IsOnTheWay(Elevator elevator, SearchElevator request)
        {
            if (elevator.Directon == Direction.UP)
            {
                return elevator.CurrentFloor.FloorId <= request.CurrentFloor.FloorId;
            }

            if (elevator.Directon == Direction.Down)
            {
                return elevator.CurrentFloor.FloorId >= request.CurrentFloor.FloorId;
            }

            return false;
        }
    }
}
